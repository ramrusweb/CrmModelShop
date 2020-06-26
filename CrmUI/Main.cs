using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBl.Model;

namespace CrmUI
{
    public partial class Main : Form
    {
        CrmContext db;
        Cart cart;
        Customer customer;
        CashDesk cashDesk;
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
            cart = new Cart(customer);
            cashDesk = new CashDesk(1, db.Sellers.FirstOrDefault(), db)
            {
                IsModel = false
            };
        }

        // Product.
        void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        // Seller.
        void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        // Customer.
        void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        // Check.
        void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkCustomer = new Catalog<Check>(db.Checks, db);
            checkCustomer.Show();
        }

        // Customer - Add.
        void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges(); 
            }
        }
        
        // Seller - Add.
        void SellerAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        // Product - Add.
        void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        // Run model form.
        void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.Show();
        }

        void Main_Load(object sender, EventArgs e)
        {
            // Output products to the main form.
            Task.Run(() =>
            {
                listBoxProducts.Invoke((Action)delegate
                {
                    listBoxProducts.Items.AddRange(db.Products.ToArray());
                    UpdateLists();
                });      
            });
        }

        // Double-click goods transfer to another window.
        void listBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxProducts.SelectedItem is Product product)
            {
                cart.Add(product);
                listBoxCart.Items.Add(product);
                UpdateLists();
            }
        }

        void UpdateLists()
        {
            listBoxCart.Items.Clear();
            listBoxCart.Items.AddRange(cart.GetAll().ToArray());
            totalLb.Text = "Итого: " + cart.Price;
        }

        void linkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Login();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                var tempCustomer = db.Customers.FirstOrDefault(c => c.Name.Equals(form.Customer.Name));
                if(tempCustomer != null)
                {
                    customer = tempCustomer;
                }
                else
                {
                    db.Customers.Add(form.Customer);
                    db.SaveChanges();
                    customer = form.Customer;
                }
                    cart.Customer = customer;
            }
            linkLb.Text = $"Здравствуй, {customer.Name}";
        }

        void toPayBtn_Click(object sender, EventArgs e)
        {
            if(customer != null)
            {
                cashDesk.Enqueue(cart);
                var price = cashDesk.Dequeue();
                listBoxCart.Items.Clear();
                cart = new Cart(customer);

                MessageBox.Show($"Покупка выполнена успешно! Сумма: {price}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Авторизуйтесь, пожалуйста!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
