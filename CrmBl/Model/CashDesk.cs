using System;
using System.Collections.Generic;

namespace CrmBl.Model
{

    public class CashDesk
    {
        /// <summary>
        /// This class works with cash desk object.
        /// </summary>
        CrmContext db;

        public int Number { get; set; }
        public Seller Seller { get; set; }
        public Queue<Cart> Queue { get; set; }
        public int MaxQueueLength { get; set; }
        public int ExitCustomer { get; set; }
        public bool IsModel { get; set; }
        public int Count => Queue.Count;

        public event EventHandler<Check> CheckClosed;

        public CashDesk(int number, Seller seller, CrmContext db)
        {
            Number = number;
            Seller = seller;
            Queue = new Queue<Cart>();
            IsModel = true;
            MaxQueueLength = 10;
            this.db = db ?? new CrmContext();
        }

        // Метод добавления человека в очередь.
        public void Enqueue(Cart cart)
        {
            if(Queue.Count < MaxQueueLength)
            {
                // Ставим в очередь.
                Queue.Enqueue(cart);
            }
            else
            {
                // Иначе, покупатель выходит из кассы.
                ExitCustomer++;
            }
        }

        // Метод извлечения человека из очереди.
        public decimal Dequeue()
        {
            decimal sum = 0;
            if(Queue.Count == 0)
            {
                return 0;
            }
            var card = Queue.Dequeue();

            if(card != null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,

                    CustomerId = card.Customer.CustomerId,
                    Customer = card.Customer,

                    Created = DateTime.Now
                };

                // Если это не модель, то сохранить в БД.
                if(!IsModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.CheckId = 0;
                }

                var sells = new List<Sell>();

                // Перебор элементов из корзины.
                foreach(Product product in card)
                {
                    // Проверка товара на складе.
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = check.CheckId,
                            Check = check,
                            ProductId = product.ProductId,
                            Product = product
                        };


                        sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }

                        product.Count--;
                        sum += product.Price;
                    }
                }
                check.Price = sum;

                // Сохранение изменений.
                    if(!IsModel)
                    {
                        db.SaveChanges();
                    }
                    // Генерация события.
                CheckClosed?.Invoke(this, check);
            }

            return sum;
        }

        public override string ToString()
        {
            return $"Касса №{Number}";
        }
    }
}
