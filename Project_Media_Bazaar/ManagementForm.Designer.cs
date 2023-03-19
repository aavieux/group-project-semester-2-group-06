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
            bReduceStock = new Button();
            bRefreshProducts = new Button();
            bProductStatistics = new Button();
            lvProducts = new ListView();
            ColumnId = new ColumnHeader();
            ColumnName = new ColumnHeader();
            ColumnAmount = new ColumnHeader();
            ColumnCategory = new ColumnHeader();
            SuspendLayout();
            // 
            // bAddProduct
            // 
            bAddProduct.Location = new Point(820, 112);
            bAddProduct.Margin = new Padding(2);
            bAddProduct.Name = "bAddProduct";
            bAddProduct.Size = new Size(209, 93);
            bAddProduct.TabIndex = 1;
            bAddProduct.Text = "Add product";
            bAddProduct.UseVisualStyleBackColor = true;
            bAddProduct.Click += bAddProduct_Click;
            // 
            // bRemoveProduct
            // 
            bRemoveProduct.Location = new Point(819, 217);
            bRemoveProduct.Margin = new Padding(2);
            bRemoveProduct.Name = "bRemoveProduct";
            bRemoveProduct.Size = new Size(209, 89);
            bRemoveProduct.TabIndex = 2;
            bRemoveProduct.Text = "Remove product";
            bRemoveProduct.UseVisualStyleBackColor = true;
            bRemoveProduct.Click += bRemoveProduct_Click;
            // 
            // bViewDetailsProduct
            // 
            bViewDetailsProduct.Location = new Point(819, 7);
            bViewDetailsProduct.Margin = new Padding(2);
            bViewDetailsProduct.Name = "bViewDetailsProduct";
            bViewDetailsProduct.Size = new Size(209, 91);
            bViewDetailsProduct.TabIndex = 3;
            bViewDetailsProduct.Text = "View details";
            bViewDetailsProduct.UseVisualStyleBackColor = true;
            bViewDetailsProduct.Click += bViewDetailsProduct_Click;
            // 
            // bReduceStock
            // 
            bReduceStock.Location = new Point(820, 323);
            bReduceStock.Margin = new Padding(2);
            bReduceStock.Name = "bReduceStock";
            bReduceStock.Size = new Size(209, 91);
            bReduceStock.TabIndex = 4;
            bReduceStock.Text = "Reduce stock";
            bReduceStock.UseVisualStyleBackColor = true;
            // 
            // bRefreshProducts
            // 
            bRefreshProducts.Location = new Point(820, 429);
            bRefreshProducts.Margin = new Padding(2);
            bRefreshProducts.Name = "bRefreshProducts";
            bRefreshProducts.Size = new Size(209, 91);
            bRefreshProducts.TabIndex = 5;
            bRefreshProducts.Text = "Refresh";
            bRefreshProducts.UseVisualStyleBackColor = true;
            bRefreshProducts.Click += bRefreshProducts_Click;
            // 
            // bProductStatistics
            // 
            bProductStatistics.Location = new Point(820, 539);
            bProductStatistics.Margin = new Padding(2);
            bProductStatistics.Name = "bProductStatistics";
            bProductStatistics.Size = new Size(209, 91);
            bProductStatistics.TabIndex = 6;
            bProductStatistics.Text = "Open statistics";
            bProductStatistics.UseVisualStyleBackColor = true;
            bProductStatistics.Click += bProductStatistics_Click;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { ColumnId, ColumnName, ColumnAmount, ColumnCategory });
            lvProducts.Location = new Point(-1, 7);
            lvProducts.Margin = new Padding(2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(817, 644);
            lvProducts.TabIndex = 7;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // ColumnId
            // 
            ColumnId.Text = "ID";
            ColumnId.Width = 50;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 200;
            // 
            // ColumnAmount
            // 
            ColumnAmount.Text = "Amount";
            ColumnAmount.Width = 150;
            // 
            // ColumnCategory
            // 
            ColumnCategory.Text = "Category";
            ColumnCategory.Width = 150;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 650);
            Controls.Add(lvProducts);
            Controls.Add(bProductStatistics);
            Controls.Add(bRefreshProducts);
            Controls.Add(bReduceStock);
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
        private Button bReduceStock;
        private Button bRefreshProducts;
        private Button bProductStatistics;
        private ListView lvProducts;
        private ColumnHeader ColumnId;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnAmount;
        private ColumnHeader ColumnCategory;
    }
}