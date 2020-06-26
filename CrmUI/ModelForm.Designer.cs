namespace CrmUI
{
    partial class ModelForm
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
            this.startModel = new System.Windows.Forms.Button();
            this.numericUpDownCustomerSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCashDeskSpeed = new System.Windows.Forms.NumericUpDown();
            this.customerSpeedLb = new System.Windows.Forms.Label();
            this.cashDeskSpeedLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomerSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCashDeskSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // startModel
            // 
            this.startModel.Location = new System.Drawing.Point(644, 415);
            this.startModel.Name = "startModel";
            this.startModel.Size = new System.Drawing.Size(144, 23);
            this.startModel.TabIndex = 0;
            this.startModel.Text = "Запустить модель";
            this.startModel.UseVisualStyleBackColor = true;
            this.startModel.Click += new System.EventHandler(this.startModel_Click);
            // 
            // numericUpDownCustomerSpeed
            // 
            this.numericUpDownCustomerSpeed.Location = new System.Drawing.Point(668, 12);
            this.numericUpDownCustomerSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCustomerSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCustomerSpeed.Name = "numericUpDownCustomerSpeed";
            this.numericUpDownCustomerSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCustomerSpeed.TabIndex = 1;
            this.numericUpDownCustomerSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCustomerSpeed.ValueChanged += new System.EventHandler(this.numericUpDownCustomerSpeed_ValueChanged);
            // 
            // numericUpDownCashDeskSpeed
            // 
            this.numericUpDownCashDeskSpeed.Location = new System.Drawing.Point(668, 40);
            this.numericUpDownCashDeskSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.Name = "numericUpDownCashDeskSpeed";
            this.numericUpDownCashDeskSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCashDeskSpeed.TabIndex = 2;
            this.numericUpDownCashDeskSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCashDeskSpeed.ValueChanged += new System.EventHandler(this.numericUpDownCashDeskSpeed_ValueChanged);
            // 
            // customerSpeedLb
            // 
            this.customerSpeedLb.AutoSize = true;
            this.customerSpeedLb.Location = new System.Drawing.Point(536, 14);
            this.customerSpeedLb.Name = "customerSpeedLb";
            this.customerSpeedLb.Size = new System.Drawing.Size(126, 17);
            this.customerSpeedLb.TabIndex = 3;
            this.customerSpeedLb.Text = "Скорость клиетов";
            // 
            // cashDeskSpeedLb
            // 
            this.cashDeskSpeedLb.AutoSize = true;
            this.cashDeskSpeedLb.Location = new System.Drawing.Point(560, 42);
            this.cashDeskSpeedLb.Name = "cashDeskSpeedLb";
            this.cashDeskSpeedLb.Size = new System.Drawing.Size(102, 17);
            this.cashDeskSpeedLb.TabIndex = 4;
            this.cashDeskSpeedLb.Text = "Скорость касс";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashDeskSpeedLb);
            this.Controls.Add(this.customerSpeedLb);
            this.Controls.Add(this.numericUpDownCashDeskSpeed);
            this.Controls.Add(this.numericUpDownCustomerSpeed);
            this.Controls.Add(this.startModel);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelForm_FormClosed);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomerSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCashDeskSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startModel;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomerSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownCashDeskSpeed;
        private System.Windows.Forms.Label customerSpeedLb;
        private System.Windows.Forms.Label cashDeskSpeedLb;
    }
}