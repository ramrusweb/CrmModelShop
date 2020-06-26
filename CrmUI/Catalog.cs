using System.Windows.Forms;
using System.Data.Entity;
using CrmBl.Model;
using System;

namespace CrmUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        CrmContext db;
        DbSet<T> set;
        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();

        }

        // Каталог - кнопка Добавить.
        void catAddBtn_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Product))
            {

            }
            else if (typeof(T) == typeof(Seller))
            {

            }
            else if (typeof(T) == typeof(Customer))
            {
                
            }
        }

        // Каталог - кнопка Изменить.
        void catChangeBtn_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            // Product.
            if (typeof(T) == typeof(Product))
            {
                var product = set.Find(id) as Product;
                if (product != null)
                {
                    var form = new ProductForm(product);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product; // TODO:
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }

            // Seller.
            else if (typeof(T) == typeof(Seller))
            {
                var seller = set.Find(id) as Seller;
                if (seller != null)
                {
                    var form = new SellerForm(seller);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        seller = form.Seller; // TODO:
                        db.SaveChanges();
                        dataGridView.Update();
                    }

                }
            }

            // Customer.
            else if (typeof(T) == typeof(Customer))
            {
                var customer = set.Find(id) as Customer;
                if (customer != null)
                {
                    var form = new CustomerForm(customer);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        customer = form.Customer; // TODO:
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }
            }
        }
    }
}
