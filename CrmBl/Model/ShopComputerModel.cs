using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBl.Model
{
    public class ShopComputerModel
    {
        /// <summary>
        /// This class creates a computer model.
        /// </summary>
        Generator Generator = new Generator();
        Random rnd = new Random();
        List<Task> tasks = new List<Task>();
        CancellationTokenSource cancelTokenSource;
        CancellationToken token;

        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public int CustomerSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 100;

        public ShopComputerModel()
        {
            var sellers = Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);
            Generator.GetNewCustomers(100);

            cancelTokenSource = new CancellationTokenSource();

            foreach(var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for(int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue(), null));
            }
        }

        public void Start()
        {
            // Запуск метода Создания корзин в отдельном потоке.
            tasks.Add(new Task(() => CreateCarts(10, token)));

            // Создание коллекции задач.
            tasks.AddRange(CashDesks.Select(c => new Task(() => CashDesksWork(c, token))));

            // Запуск коллекции задач.
            foreach(var task in tasks)
            {
                task.Start();
            }
        }

        public void Stop()
        {
            cancelTokenSource.Cancel();
            Thread.Sleep(1000);
        }

        // Обработка CashDesks.
        void CashDesksWork(CashDesk cashDesk, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                // Если очередь не пустая..
                if (cashDesk.Count > 0)
                {
                    // Вызов человека из очереди.
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }

        void CreateCarts(int customerCounts, CancellationToken token)
        {
            while(!token.IsCancellationRequested)
            {
                var customers = Generator.GetNewCustomers(customerCounts);

                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);
                    foreach (var product in Generator.GetRandomProducts(10, 30))
                    {
                        cart.Add(product);
                    }
                    // Выбор случайной кассы.
                    var cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(cart);
                }

                Thread.Sleep(CustomerSpeed);
            }
        }
    }
}
