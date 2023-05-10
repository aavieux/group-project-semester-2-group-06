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
            label2 = new Label();
            numThreshold = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numThreshold).BeginInit();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(343, 38);
            tbName.Margin = new Padding(2, 4, 2, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(205, 47);
            tbName.TabIndex = 0;
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.Location = new Point(343, 147);
            tbDescription.Margin = new Padding(2, 4, 2, 4);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(205, 47);
            tbDescription.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 41);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 7;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(163, 147);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 41);
            label4.TabIndex = 8;
            label4.Text = "Description:";
            // 
            // cbProductCategory
            // 
            cbProductCategory.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "TV", "HiFi", "Computers", "Mobile", "Personal Care", "Home Care", "Kitchen Appliances", "Automotive" });
            cbProductCategory.Location = new Point(343, 93);
            cbProductCategory.Margin = new Padding(2, 4, 2, 4);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(205, 49);
            cbProductCategory.TabIndex = 9;
            // 
            // bAddProduct
            // 
            bAddProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bAddProduct.Location = new Point(251, 302);
            bAddProduct.Margin = new Padding(2, 4, 2, 4);
            bAddProduct.Name = "bAddProduct";
            bAddProduct.Size = new Size(238, 84);
            bAddProduct.TabIndex = 10;
            bAddProduct.Text = "Add product";
            bAddProduct.UseVisualStyleBackColor = true;
            bAddProduct.Click += bAddProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 203);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 12;
            label2.Text = "Threshold:";
            // 
            // numThreshold
            // 
            numThreshold.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numThreshold.Location = new Point(345, 208);
            numThreshold.Margin = new Padding(4);
            numThreshold.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numThreshold.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numThreshold.Name = "numThreshold";
            numThreshold.Size = new Size(203, 39);
            numThreshold.TabIndex = 13;
            numThreshold.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 529);
            Controls.Add(numThreshold);
            Controls.Add(label2);
            Controls.Add(bAddProduct);
            Controls.Add(cbProductCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbDescription);
            Controls.Add(tbName);
            Margin = new Padding(2, 4, 2, 4);
            Name = "AddProduct";
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)numThreshold).EndInit();
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
        private Label label2;
        private NumericUpDown numThreshold;
    }
}