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
            tbName = new TextBox();
            tbDescription = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbProductCategory = new ComboBox();
            bAddProduct = new Button();
            tbThreshold = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(171, 64);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(145, 34);
            tbName.TabIndex = 0;
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.Location = new Point(171, 177);
            tbDescription.Margin = new Padding(2);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(145, 34);
            tbDescription.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 122);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 7;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 8;
            label4.Text = "Description:";
            // 
            // cbProductCategory
            // 
            cbProductCategory.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "TV", "HiFi", "Computers", "Mobile", "Personal Care", "Home Care", "Kitchen Appliances", "Automotive" });
            cbProductCategory.Location = new Point(171, 122);
            cbProductCategory.Margin = new Padding(2);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(145, 36);
            cbProductCategory.TabIndex = 9;
            // 
            // bAddProduct
            // 
            bAddProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bAddProduct.Location = new Point(365, 63);
            bAddProduct.Margin = new Padding(2);
            bAddProduct.Name = "bAddProduct";
            bAddProduct.Size = new Size(144, 147);
            bAddProduct.TabIndex = 10;
            bAddProduct.Text = "Add product";
            bAddProduct.UseVisualStyleBackColor = true;
            bAddProduct.Click += bAddProduct_Click_1;
            // 
            // tbThreshold
            // 
            tbThreshold.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbThreshold.Location = new Point(171, 229);
            tbThreshold.Margin = new Padding(2);
            tbThreshold.Name = "tbThreshold";
            tbThreshold.Size = new Size(145, 34);
            tbThreshold.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 232);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 12;
            label2.Text = "Threshold:";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 317);
            Controls.Add(label2);
            Controls.Add(tbThreshold);
            Controls.Add(bAddProduct);
            Controls.Add(cbProductCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbDescription);
            Controls.Add(tbName);
            Margin = new Padding(2);
            Name = "AddProduct";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
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