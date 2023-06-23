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
            this.StockItemIndicator = new System.Windows.Forms.ColumnHeader();
            this.bChangeStock = new System.Windows.Forms.Button();
            this.tbF = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.bLogout = new System.Windows.Forms.Button();
            this.bShowAllAgain = new System.Windows.Forms.Button();
            this.btnEmployeeShiftsView = new System.Windows.Forms.Button();
            this.btnAssignShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddProduct
            // 
            this.bAddProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddProduct.Location = new System.Drawing.Point(952, 148);
            this.bAddProduct.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(239, 124);
            this.bAddProduct.TabIndex = 1;
            this.bAddProduct.Text = "Add product";
            this.bAddProduct.UseVisualStyleBackColor = true;
            // 
            // bRemoveProduct
            // 
            this.bRemoveProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRemoveProduct.Location = new System.Drawing.Point(951, 288);
            this.bRemoveProduct.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bRemoveProduct.Name = "bRemoveProduct";
            this.bRemoveProduct.Size = new System.Drawing.Size(239, 119);
            this.bRemoveProduct.TabIndex = 2;
            this.bRemoveProduct.Text = "Remove product";
            this.bRemoveProduct.UseVisualStyleBackColor = true;
            this.bRemoveProduct.Click += new System.EventHandler(this.bRemoveProduct_Click_2);
            // 
            // bViewDetailsProduct
            // 
            this.bViewDetailsProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bViewDetailsProduct.Location = new System.Drawing.Point(951, 8);
            this.bViewDetailsProduct.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bViewDetailsProduct.Name = "bViewDetailsProduct";
            this.bViewDetailsProduct.Size = new System.Drawing.Size(239, 121);
            this.bViewDetailsProduct.TabIndex = 3;
            this.bViewDetailsProduct.Text = "View details";
            this.bViewDetailsProduct.UseVisualStyleBackColor = true;
            this.bViewDetailsProduct.Click += new System.EventHandler(this.bViewDetailsProduct_Click_2);
            // 
            // bRefreshProducts
            // 
            this.bRefreshProducts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRefreshProducts.Location = new System.Drawing.Point(952, 571);
            this.bRefreshProducts.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bRefreshProducts.Name = "bRefreshProducts";
            this.bRefreshProducts.Size = new System.Drawing.Size(239, 121);
            this.bRefreshProducts.TabIndex = 5;
            this.bRefreshProducts.Text = "Refresh";
            this.bRefreshProducts.UseVisualStyleBackColor = true;
            // 
            // bProductStatistics
            // 
            this.bProductStatistics.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bProductStatistics.Location = new System.Drawing.Point(952, 717);
            this.bProductStatistics.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
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
            this.ColumnCategory,
            this.StockItemIndicator});
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvProducts.Location = new System.Drawing.Point(13, 129);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(919, 704);
            this.lvProducts.TabIndex = 7;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // ColumnId
            // 
            this.ColumnId.Text = "ID";
            this.ColumnId.Width = 160;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 160;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.Text = "Amount";
            this.ColumnAmount.Width = 160;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.Text = "Category";
            this.ColumnCategory.Width = 160;
            // 
            // StockItemIndicator
            // 
            this.StockItemIndicator.Text = "StockItemIndicator";
            this.StockItemIndicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StockItemIndicator.Width = 160;
            // 
            // bChangeStock
            // 
            this.bChangeStock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bChangeStock.Location = new System.Drawing.Point(952, 425);
            this.bChangeStock.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.bChangeStock.Name = "bChangeStock";
            this.bChangeStock.Size = new System.Drawing.Size(239, 119);
            this.bChangeStock.TabIndex = 8;
            this.bChangeStock.Text = "Change stock";
            this.bChangeStock.UseVisualStyleBackColor = true;
            // 
            // tbF
            // 
            this.tbF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbF.Location = new System.Drawing.Point(144, 79);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(593, 41);
            this.tbF.TabIndex = 9;
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_lbl.Location = new System.Drawing.Point(266, 33);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(305, 35);
            this.search_lbl.TabIndex = 10;
            this.search_lbl.Text = "Search Product By Name";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(744, 9);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(188, 28);
            this.cbCategories.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Filter by category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(744, 79);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(189, 45);
            this.btnTasks.TabIndex = 13;
            this.btnTasks.Text = "Manage employee tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // bLogout
            // 
            this.bLogout.Location = new System.Drawing.Point(11, 79);
            this.bLogout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(127, 43);
            this.bLogout.TabIndex = 14;
            this.bLogout.Text = "Log out";
            this.bLogout.UseVisualStyleBackColor = true;
            // 
            // bShowAllAgain
            // 
            this.bShowAllAgain.Location = new System.Drawing.Point(649, 9);
            this.bShowAllAgain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bShowAllAgain.Name = "bShowAllAgain";
            this.bShowAllAgain.Size = new System.Drawing.Size(89, 64);
            this.bShowAllAgain.TabIndex = 15;
            this.bShowAllAgain.Text = "Show all";
            this.bShowAllAgain.UseVisualStyleBackColor = true;
            this.bShowAllAgain.Click += new System.EventHandler(this.bShowAllAgain_Click);
            // 
            // btnEmployeeShiftsView
            // 
            this.btnEmployeeShiftsView.Location = new System.Drawing.Point(12, 8);
            this.btnEmployeeShiftsView.Name = "btnEmployeeShiftsView";
            this.btnEmployeeShiftsView.Size = new System.Drawing.Size(126, 60);
            this.btnEmployeeShiftsView.TabIndex = 16;
            this.btnEmployeeShiftsView.Text = "View employee shifts";
            this.btnEmployeeShiftsView.UseVisualStyleBackColor = true;
            this.btnEmployeeShiftsView.Click += new System.EventHandler(this.btnEmployeeShiftsView_Click_1);
            // 
            // btnAssignShift
            // 
            this.btnAssignShift.Location = new System.Drawing.Point(144, 12);
            this.btnAssignShift.Name = "btnAssignShift";
            this.btnAssignShift.Size = new System.Drawing.Size(91, 56);
            this.btnAssignShift.TabIndex = 17;
            this.btnAssignShift.Text = "Assign shift";
            this.btnAssignShift.UseVisualStyleBackColor = true;
            this.btnAssignShift.Click += new System.EventHandler(this.btnAssignShift_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 844);
            this.Controls.Add(this.btnAssignShift);
            this.Controls.Add(this.btnEmployeeShiftsView);
            this.Controls.Add(this.bShowAllAgain);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.bChangeStock);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.bProductStatistics);
            this.Controls.Add(this.bRefreshProducts);
            this.Controls.Add(this.bViewDetailsProduct);
            this.Controls.Add(this.bRemoveProduct);
            this.Controls.Add(this.bAddProduct);
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "ManagementForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnAssignShift;
    }
}