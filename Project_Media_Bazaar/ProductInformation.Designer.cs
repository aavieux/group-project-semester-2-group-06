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
            showName = new Label();
            showCategory = new Label();
            showDescription = new Label();
            showAmount = new Label();
            SuspendLayout();
            // 
            // showName
            // 
            showName.AutoSize = true;
            showName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showName.Location = new Point(31, 19);
            showName.Name = "showName";
            showName.Size = new Size(83, 37);
            showName.TabIndex = 0;
            showName.Text = "name";
            // 
            // showCategory
            // 
            showCategory.AutoSize = true;
            showCategory.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showCategory.Location = new Point(31, 71);
            showCategory.Name = "showCategory";
            showCategory.Size = new Size(120, 37);
            showCategory.TabIndex = 1;
            showCategory.Text = "category";
            // 
            // showDescription
            // 
            showDescription.AutoSize = true;
            showDescription.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showDescription.Location = new Point(31, 121);
            showDescription.Name = "showDescription";
            showDescription.Size = new Size(149, 37);
            showDescription.TabIndex = 2;
            showDescription.Text = "description";
            // 
            // showAmount
            // 
            showAmount.AutoSize = true;
            showAmount.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showAmount.Location = new Point(31, 179);
            showAmount.Name = "showAmount";
            showAmount.Size = new Size(109, 37);
            showAmount.TabIndex = 3;
            showAmount.Text = "amount";
            // 
            // ProductInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(showAmount);
            Controls.Add(showDescription);
            Controls.Add(showCategory);
            Controls.Add(showName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductInformation";
            Text = "Product Information";
            Load += ProductInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showName;
        private Label showCategory;
        private Label showDescription;
        private Label showAmount;
    }
}