namespace Project_Media_Bazaar
{
    partial class AddProduct
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProductCategory = new System.Windows.Forms.ComboBox();
            this.bAddProduct = new System.Windows.Forms.Button();
            this.tbThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(195, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 41);
            this.tbName.TabIndex = 0;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(195, 236);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(165, 41);
            this.tbDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // cbProductCategory
            // 
            this.cbProductCategory.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProductCategory.FormattingEnabled = true;
            this.cbProductCategory.Items.AddRange(new object[] {
            "TV",
            "HiFi",
            "Computers",
            "Mobile",
            "Personal Care",
            "Home Care",
            "Kitchen Appliances",
            "Automotive"});
            this.cbProductCategory.Location = new System.Drawing.Point(195, 163);
            this.cbProductCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(165, 43);
            this.cbProductCategory.TabIndex = 9;
            // 
            // bAddProduct
            // 
            this.bAddProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddProduct.Location = new System.Drawing.Point(417, 84);
            this.bAddProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(165, 196);
            this.bAddProduct.TabIndex = 10;
            this.bAddProduct.Text = "Add product";
            this.bAddProduct.UseVisualStyleBackColor = true;
            this.bAddProduct.Click += new System.EventHandler(this.bAddProduct_Click);
            // 
            // tbThreshold
            // 
            this.tbThreshold.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbThreshold.Location = new System.Drawing.Point(195, 305);
            this.tbThreshold.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(165, 41);
            this.tbThreshold.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Threshold:";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbThreshold);
            this.Controls.Add(this.bAddProduct);
            this.Controls.Add(this.cbProductCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbName;
        private TextBox tbDescription;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox cbProductCategory;
        private Button bAddProduct;
        private TextBox tbThreshold;
        private Label label2;
    }
}