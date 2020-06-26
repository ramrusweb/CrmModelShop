namespace CrmUI
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sellAddBtn = new System.Windows.Forms.Button();
            this.sellerNameTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sellAddBtn
            // 
            this.sellAddBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sellAddBtn.Location = new System.Drawing.Point(262, 257);
            this.sellAddBtn.Name = "sellAddBtn";
            this.sellAddBtn.Size = new System.Drawing.Size(84, 23);
            this.sellAddBtn.TabIndex = 5;
            this.sellAddBtn.Text = "Добавить";
            this.sellAddBtn.UseVisualStyleBackColor = true;
            this.sellAddBtn.Click += new System.EventHandler(this.sellAddBtn_Click);
            // 
            // sellerNameTxtBx
            // 
            this.sellerNameTxtBx.Location = new System.Drawing.Point(113, 12);
            this.sellerNameTxtBx.Name = "sellerNameTxtBx";
            this.sellerNameTxtBx.Size = new System.Drawing.Size(233, 22);
            this.sellerNameTxtBx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите имя:";
            // 
            // SellerForm
            // 
            this.AcceptButton = this.sellAddBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 297);
            this.Controls.Add(this.sellAddBtn);
            this.Controls.Add(this.sellerNameTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "SellerForm";
            this.Text = "Добавить продавца";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sellAddBtn;
        private System.Windows.Forms.TextBox sellerNameTxtBx;
        private System.Windows.Forms.Label label1;
    }
}