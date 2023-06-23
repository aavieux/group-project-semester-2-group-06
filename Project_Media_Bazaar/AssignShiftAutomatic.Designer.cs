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
            this.SuspendLayout();
            // 
            // btnAssignTheShift
            // 
            this.btnAssignTheShift.Location = new System.Drawing.Point(30, 12);
            this.btnAssignTheShift.Name = "btnAssignTheShift";
            this.btnAssignTheShift.Size = new System.Drawing.Size(94, 29);
            this.btnAssignTheShift.TabIndex = 0;
            this.btnAssignTheShift.Text = "assignTheShift";
            this.btnAssignTheShift.UseVisualStyleBackColor = true;
            this.btnAssignTheShift.Click += new System.EventHandler(this.btnAssignTheShift_Click);
            // 
            // lbShifts
            // 
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.ItemHeight = 20;
            this.lbShifts.Location = new System.Drawing.Point(30, 47);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(738, 364);
            this.lbShifts.TabIndex = 1;
            // 
            // AssignShiftAutomatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbShifts);
            this.Controls.Add(this.btnAssignTheShift);
            this.Name = "AssignShiftAutomatic";
            this.Text = "AssignShiftAutomatic";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAssignTheShift;
        private ListBox lbShifts;
    }
}