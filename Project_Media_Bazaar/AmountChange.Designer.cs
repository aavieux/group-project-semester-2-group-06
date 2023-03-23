namespace Project_Media_Bazaar
{
    partial class AmountChange
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
            label1 = new Label();
            label2 = new Label();
            changedStock = new TextBox();
            changingAmount = new NumericUpDown();
            changeStock = new Button();
            changeType = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)changingAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 117);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "Change amount: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 288);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 1;
            label2.Text = "Current amount: ";
            // 
            // changedStock
            // 
            changedStock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            changedStock.Location = new Point(229, 285);
            changedStock.Margin = new Padding(3, 2, 3, 2);
            changedStock.Name = "changedStock";
            changedStock.Size = new Size(86, 34);
            changedStock.TabIndex = 2;
            // 
            // changingAmount
            // 
            changingAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            changingAmount.Location = new Point(229, 115);
            changingAmount.Margin = new Padding(3, 2, 3, 2);
            changingAmount.Name = "changingAmount";
            changingAmount.Size = new Size(245, 34);
            changingAmount.TabIndex = 3;
            // 
            // changeStock
            // 
            changeStock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            changeStock.Location = new Point(229, 183);
            changeStock.Margin = new Padding(3, 2, 3, 2);
            changeStock.Name = "changeStock";
            changeStock.Size = new Size(244, 47);
            changeStock.TabIndex = 4;
            changeStock.Text = "Change stock";
            changeStock.UseVisualStyleBackColor = true;
            changeStock.Click += changeStock_Click;
            // 
            // changeType
            // 
            changeType.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            changeType.FormattingEnabled = true;
            changeType.Items.AddRange(new object[] { "increase", "decrease" });
            changeType.Location = new Point(229, 39);
            changeType.Margin = new Padding(3, 2, 3, 2);
            changeType.Name = "changeType";
            changeType.Size = new Size(244, 36);
            changeType.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 39);
            label3.Name = "label3";
            label3.Size = new Size(131, 28);
            label3.TabIndex = 6;
            label3.Text = "Change type: ";
            // 
            // AmountChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(changeType);
            Controls.Add(changeStock);
            Controls.Add(changingAmount);
            Controls.Add(changedStock);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AmountChange";
            Text = "AmountChange";
            ((System.ComponentModel.ISupportInitialize)changingAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox changedStock;
        private NumericUpDown changingAmount;
        private Button changeStock;
        private ComboBox changeType;
        private Label label3;
    }
}