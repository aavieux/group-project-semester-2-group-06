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
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(276, 75);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 27);
            this.tbName.TabIndex = 0;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(276, 138);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(165, 27);
            this.tbDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // cbProductCategory
            // 
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
            this.cbProductCategory.Location = new System.Drawing.Point(276, 107);
            this.cbProductCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(165, 28);
            this.cbProductCategory.TabIndex = 9;
            // 
            // bAddProduct
            // 
            this.bAddProduct.Location = new System.Drawing.Point(276, 178);
            this.bAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(164, 66);
            this.bAddProduct.TabIndex = 10;
            this.bAddProduct.Text = "Add product";
            this.bAddProduct.UseVisualStyleBackColor = true;
            this.bAddProduct.Click += new System.EventHandler(this.bAddProduct_Click_1);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.bAddProduct);
            this.Controls.Add(this.cbProductCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}