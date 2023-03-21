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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changedStock = new System.Windows.Forms.TextBox();
            this.changingAmount = new System.Windows.Forms.NumericUpDown();
            this.changeStock = new System.Windows.Forms.Button();
            this.changeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change amount: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current amount: ";
            // 
            // changedStock
            // 
            this.changedStock.Location = new System.Drawing.Point(391, 323);
            this.changedStock.Name = "changedStock";
            this.changedStock.Size = new System.Drawing.Size(150, 27);
            this.changedStock.TabIndex = 2;
            // 
            // changingAmount
            // 
            this.changingAmount.Location = new System.Drawing.Point(391, 168);
            this.changingAmount.Name = "changingAmount";
            this.changingAmount.Size = new System.Drawing.Size(150, 27);
            this.changingAmount.TabIndex = 3;
            // 
            // changeStock
            // 
            this.changeStock.Location = new System.Drawing.Point(391, 244);
            this.changeStock.Name = "changeStock";
            this.changeStock.Size = new System.Drawing.Size(150, 35);
            this.changeStock.TabIndex = 4;
            this.changeStock.Text = "Change stock";
            this.changeStock.UseVisualStyleBackColor = true;
            this.changeStock.Click += new System.EventHandler(this.changeStock_Click);
            // 
            // changeType
            // 
            this.changeType.FormattingEnabled = true;
            this.changeType.Items.AddRange(new object[] {
            "increase",
            "decrease"});
            this.changeType.Location = new System.Drawing.Point(390, 78);
            this.changeType.Name = "changeType";
            this.changeType.Size = new System.Drawing.Size(151, 28);
            this.changeType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change type: ";
            // 
            // AmountChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeType);
            this.Controls.Add(this.changeStock);
            this.Controls.Add(this.changingAmount);
            this.Controls.Add(this.changedStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AmountChange";
            this.Text = "AmountChange";
            ((System.ComponentModel.ISupportInitialize)(this.changingAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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