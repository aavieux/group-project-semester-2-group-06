namespace Project_Media_Bazaar
{
    partial class ManagementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bAddProduct = new Button();
            bRemoveProduct = new Button();
            bViewDetailsProduct = new Button();
            bRefreshProducts = new Button();
            bProductStatistics = new Button();
            lvProducts = new ListView();
            ColumnId = new ColumnHeader();
            ColumnName = new ColumnHeader();
            ColumnAmount = new ColumnHeader();
            ColumnCategory = new ColumnHeader();
            bChangeStock = new Button();
            SuspendLayout();
            // 
            // bAddProduct
            // 
            bAddProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bAddProduct.Location = new Point(820, 112);
            bAddProduct.Margin = new Padding(2);
            bAddProduct.Name = "bAddProduct";
            bAddProduct.Size = new Size(209, 93);
            bAddProduct.TabIndex = 1;
            bAddProduct.Text = "Add product";
            bAddProduct.UseVisualStyleBackColor = true;
            bAddProduct.Click += bAddProduct_Click_1;
            // 
            // bRemoveProduct
            // 
            bRemoveProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bRemoveProduct.Location = new Point(819, 217);
            bRemoveProduct.Margin = new Padding(2);
            bRemoveProduct.Name = "bRemoveProduct";
            bRemoveProduct.Size = new Size(209, 89);
            bRemoveProduct.TabIndex = 2;
            bRemoveProduct.Text = "Remove product";
            bRemoveProduct.UseVisualStyleBackColor = true;
            bRemoveProduct.Click += bRemoveProduct_Click_1;
            // 
            // bViewDetailsProduct
            // 
            bViewDetailsProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bViewDetailsProduct.Location = new Point(819, 7);
            bViewDetailsProduct.Margin = new Padding(2);
            bViewDetailsProduct.Name = "bViewDetailsProduct";
            bViewDetailsProduct.Size = new Size(209, 91);
            bViewDetailsProduct.TabIndex = 3;
            bViewDetailsProduct.Text = "View details";
            bViewDetailsProduct.UseVisualStyleBackColor = true;
            bViewDetailsProduct.Click += bViewDetailsProduct_Click_1;
            // 
            // bRefreshProducts
            // 
            bRefreshProducts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bRefreshProducts.Location = new Point(820, 429);
            bRefreshProducts.Margin = new Padding(2);
            bRefreshProducts.Name = "bRefreshProducts";
            bRefreshProducts.Size = new Size(209, 91);
            bRefreshProducts.TabIndex = 5;
            bRefreshProducts.Text = "Refresh";
            bRefreshProducts.UseVisualStyleBackColor = true;
            bRefreshProducts.Click += bRefreshProducts_Click_1;
            // 
            // bProductStatistics
            // 
            bProductStatistics.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bProductStatistics.Location = new Point(820, 539);
            bProductStatistics.Margin = new Padding(2);
            bProductStatistics.Name = "bProductStatistics";
            bProductStatistics.Size = new Size(209, 91);
            bProductStatistics.TabIndex = 6;
            bProductStatistics.Text = "Open statistics";
            bProductStatistics.UseVisualStyleBackColor = true;
            bProductStatistics.Click += bProductStatistics_Click_1;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { ColumnId, ColumnName, ColumnAmount, ColumnCategory });
            lvProducts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lvProducts.Location = new Point(-1, 7);
            lvProducts.Margin = new Padding(2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(816, 644);
            lvProducts.TabIndex = 7;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // ColumnId
            // 
            ColumnId.Text = "ID";
            ColumnId.Width = 204;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 204;
            // 
            // ColumnAmount
            // 
            ColumnAmount.Text = "Amount";
            ColumnAmount.Width = 204;
            // 
            // ColumnCategory
            // 
            ColumnCategory.Text = "Category";
            ColumnCategory.Width = 204;
            // 
            // bChangeStock
            // 
            bChangeStock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bChangeStock.Location = new Point(820, 320);
            bChangeStock.Margin = new Padding(2);
            bChangeStock.Name = "bChangeStock";
            bChangeStock.Size = new Size(209, 89);
            bChangeStock.TabIndex = 8;
            bChangeStock.Text = "Change stock";
            bChangeStock.UseVisualStyleBackColor = true;
            bChangeStock.Click += bChangeStock_Click_1;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 650);
            Controls.Add(bChangeStock);
            Controls.Add(lvProducts);
            Controls.Add(bProductStatistics);
            Controls.Add(bRefreshProducts);
            Controls.Add(bViewDetailsProduct);
            Controls.Add(bRemoveProduct);
            Controls.Add(bAddProduct);
            Margin = new Padding(2);
            Name = "ManagementForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button bAddProduct;
        private Button bRemoveProduct;
        private Button bViewDetailsProduct;

        private Button bRefreshProducts;
        private Button bProductStatistics;
        private ListView lvProducts;
        private ColumnHeader ColumnId;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnAmount;
        private ColumnHeader ColumnCategory;
        private Button bChangeStock;
    }
}