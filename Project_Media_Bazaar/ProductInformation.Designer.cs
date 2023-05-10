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
            this.showThreshold = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showName
            // 
            this.showName.AutoSize = true;
            this.showName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showName.Location = new System.Drawing.Point(35, 25);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(103, 46);
            this.showName.TabIndex = 0;
            this.showName.Text = "name";
            // 
            // showCategory
            // 
            this.showCategory.AutoSize = true;
            this.showCategory.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showCategory.Location = new System.Drawing.Point(35, 95);
            this.showCategory.Name = "showCategory";
            this.showCategory.Size = new System.Drawing.Size(151, 46);
            this.showCategory.TabIndex = 1;
            this.showCategory.Text = "category";
            // 
            // showDescription
            // 
            this.showDescription.AutoSize = true;
            this.showDescription.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showDescription.Location = new System.Drawing.Point(35, 161);
            this.showDescription.Name = "showDescription";
            this.showDescription.Size = new System.Drawing.Size(187, 46);
            this.showDescription.TabIndex = 2;
            this.showDescription.Text = "description";
            // 
            // showAmount
            // 
            this.showAmount.AutoSize = true;
            this.showAmount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showAmount.Location = new System.Drawing.Point(35, 239);
            this.showAmount.Name = "showAmount";
            this.showAmount.Size = new System.Drawing.Size(136, 46);
            this.showAmount.TabIndex = 3;
            this.showAmount.Text = "amount";
            // 
            // showThreshold
            // 
            this.showThreshold.AutoSize = true;
            this.showThreshold.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showThreshold.Location = new System.Drawing.Point(35, 311);
            this.showThreshold.Name = "showThreshold";
            this.showThreshold.Size = new System.Drawing.Size(162, 46);
            this.showThreshold.TabIndex = 4;
            this.showThreshold.Text = "threshold";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send a re-shelf request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showThreshold);
            this.Controls.Add(this.showAmount);
            this.Controls.Add(this.showDescription);
            this.Controls.Add(this.showCategory);
            this.Controls.Add(this.showName);
            this.Name = "ProductInformation";
            this.Text = "Product Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label showName;
        private Label showCategory;
        private Label showDescription;
        private Label showAmount;
        private Label showThreshold;
        private Button button1;
    }
}