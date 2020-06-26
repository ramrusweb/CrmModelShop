using CrmBl.Model;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class CustomerForm : Form
    { 
        public Customer Customer { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            Customer = customer ?? new Customer();
            textBox1.Text = Customer.Name;
        }

        void custAddBtn_Click(object sender, EventArgs e)
        {
            Customer = Customer ?? new Customer();
            Customer.Name = textBox1.Text;
            Close();
        }
    }
}
