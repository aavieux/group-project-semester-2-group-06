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
            lbProducts = new ListBox();
            bAddProduct = new Button();
            bRemoveProduct = new Button();
            bIncreaseStock = new Button();
            bReduceStock = new Button();
            bRefreshProducts = new Button();
            bProductStatistics = new Button();
            SuspendLayout();
            // 
            // lbProducts
            // 
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 15;
            lbProducts.Location = new Point(8, 7);
            lbProducts.Margin = new Padding(2);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(808, 634);
            lbProducts.TabIndex = 0;
            // 
            // bAddProduct
            // 
            bAddProduct.Location = new Point(820, 7);
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
            bRemoveProduct.Location = new Point(820, 113);
            bRemoveProduct.Margin = new Padding(2);
            bRemoveProduct.Name = "bRemoveProduct";
            bRemoveProduct.Size = new Size(209, 89);
            bRemoveProduct.TabIndex = 2;
            bRemoveProduct.Text = "Remove product";
            bRemoveProduct.UseVisualStyleBackColor = true;
            bRemoveProduct.Click += bRemoveProduct_Click;
            // 
            // bIncreaseStock
            // 
            bIncreaseStock.Location = new Point(820, 217);
            bIncreaseStock.Margin = new Padding(2);
            bIncreaseStock.Name = "bIncreaseStock";
            bIncreaseStock.Size = new Size(209, 91);
            bIncreaseStock.TabIndex = 3;
            bIncreaseStock.Text = "Increase stock";
            bIncreaseStock.UseVisualStyleBackColor = true;
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
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 650);
            Controls.Add(bProductStatistics);
            Controls.Add(bRefreshProducts);
            Controls.Add(bReduceStock);
            Controls.Add(bIncreaseStock);
            Controls.Add(bRemoveProduct);
            Controls.Add(bAddProduct);
            Controls.Add(lbProducts);
            Margin = new Padding(2);
            Name = "ManagementForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbProducts;
        private Button bAddProduct;
        private Button bRemoveProduct;
        private Button bIncreaseStock;
        private Button bReduceStock;
        private Button bRefreshProducts;
        private Button bProductStatistics;
    }
}