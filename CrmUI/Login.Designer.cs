namespace CrmUI
{
    partial class Login
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
            this.whoIsLb = new System.Windows.Forms.Label();
            this.loginTxtBx = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // whoIsLb
            // 
            this.whoIsLb.AutoSize = true;
            this.whoIsLb.Location = new System.Drawing.Point(13, 13);
            this.whoIsLb.Name = "whoIsLb";
            this.whoIsLb.Size = new System.Drawing.Size(192, 17);
            this.whoIsLb.TabIndex = 0;
            this.whoIsLb.Text = "Представьтесь пожалуйста!";
            // 
            // loginTxtBx
            // 
            this.loginTxtBx.Location = new System.Drawing.Point(16, 48);
            this.loginTxtBx.Name = "loginTxtBx";
            this.loginTxtBx.Size = new System.Drawing.Size(407, 22);
            this.loginTxtBx.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(180, 134);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Войти";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 208);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginTxtBx);
            this.Controls.Add(this.whoIsLb);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whoIsLb;
        private System.Windows.Forms.TextBox loginTxtBx;
        private System.Windows.Forms.Button loginBtn;
    }
}