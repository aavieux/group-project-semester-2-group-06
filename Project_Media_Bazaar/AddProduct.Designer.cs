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
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(345, 94);
            tbName.Name = "tbName";
            tbName.Size = new Size(205, 31);
            tbName.TabIndex = 0;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(345, 173);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(205, 31);
            tbDescription.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 97);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 134);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 7;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 172);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 8;
            label4.Text = "Description:";
            // 
            // cbProductCategory
            // 
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "TV", "HiFi", "Computers", "Mobile", "Personal Care", "Home Care", "Kitchen Appliances", "Automotive" });
            cbProductCategory.Location = new Point(345, 134);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(205, 33);
            cbProductCategory.TabIndex = 9;
            // 
            // bAddProduct
            // 
            bAddProduct.Location = new Point(345, 223);
            bAddProduct.Name = "bAddProduct";
            bAddProduct.Size = new Size(205, 83);
            bAddProduct.TabIndex = 10;
            bAddProduct.Text = "Add product";
            bAddProduct.UseVisualStyleBackColor = true;
            bAddProduct.Click += bAddProduct_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bAddProduct);
            Controls.Add(cbProductCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbDescription);
            Controls.Add(tbName);
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
    }
}