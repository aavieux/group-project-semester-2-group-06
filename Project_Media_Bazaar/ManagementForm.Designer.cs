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
            this.bAddProduct = new System.Windows.Forms.Button();
            this.bRemoveProduct = new System.Windows.Forms.Button();
            this.bViewDetailsProduct = new System.Windows.Forms.Button();
            this.bChangeStock = new System.Windows.Forms.Button();
            this.bRefreshProducts = new System.Windows.Forms.Button();
            this.bProductStatistics = new System.Windows.Forms.Button();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.ColumnId = new System.Windows.Forms.ColumnHeader();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnAmount = new System.Windows.Forms.ColumnHeader();
            this.ColumnCategory = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // bAddProduct
            // 
            this.bAddProduct.Location = new System.Drawing.Point(937, 149);
            this.bAddProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(239, 124);
            this.bAddProduct.TabIndex = 1;
            this.bAddProduct.Text = "Add product";
            this.bAddProduct.UseVisualStyleBackColor = true;
            // 
            // bRemoveProduct
            // 
            this.bRemoveProduct.Location = new System.Drawing.Point(936, 289);
            this.bRemoveProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bRemoveProduct.Name = "bRemoveProduct";
            this.bRemoveProduct.Size = new System.Drawing.Size(239, 119);
            this.bRemoveProduct.TabIndex = 2;
            this.bRemoveProduct.Text = "Remove product";
            this.bRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // bViewDetailsProduct
            // 
            this.bViewDetailsProduct.Location = new System.Drawing.Point(936, 9);
            this.bViewDetailsProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bViewDetailsProduct.Name = "bViewDetailsProduct";
            this.bViewDetailsProduct.Size = new System.Drawing.Size(239, 121);
            this.bViewDetailsProduct.TabIndex = 3;
            this.bViewDetailsProduct.Text = "View details";
            this.bViewDetailsProduct.UseVisualStyleBackColor = true;
            // 
            // bChangeStock
            // 
            this.bChangeStock.Location = new System.Drawing.Point(937, 431);
            this.bChangeStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bChangeStock.Name = "bChangeStock";
            this.bChangeStock.Size = new System.Drawing.Size(239, 121);
            this.bChangeStock.TabIndex = 4;
            this.bChangeStock.Text = "Change stock";
            this.bChangeStock.UseVisualStyleBackColor = true;
            this.bChangeStock.Click += new System.EventHandler(this.bChangeStock_Click);
            // 
            // bRefreshProducts
            // 
            this.bRefreshProducts.Location = new System.Drawing.Point(937, 572);
            this.bRefreshProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bRefreshProducts.Name = "bRefreshProducts";
            this.bRefreshProducts.Size = new System.Drawing.Size(239, 121);
            this.bRefreshProducts.TabIndex = 5;
            this.bRefreshProducts.Text = "Refresh";
            this.bRefreshProducts.UseVisualStyleBackColor = true;
            // 
            // bProductStatistics
            // 
            this.bProductStatistics.Location = new System.Drawing.Point(937, 719);
            this.bProductStatistics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bProductStatistics.Name = "bProductStatistics";
            this.bProductStatistics.Size = new System.Drawing.Size(239, 121);
            this.bProductStatistics.TabIndex = 6;
            this.bProductStatistics.Text = "Open statistics";
            this.bProductStatistics.UseVisualStyleBackColor = true;
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnAmount,
            this.ColumnCategory});
            this.lvProducts.Location = new System.Drawing.Point(-1, 9);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(933, 857);
            this.lvProducts.TabIndex = 7;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // ColumnId
            // 
            this.ColumnId.Text = "ID";
            this.ColumnId.Width = 50;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 200;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.Text = "Amount";
            this.ColumnAmount.Width = 150;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.Text = "Category";
            this.ColumnCategory.Width = 150;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 867);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.bProductStatistics);
            this.Controls.Add(this.bRefreshProducts);
            this.Controls.Add(this.bChangeStock);
            this.Controls.Add(this.bViewDetailsProduct);
            this.Controls.Add(this.bRemoveProduct);
            this.Controls.Add(this.bAddProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManagementForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
        private Button bChangeStock;

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