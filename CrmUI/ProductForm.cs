using System;
using CrmBl.Model;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            Product = product ?? new Product();
            nameProductTxtBx.Text = Product.Name;
            numericUpDownCost.Value = Product.Price;
            numericUpDownQuantity.Value = Product.Count;
        }

        void OKBtn_Click(object sender, EventArgs e)
        {
            Product = Product ?? new Product();
            Product.Name = nameProductTxtBx.Text;
            Product.Price = numericUpDownCost.Value;
            Product.Count = Convert.ToInt32(numericUpDownQuantity.Value);

            Close();
        }
    }
}
