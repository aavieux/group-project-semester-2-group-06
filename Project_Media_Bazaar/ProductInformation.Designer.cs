namespace Project_Media_Bazaar
{
    partial class ProductInformation
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
            this.showName = new System.Windows.Forms.Label();
            this.showCategory = new System.Windows.Forms.Label();
            this.showDescription = new System.Windows.Forms.Label();
            this.showAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showName
            // 
            this.showName.AutoSize = true;
            this.showName.Location = new System.Drawing.Point(159, 100);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(46, 20);
            this.showName.TabIndex = 0;
            this.showName.Text = "name";
            // 
            // showCategory
            // 
            this.showCategory.AutoSize = true;
            this.showCategory.Location = new System.Drawing.Point(348, 109);
            this.showCategory.Name = "showCategory";
            this.showCategory.Size = new System.Drawing.Size(67, 20);
            this.showCategory.TabIndex = 1;
            this.showCategory.Text = "category";
            // 
            // showDescription
            // 
            this.showDescription.AutoSize = true;
            this.showDescription.Location = new System.Drawing.Point(367, 215);
            this.showDescription.Name = "showDescription";
            this.showDescription.Size = new System.Drawing.Size(83, 20);
            this.showDescription.TabIndex = 2;
            this.showDescription.Text = "description";
            // 
            // showAmount
            // 
            this.showAmount.AutoSize = true;
            this.showAmount.Location = new System.Drawing.Point(557, 53);
            this.showAmount.Name = "showAmount";
            this.showAmount.Size = new System.Drawing.Size(60, 20);
            this.showAmount.TabIndex = 3;
            this.showAmount.Text = "amount";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAmount);
            this.Controls.Add(this.showDescription);
            this.Controls.Add(this.showCategory);
            this.Controls.Add(this.showName);
            this.Name = "Product";
            this.Text = "Product Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label showName;
        private Label showCategory;
        private Label showDescription;
        private Label showAmount;
    }
}