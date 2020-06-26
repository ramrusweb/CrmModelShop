using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new ShopComputerModel();
        public ModelForm()
        {
            InitializeComponent();
        }

        void startModel_Click(object sender, EventArgs e)
        {
            var cashBoxes = new List<CashBoxView>();

            for(int i = 0; i < model.CashDesks.Count; i++)
            {
                var box = new CashBoxView(model.CashDesks[i], i, 10, 26 * i);
                cashBoxes.Add(box);
                Controls.Add(box.CashDeskName);
                Controls.Add(box.Price);
                Controls.Add(box.QueueLength);
                Controls.Add(box.LeaveCustomersCount);
            }

            model.Start();
        }

        void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        void ModelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            model.Stop();
        }

        void ModelForm_Load(object sender, EventArgs e)
        {
            numericUpDownCustomerSpeed.Value = model.CustomerSpeed;
            numericUpDownCashDeskSpeed.Value = model.CashDeskSpeed;
        }

        void numericUpDownCustomerSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CustomerSpeed = (int)numericUpDownCustomerSpeed.Value;
        }

        void numericUpDownCashDeskSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)numericUpDownCashDeskSpeed.Value;
        }
    }
}
