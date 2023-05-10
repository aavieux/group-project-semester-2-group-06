namespace Project_Media_Bazaar
{
    partial class ProductStatisticsForm
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
            lTotalSales = new Label();
            label1 = new Label();
            lMostSoldProduct = new Label();
            label2 = new Label();
            label3 = new Label();
            lSalesToday = new Label();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            dtpEndDate = new DateTimePicker();
            label6 = new Label();
            lSalesSpecific = new Label();
            bCheckSales = new Button();
            SuspendLayout();
            // 
            // lTotalSales
            // 
            lTotalSales.AutoSize = true;
            lTotalSales.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lTotalSales.Location = new Point(185, 9);
            lTotalSales.Margin = new Padding(2, 0, 2, 0);
            lTotalSales.Name = "lTotalSales";
            lTotalSales.Size = new Size(136, 37);
            lTotalSales.TabIndex = 0;
            lTotalSales.Text = "total sales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 1;
            label1.Text = "Total sales:";
            // 
            // lMostSoldProduct
            // 
            lMostSoldProduct.AutoSize = true;
            lMostSoldProduct.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lMostSoldProduct.Location = new Point(185, 46);
            lMostSoldProduct.Margin = new Padding(2, 0, 2, 0);
            lMostSoldProduct.Name = "lMostSoldProduct";
            lMostSoldProduct.Size = new Size(126, 37);
            lMostSoldProduct.TabIndex = 2;
            lMostSoldProduct.Text = "mostsold";
            lMostSoldProduct.Click += lMostSoldProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 46);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 3;
            label2.Text = "Most sold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(158, 37);
            label3.TabIndex = 4;
            label3.Text = "Sales today:";
            // 
            // lSalesToday
            // 
            lSalesToday.AutoSize = true;
            lSalesToday.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lSalesToday.Location = new Point(185, 83);
            lSalesToday.Margin = new Padding(2, 0, 2, 0);
            lSalesToday.Name = "lSalesToday";
            lSalesToday.Size = new Size(0, 37);
            lSalesToday.TabIndex = 5;
            lSalesToday.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 166);
            label4.Name = "label4";
            label4.Size = new Size(362, 37);
            label4.TabIndex = 6;
            label4.Text = "Sales for specific time period:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(92, 233);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 225);
            label5.Name = "label5";
            label5.Size = new Size(71, 31);
            label5.TabIndex = 8;
            label5.Text = "From:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(92, 273);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 265);
            label6.Name = "label6";
            label6.Size = new Size(68, 31);
            label6.TabIndex = 10;
            label6.Text = "Until:";
            // 
            // lSalesSpecific
            // 
            lSalesSpecific.AutoSize = true;
            lSalesSpecific.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lSalesSpecific.Location = new Point(298, 244);
            lSalesSpecific.Name = "lSalesSpecific";
            lSalesSpecific.Size = new Size(94, 37);
            lSalesSpecific.TabIndex = 11;
            lSalesSpecific.Text = "Result:";
            // 
            // bCheckSales
            // 
            bCheckSales.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bCheckSales.Location = new Point(92, 302);
            bCheckSales.Name = "bCheckSales";
            bCheckSales.Size = new Size(200, 48);
            bCheckSales.TabIndex = 12;
            bCheckSales.Text = "Check";
            bCheckSales.UseVisualStyleBackColor = true;
            bCheckSales.Click += bCheckSales_Click;
            // 
            // ProductStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 369);
            Controls.Add(bCheckSales);
            Controls.Add(lSalesSpecific);
            Controls.Add(label6);
            Controls.Add(dtpEndDate);
            Controls.Add(label5);
            Controls.Add(dtpStartDate);
            Controls.Add(label4);
            Controls.Add(lSalesToday);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lMostSoldProduct);
            Controls.Add(label1);
            Controls.Add(lTotalSales);
            Margin = new Padding(2);
            Name = "ProductStatisticsForm";
            Text = "ProductStatisticsForm";
            Load += ProductStatisticsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTotalSales;
        private Label label1;
        private Label lMostSoldProduct;
        private Label label2;
        private Label label3;
        private Label lSalesToday;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private Label label5;
        private DateTimePicker dtpEndDate;
        private Label label6;
        private Label lSalesSpecific;
        private Button bCheckSales;
    }
}