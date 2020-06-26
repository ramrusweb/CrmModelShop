namespace CrmUI
{
    partial class Catalog<T>
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.catAddBtn = new System.Windows.Forms.Button();
            this.catChangeBtn = new System.Windows.Forms.Button();
            this.catDelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(776, 381);
            this.dataGridView.TabIndex = 0;
            // 
            // catAddBtn
            // 
            this.catAddBtn.Location = new System.Drawing.Point(101, 407);
            this.catAddBtn.Name = "catAddBtn";
            this.catAddBtn.Size = new System.Drawing.Size(100, 31);
            this.catAddBtn.TabIndex = 1;
            this.catAddBtn.Text = "Добавить";
            this.catAddBtn.UseVisualStyleBackColor = true;
            this.catAddBtn.Click += new System.EventHandler(this.catAddBtn_Click);
            // 
            // catChangeBtn
            // 
            this.catChangeBtn.Location = new System.Drawing.Point(340, 407);
            this.catChangeBtn.Name = "catChangeBtn";
            this.catChangeBtn.Size = new System.Drawing.Size(100, 31);
            this.catChangeBtn.TabIndex = 2;
            this.catChangeBtn.Text = "Изменить";
            this.catChangeBtn.UseVisualStyleBackColor = true;
            this.catChangeBtn.Click += new System.EventHandler(this.catChangeBtn_Click);
            // 
            // catDelBtn
            // 
            this.catDelBtn.Location = new System.Drawing.Point(580, 407);
            this.catDelBtn.Name = "catDelBtn";
            this.catDelBtn.Size = new System.Drawing.Size(100, 31);
            this.catDelBtn.TabIndex = 3;
            this.catDelBtn.Text = "Удалить";
            this.catDelBtn.UseVisualStyleBackColor = true;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catDelBtn);
            this.Controls.Add(this.catChangeBtn);
            this.Controls.Add(this.catAddBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "Catalog";
            this.Text = "Каталог";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button catAddBtn;
        private System.Windows.Forms.Button catChangeBtn;
        private System.Windows.Forms.Button catDelBtn;
    }
}