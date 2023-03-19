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
            showName.Location = new Point(199, 135);
            showName.Margin = new Padding(4, 0, 4, 0);
            showName.Name = "showName";
            showName.Size = new Size(56, 25);
            showName.TabIndex = 0;
            showName.Text = "name";
            // 
            // showCategory
            // 
            showCategory.AutoSize = true;
            showCategory.Location = new Point(199, 185);
            showCategory.Margin = new Padding(4, 0, 4, 0);
            showCategory.Name = "showCategory";
            showCategory.Size = new Size(81, 25);
            showCategory.TabIndex = 1;
            showCategory.Text = "category";
            // 
            // showDescription
            // 
            showDescription.AutoSize = true;
            showDescription.Location = new Point(199, 210);
            showDescription.Margin = new Padding(4, 0, 4, 0);
            showDescription.Name = "showDescription";
            showDescription.Size = new Size(100, 25);
            showDescription.TabIndex = 2;
            showDescription.Text = "description";
            // 
            // showAmount
            // 
            showAmount.AutoSize = true;
            showAmount.Location = new Point(199, 160);
            showAmount.Margin = new Padding(4, 0, 4, 0);
            showAmount.Name = "showAmount";
            showAmount.Size = new Size(74, 25);
            showAmount.TabIndex = 3;
            showAmount.Text = "amount";
            // 
            // ProductInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(showAmount);
            Controls.Add(showDescription);
            Controls.Add(showCategory);
            Controls.Add(showName);
            Margin = new Padding(4, 4, 4, 4);
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