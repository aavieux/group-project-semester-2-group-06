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
            btnAssignTheShift = new Button();
            lbShifts = new ListBox();
            SuspendLayout();
            // 
            // btnAssignTheShift
            // 
            btnAssignTheShift.Location = new Point(26, 9);
            btnAssignTheShift.Margin = new Padding(3, 2, 3, 2);
            btnAssignTheShift.Name = "btnAssignTheShift";
            btnAssignTheShift.Size = new Size(118, 37);
            btnAssignTheShift.TabIndex = 0;
            btnAssignTheShift.Text = "assignTheShift";
            btnAssignTheShift.UseVisualStyleBackColor = true;
            btnAssignTheShift.Click += btnAssignTheShift_Click;
            // 
            // lbShifts
            // 
            lbShifts.FormattingEnabled = true;
            lbShifts.ItemHeight = 15;
            lbShifts.Location = new Point(26, 50);
            lbShifts.Margin = new Padding(3, 2, 3, 2);
            lbShifts.Name = "lbShifts";
            lbShifts.Size = new Size(646, 259);
            lbShifts.TabIndex = 1;
            // 
            // AssignShiftAutomatic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lbShifts);
            Controls.Add(btnAssignTheShift);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AssignShiftAutomatic";
            Text = "AssignShiftAutomatic";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAssignTheShift;
        private ListBox lbShifts;
    }
}