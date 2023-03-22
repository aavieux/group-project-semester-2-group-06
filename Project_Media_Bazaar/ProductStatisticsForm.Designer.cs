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
            SuspendLayout();
            // 
            // lTotalSales
            // 
            lTotalSales.AutoSize = true;
            lTotalSales.Location = new Point(368, 105);
            lTotalSales.Name = "lTotalSales";
            lTotalSales.Size = new Size(59, 25);
            lTotalSales.TabIndex = 0;
            lTotalSales.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 105);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Total sales:";
            // 
            // lMostSoldProduct
            // 
            lMostSoldProduct.AutoSize = true;
            lMostSoldProduct.Location = new Point(355, 193);
            lMostSoldProduct.Name = "lMostSoldProduct";
            lMostSoldProduct.Size = new Size(59, 25);
            lMostSoldProduct.TabIndex = 2;
            lMostSoldProduct.Text = "label1";
            // 
            // ProductStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 411);
            Controls.Add(lMostSoldProduct);
            Controls.Add(label1);
            Controls.Add(lTotalSales);
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
    }
}