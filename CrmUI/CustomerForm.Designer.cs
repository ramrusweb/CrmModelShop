namespace CrmUI
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.custAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 1;
            // 
            // custAddBtn
            // 
            this.custAddBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.custAddBtn.Location = new System.Drawing.Point(264, 258);
            this.custAddBtn.Name = "custAddBtn";
            this.custAddBtn.Size = new System.Drawing.Size(84, 23);
            this.custAddBtn.TabIndex = 2;
            this.custAddBtn.Text = "Добавить";
            this.custAddBtn.UseVisualStyleBackColor = true;
            this.custAddBtn.Click += new System.EventHandler(this.custAddBtn_Click);
            // 
            // CustomerForm
            // 
            this.AcceptButton = this.custAddBtn;
            this.ClientSize = new System.Drawing.Size(360, 293);
            this.Controls.Add(this.custAddBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "Добавить покупателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button custAddBtn;
    }
}