﻿namespace Project_Media_Bazaar
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
            btnAssignShift = new Button();
            SuspendLayout();
            // 
            // bAddProduct
            // 
            bAddProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bAddProduct.Location = new Point(833, 111);
            bAddProduct.Margin = new Padding(1, 2, 1, 2);
            bAddProduct.Name = "bAddProduct";
            bAddProduct.Size = new Size(209, 93);
            bAddProduct.TabIndex = 1;
            bAddProduct.Text = "Add product";
            bAddProduct.UseVisualStyleBackColor = true;
            bAddProduct.Click += bAddProduct_Click_2;
            // 
            // bRemoveProduct
            // 
            bRemoveProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bRemoveProduct.Location = new Point(832, 216);
            bRemoveProduct.Margin = new Padding(1, 2, 1, 2);
            bRemoveProduct.Name = "bRemoveProduct";
            bRemoveProduct.Size = new Size(209, 89);
            bRemoveProduct.TabIndex = 2;
            bRemoveProduct.Text = "Remove product";
            bRemoveProduct.UseVisualStyleBackColor = true;
            bRemoveProduct.Click += bRemoveProduct_Click_2;
            // 
            // bViewDetailsProduct
            // 
            bViewDetailsProduct.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bViewDetailsProduct.Location = new Point(832, 6);
            bViewDetailsProduct.Margin = new Padding(1, 2, 1, 2);
            bViewDetailsProduct.Name = "bViewDetailsProduct";
            bViewDetailsProduct.Size = new Size(209, 91);
            bViewDetailsProduct.TabIndex = 3;
            bViewDetailsProduct.Text = "View details";
            bViewDetailsProduct.UseVisualStyleBackColor = true;
            bViewDetailsProduct.Click += bViewDetailsProduct_Click_2;
            // 
            // bRefreshProducts
            // 
            bRefreshProducts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bRefreshProducts.Location = new Point(833, 428);
            bRefreshProducts.Margin = new Padding(1, 2, 1, 2);
            bRefreshProducts.Name = "bRefreshProducts";
            bRefreshProducts.Size = new Size(209, 91);
            bRefreshProducts.TabIndex = 5;
            bRefreshProducts.Text = "Refresh";
            bRefreshProducts.UseVisualStyleBackColor = true;
            bRefreshProducts.Click += bRefreshProducts_Click_2;
            // 
            // bProductStatistics
            // 
            bProductStatistics.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bProductStatistics.Location = new Point(833, 538);
            bProductStatistics.Margin = new Padding(1, 2, 1, 2);
            bProductStatistics.Name = "bProductStatistics";
            bProductStatistics.Size = new Size(209, 91);
            bProductStatistics.TabIndex = 6;
            bProductStatistics.Text = "Open statistics";
            bProductStatistics.UseVisualStyleBackColor = true;
            bProductStatistics.Click += bProductStatistics_Click;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { ColumnId, ColumnName, ColumnAmount, ColumnCategory, StockItemIndicator });
            lvProducts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lvProducts.Location = new Point(11, 97);
            lvProducts.Margin = new Padding(1, 2, 1, 2);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(805, 529);
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
            bChangeStock.Location = new Point(833, 319);
            bChangeStock.Margin = new Padding(1, 2, 1, 2);
            bChangeStock.Name = "bChangeStock";
            bChangeStock.Size = new Size(209, 89);
            bChangeStock.TabIndex = 8;
            bChangeStock.Text = "Change stock";
            bChangeStock.UseVisualStyleBackColor = true;
            bChangeStock.Click += bChangeStock_Click_2;
            // 
            // tbF
            // 
            tbF.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbF.Location = new Point(126, 59);
            tbF.Margin = new Padding(3, 2, 3, 2);
            tbF.Name = "tbF";
            tbF.Size = new Size(519, 34);
            tbF.TabIndex = 9;
            tbF.TextChanged += tbF_TextChanged;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            search_lbl.Location = new Point(233, 25);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(247, 28);
            search_lbl.TabIndex = 10;
            search_lbl.Text = "Search Product By Name";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(651, 7);
            cbCategories.Margin = new Padding(3, 2, 3, 2);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(165, 23);
            cbCategories.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(651, 31);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(165, 24);
            button1.TabIndex = 12;
            button1.Text = "Filter by category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnTasks
            // 
            btnTasks.Location = new Point(651, 59);
            btnTasks.Margin = new Padding(3, 2, 3, 2);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(165, 34);
            btnTasks.TabIndex = 13;
            btnTasks.Text = "Manage employee tasks";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // bLogout
            // 
            bLogout.Location = new Point(10, 59);
            bLogout.Margin = new Padding(2);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(111, 32);
            bLogout.TabIndex = 14;
            bLogout.Text = "Log out";
            bLogout.UseVisualStyleBackColor = true;
            bLogout.Click += bLogout_Click;
            // 
            // bShowAllAgain
            // 
            bShowAllAgain.Location = new Point(568, 7);
            bShowAllAgain.Margin = new Padding(2);
            bShowAllAgain.Name = "bShowAllAgain";
            bShowAllAgain.Size = new Size(78, 48);
            bShowAllAgain.TabIndex = 15;
            bShowAllAgain.Text = "Show all";
            bShowAllAgain.UseVisualStyleBackColor = true;
            bShowAllAgain.Click += bShowAllAgain_Click;
            // 
            // btnEmployeeShiftsView
            // 
            btnEmployeeShiftsView.Location = new Point(10, 6);
            btnEmployeeShiftsView.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeShiftsView.Name = "btnEmployeeShiftsView";
            btnEmployeeShiftsView.Size = new Size(110, 45);
            btnEmployeeShiftsView.TabIndex = 16;
            btnEmployeeShiftsView.Text = "View employee shifts";
            btnEmployeeShiftsView.UseVisualStyleBackColor = true;
            btnEmployeeShiftsView.Click += btnEmployeeShiftsView_Click_1;
            // 
            // btnAssignShift
            // 
            btnAssignShift.Location = new Point(126, 9);
            btnAssignShift.Margin = new Padding(3, 2, 3, 2);
            btnAssignShift.Name = "btnAssignShift";
            btnAssignShift.Size = new Size(80, 42);
            btnAssignShift.TabIndex = 17;
            btnAssignShift.Text = "Assign shift";
            btnAssignShift.UseVisualStyleBackColor = true;
            btnAssignShift.Click += btnAssignShift_Click;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 633);
            Controls.Add(btnAssignShift);
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
            Margin = new Padding(1, 2, 1, 2);
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
        private Button btnAssignShift;
    }
}