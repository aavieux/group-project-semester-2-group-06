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
            this.bRefreshProducts = new System.Windows.Forms.Button();
            this.bProductStatistics = new System.Windows.Forms.Button();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.ColumnId = new System.Windows.Forms.ColumnHeader();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnAmount = new System.Windows.Forms.ColumnHeader();
            this.ColumnCategory = new System.Windows.Forms.ColumnHeader();
            this.bChangeStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddProduct
            // 
            this.bAddProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.bRemoveProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.bViewDetailsProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bViewDetailsProduct.Location = new System.Drawing.Point(936, 9);
            this.bViewDetailsProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bViewDetailsProduct.Name = "bViewDetailsProduct";
            this.bViewDetailsProduct.Size = new System.Drawing.Size(239, 121);
            this.bViewDetailsProduct.TabIndex = 3;
            this.bViewDetailsProduct.Text = "View details";
            this.bViewDetailsProduct.UseVisualStyleBackColor = true;
            this.bViewDetailsProduct.Click += new System.EventHandler(this.bViewDetailsProduct_Click);
            // 
            // bRefreshProducts
            // 
            this.bRefreshProducts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.bProductStatistics.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvProducts.Location = new System.Drawing.Point(-1, 9);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(932, 857);
            this.lvProducts.TabIndex = 7;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // ColumnId
            // 
            this.ColumnId.Text = "ID";
            this.ColumnId.Width = 204;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 204;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.Text = "Amount";
            this.ColumnAmount.Width = 204;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.Text = "Category";
            this.ColumnCategory.Width = 204;
            // 
            // bChangeStock
            // 
            this.bChangeStock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bChangeStock.Location = new System.Drawing.Point(937, 427);
            this.bChangeStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bChangeStock.Name = "bChangeStock";
            this.bChangeStock.Size = new System.Drawing.Size(239, 119);
            this.bChangeStock.TabIndex = 8;
            this.bChangeStock.Text = "Change stock";
            this.bChangeStock.UseVisualStyleBackColor = true;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 867);
            this.Controls.Add(this.bChangeStock);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.bProductStatistics);
            this.Controls.Add(this.bRefreshProducts);
            this.Controls.Add(this.bViewDetailsProduct);
            this.Controls.Add(this.bRemoveProduct);
            this.Controls.Add(this.bAddProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManagementForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

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