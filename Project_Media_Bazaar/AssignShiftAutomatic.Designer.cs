namespace Project_Media_Bazaar
{
    partial class AssignShiftAutomatic
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
            this.btnAssignTheShift = new System.Windows.Forms.Button();
            this.lbShifts = new System.Windows.Forms.ListBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAssignTheShift
            // 
            this.btnAssignTheShift.Location = new System.Drawing.Point(30, 12);
            this.btnAssignTheShift.Name = "btnAssignTheShift";
            this.btnAssignTheShift.Size = new System.Drawing.Size(189, 29);
            this.btnAssignTheShift.TabIndex = 0;
            this.btnAssignTheShift.Text = "assignTheShift";
            this.btnAssignTheShift.UseVisualStyleBackColor = true;
            this.btnAssignTheShift.Click += new System.EventHandler(this.btnAssignTheShift_Click);
            // 
            // lbShifts
            // 
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.ItemHeight = 20;
            this.lbShifts.Location = new System.Drawing.Point(30, 101);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(656, 264);
            this.lbShifts.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(411, 14);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(250, 27);
            this.startDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start date: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "End date: ";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(411, 58);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(250, 27);
            this.endDate.TabIndex = 5;
            // 
            // AssignShiftAutomatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.lbShifts);
            this.Controls.Add(this.btnAssignTheShift);
            this.Name = "AssignShiftAutomatic";
            this.Text = "AssignShiftAutomatic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAssignTheShift;
        private ListBox lbShifts;
        private DateTimePicker startDate;
        private Label label1;
        private Label label2;
        private DateTimePicker endDate;
    }
}