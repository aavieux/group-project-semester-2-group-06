﻿namespace Project_Media_Bazaar
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
            showThreshold = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // showName
            // 
            showName.AutoSize = true;
            showName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showName.Location = new Point(31, 9);
            showName.Name = "showName";
            showName.Size = new Size(83, 37);
            showName.TabIndex = 0;
            showName.Text = "name";
            // 
            // showCategory
            // 
            showCategory.AutoSize = true;
            showCategory.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showCategory.Location = new Point(31, 55);
            showCategory.Name = "showCategory";
            showCategory.Size = new Size(120, 37);
            showCategory.TabIndex = 1;
            showCategory.Text = "category";
            // 
            // showDescription
            // 
            showDescription.AutoSize = true;
            showDescription.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showDescription.Location = new Point(31, 105);
            showDescription.Name = "showDescription";
            showDescription.Size = new Size(149, 37);
            showDescription.TabIndex = 2;
            showDescription.Text = "description";
            // 
            // showAmount
            // 
            showAmount.AutoSize = true;
            showAmount.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showAmount.Location = new Point(31, 160);
            showAmount.Name = "showAmount";
            showAmount.Size = new Size(109, 37);
            showAmount.TabIndex = 3;
            showAmount.Text = "amount";
            // 
            // showThreshold
            // 
            showThreshold.AutoSize = true;
            showThreshold.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            showThreshold.Location = new Point(31, 215);
            showThreshold.Name = "showThreshold";
            showThreshold.Size = new Size(129, 37);
            showThreshold.TabIndex = 4;
            showThreshold.Text = "threshold";
            // 
            // button1
            // 
            button1.Location = new Point(31, 275);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(252, 40);
            button1.TabIndex = 5;
            button1.Text = "Send a re-shelf request";
            button1.UseVisualStyleBackColor = true;
            // 
            // ProductInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(button1);
            Controls.Add(showThreshold);
            Controls.Add(showAmount);
            Controls.Add(showDescription);
            Controls.Add(showCategory);
            Controls.Add(showName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductInformation";
            Text = "Product Information";
            ResumeLayout(false);
            PerformLayout();
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