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
            lMostSoldProduct.Location = new Point(195, 61);
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
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 3;
            label2.Text = "Most sold:";
            // 
            // ProductStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 327);
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
    }
}