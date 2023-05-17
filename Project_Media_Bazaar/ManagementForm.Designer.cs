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
            StockItemIndicator = new ColumnHeader();
            bChangeStock = new Button();
            tbF = new TextBox();
            search_lbl = new Label();
            cbCategories = new ComboBox();
            button1 = new Button();
            btnTasks = new Button();
            bLogout = new Button();
            bShowAllAgain = new Button();
            btnEmployeeShiftsView = new Button();
            SuspendLayout();
            // 
            // bAddProduct
            // 
            bAddProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bAddProduct.Location = new Point(1190, 185);
            bAddProduct.Margin = new Padding(1, 4, 1, 4);
            bAddProduct.Name = "bAddProduct";
            bAddProduct.Size = new Size(299, 155);
            bAddProduct.TabIndex = 1;
            bAddProduct.Text = "Add product";
            bAddProduct.UseVisualStyleBackColor = true;
            bAddProduct.Click += bAddProduct_Click_2;
            // 
            // bRemoveProduct
            // 
            bRemoveProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bRemoveProduct.Location = new Point(1189, 360);
            bRemoveProduct.Margin = new Padding(1, 4, 1, 4);
            bRemoveProduct.Name = "bRemoveProduct";
            bRemoveProduct.Size = new Size(299, 149);
            bRemoveProduct.TabIndex = 2;
            bRemoveProduct.Text = "Remove product";
            bRemoveProduct.UseVisualStyleBackColor = true;
            bRemoveProduct.Click += bRemoveProduct_Click_2;
            // 
            // bViewDetailsProduct
            // 
            bViewDetailsProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bViewDetailsProduct.Location = new Point(1189, 10);
            bViewDetailsProduct.Margin = new Padding(1, 4, 1, 4);
            bViewDetailsProduct.Name = "bViewDetailsProduct";
            bViewDetailsProduct.Size = new Size(299, 151);
            bViewDetailsProduct.TabIndex = 3;
            bViewDetailsProduct.Text = "View details";
            bViewDetailsProduct.UseVisualStyleBackColor = true;
            bViewDetailsProduct.Click += bViewDetailsProduct_Click_2;
            // 
            // bRefreshProducts
            // 
            bRefreshProducts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bRefreshProducts.Location = new Point(1190, 714);
            bRefreshProducts.Margin = new Padding(1, 4, 1, 4);
            bRefreshProducts.Name = "bRefreshProducts";
            bRefreshProducts.Size = new Size(299, 151);
            bRefreshProducts.TabIndex = 5;
            bRefreshProducts.Text = "Refresh";
            bRefreshProducts.UseVisualStyleBackColor = true;
            bRefreshProducts.Click += bRefreshProducts_Click_2;
            // 
            // bProductStatistics
            // 
            bProductStatistics.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bProductStatistics.Location = new Point(1190, 896);
            bProductStatistics.Margin = new Padding(1, 4, 1, 4);
            bProductStatistics.Name = "bProductStatistics";
            bProductStatistics.Size = new Size(299, 151);
            bProductStatistics.TabIndex = 6;
            bProductStatistics.Text = "Open statistics";
            bProductStatistics.UseVisualStyleBackColor = true;
            bProductStatistics.Click += bProductStatistics_Click;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { ColumnId, ColumnName, ColumnAmount, ColumnCategory, StockItemIndicator });
            lvProducts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lvProducts.Location = new Point(16, 161);
            lvProducts.Margin = new Padding(1, 4, 1, 4);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(1148, 879);
            lvProducts.TabIndex = 7;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // ColumnId
            // 
            ColumnId.Text = "ID";
            ColumnId.Width = 160;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 160;
            // 
            // ColumnAmount
            // 
            ColumnAmount.Text = "Amount";
            ColumnAmount.Width = 160;
            // 
            // ColumnCategory
            // 
            ColumnCategory.Text = "Category";
            ColumnCategory.Width = 160;
            // 
            // StockItemIndicator
            // 
            StockItemIndicator.Text = "StockItemIndicator";
            StockItemIndicator.TextAlign = HorizontalAlignment.Center;
            StockItemIndicator.Width = 160;
            // 
            // bChangeStock
            // 
            bChangeStock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bChangeStock.Location = new Point(1190, 531);
            bChangeStock.Margin = new Padding(1, 4, 1, 4);
            bChangeStock.Name = "bChangeStock";
            bChangeStock.Size = new Size(299, 149);
            bChangeStock.TabIndex = 8;
            bChangeStock.Text = "Change stock";
            bChangeStock.UseVisualStyleBackColor = true;
            bChangeStock.Click += bChangeStock_Click_2;
            // 
            // tbF
            // 
            tbF.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbF.Location = new Point(180, 99);
            tbF.Margin = new Padding(4);
            tbF.Name = "tbF";
            tbF.Size = new Size(740, 47);
            tbF.TabIndex = 9;
            tbF.TextChanged += tbF_TextChanged;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            search_lbl.Location = new Point(332, 41);
            search_lbl.Margin = new Padding(4, 0, 4, 0);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(364, 41);
            search_lbl.TabIndex = 10;
            search_lbl.Text = "Search Product By Name";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(930, 11);
            cbCategories.Margin = new Padding(4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(234, 33);
            cbCategories.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(930, 51);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(236, 40);
            button1.TabIndex = 12;
            button1.Text = "Filter by category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnTasks
            // 
            btnTasks.Location = new Point(930, 99);
            btnTasks.Margin = new Padding(4);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(236, 56);
            btnTasks.TabIndex = 13;
            btnTasks.Text = "Manage employee tasks";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // bLogout
            // 
            bLogout.Location = new Point(14, 99);
            bLogout.Margin = new Padding(2, 4, 2, 4);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(159, 54);
            bLogout.TabIndex = 14;
            bLogout.Text = "Log out";
            bLogout.UseVisualStyleBackColor = true;
            bLogout.Click += bLogout_Click;
            // 
            // bShowAllAgain
            // 
            bShowAllAgain.Location = new Point(811, 11);
            bShowAllAgain.Margin = new Padding(2, 4, 2, 4);
            bShowAllAgain.Name = "bShowAllAgain";
            bShowAllAgain.Size = new Size(111, 80);
            bShowAllAgain.TabIndex = 15;
            bShowAllAgain.Text = "Show all";
            bShowAllAgain.UseVisualStyleBackColor = true;
            bShowAllAgain.Click += bShowAllAgain_Click;
            // 
            // btnEmployeeShiftsView
            // 
            btnEmployeeShiftsView.Location = new Point(15, 10);
            btnEmployeeShiftsView.Margin = new Padding(4);
            btnEmployeeShiftsView.Name = "btnEmployeeShiftsView";
            btnEmployeeShiftsView.Size = new Size(158, 75);
            btnEmployeeShiftsView.TabIndex = 16;
            btnEmployeeShiftsView.Text = "View employee shifts";
            btnEmployeeShiftsView.UseVisualStyleBackColor = true;
            btnEmployeeShiftsView.Click += btnEmployeeShiftsView_Click;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 1061);
            Controls.Add(btnEmployeeShiftsView);
            Controls.Add(bShowAllAgain);
            Controls.Add(bLogout);
            Controls.Add(btnTasks);
            Controls.Add(button1);
            Controls.Add(cbCategories);
            Controls.Add(search_lbl);
            Controls.Add(tbF);
            Controls.Add(bChangeStock);
            Controls.Add(lvProducts);
            Controls.Add(bProductStatistics);
            Controls.Add(bRefreshProducts);
            Controls.Add(bViewDetailsProduct);
            Controls.Add(bRemoveProduct);
            Controls.Add(bAddProduct);
            Margin = new Padding(1, 4, 1, 4);
            Name = "ManagementForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox tbF;
        private Label search_lbl;
        private ComboBox cbCategories;
        private Button button1;
        private Button btnTasks;
        private Button bLogout;
        private Button bShowAllAgain;
        private ColumnHeader StockItemIndicator;
        private Button btnEmployeeShiftsView;
    }
}