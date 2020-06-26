namespace CrmUI
{
    partial class ProductForm
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
            this.OKBtn = new System.Windows.Forms.Button();
            this.nameProductTxtBx = new System.Windows.Forms.TextBox();
            this.addNameProdLb = new System.Windows.Forms.Label();
            this.addPriceProdLb = new System.Windows.Forms.Label();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(395, 262);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(84, 23);
            this.OKBtn.TabIndex = 5;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // nameProductTxtBx
            // 
            this.nameProductTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameProductTxtBx.Location = new System.Drawing.Point(179, 12);
            this.nameProductTxtBx.Name = "nameProductTxtBx";
            this.nameProductTxtBx.Size = new System.Drawing.Size(300, 22);
            this.nameProductTxtBx.TabIndex = 4;
            // 
            // addNameProdLb
            // 
            this.addNameProdLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNameProdLb.AutoSize = true;
            this.addNameProdLb.Location = new System.Drawing.Point(11, 12);
            this.addNameProdLb.Name = "addNameProdLb";
            this.addNameProdLb.Size = new System.Drawing.Size(167, 17);
            this.addNameProdLb.TabIndex = 3;
            this.addNameProdLb.Text = "Введите наименование:";
            // 
            // addPriceProdLb
            // 
            this.addPriceProdLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPriceProdLb.AutoSize = true;
            this.addPriceProdLb.Location = new System.Drawing.Point(12, 58);
            this.addPriceProdLb.Name = "addPriceProdLb";
            this.addPriceProdLb.Size = new System.Drawing.Size(139, 17);
            this.addPriceProdLb.TabIndex = 6;
            this.addPriceProdLb.Text = "Введите стоимость:";
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCost.DecimalPlaces = 2;
            this.numericUpDownCost.Location = new System.Drawing.Point(179, 52);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(167, 22);
            this.numericUpDownCost.TabIndex = 7;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(177, 97);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(167, 22);
            this.numericUpDownQuantity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите количество:";
            // 
            // ProductForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 297);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.addPriceProdLb);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.nameProductTxtBx);
            this.Controls.Add(this.addNameProdLb);
            this.Name = "ProductForm";
            this.Text = "Добавить продукт";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox nameProductTxtBx;
        private System.Windows.Forms.Label addNameProdLb;
        private System.Windows.Forms.Label addPriceProdLb;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label1;
    }
}