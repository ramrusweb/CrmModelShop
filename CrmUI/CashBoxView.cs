using CrmBl.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrmUI
{
    public class CashBoxView
    {
        CashDesk cashDesk;

        public Label CashDeskName { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLength { get; set; }
        public Label LeaveCustomersCount { get; set; }

        public CashBoxView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;

            CashDeskName = new Label();
            Price = new NumericUpDown();
            QueueLength = new ProgressBar();
            LeaveCustomersCount = new Label();

            CashDeskName.AutoSize = true;
            CashDeskName.Location = new Point(x, y);
            CashDeskName.Name = "label" + number;
            CashDeskName.Size = new Size(35, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();

            Price.Location = new Point(x + 70, y);
            Price.Name = "numericUpDown" + number;
            Price.Size = new Size(120, 20);
            Price.TabIndex = number;
            Price.Maximum = 1000000000000000;

            QueueLength.Location = new Point(x + 250, y);
            QueueLength.Maximum = cashDesk.MaxQueueLength;
            QueueLength.Name = "progressBar" + number;
            QueueLength.Size = new Size(200, 23);
            QueueLength.TabIndex = number;
            QueueLength.Value = 0;

            LeaveCustomersCount.AutoSize = true;
            LeaveCustomersCount.Location = new Point(x + 400, y);
            LeaveCustomersCount.Name = "label2" + number;
            LeaveCustomersCount.Size = new Size(35, 13);
            LeaveCustomersCount.TabIndex = number;
            LeaveCustomersCount.Text = "";

            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        void CashDesk_CheckClosed(object sender, Check e) // TODO:
        {
            // Пробрасывание действия из ассинхроного потока в основной.
            Price.Invoke((Action)delegate
            {
                if(Price.IsDisposed)
                {
                    return;
                }
                Price.Value += e.Price;
                QueueLength.Value = cashDesk.Count;
                LeaveCustomersCount.Text = cashDesk.ExitCustomer.ToString();
            });
        }
    }
}
