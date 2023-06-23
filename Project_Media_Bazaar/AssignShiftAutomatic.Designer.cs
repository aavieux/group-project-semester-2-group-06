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
            btnAssignShifts = new Button();
            lbShifts = new ListBox();
            startDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            endDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnAssignShifts
            // 
            btnAssignShifts.Location = new Point(26, 9);
            btnAssignShifts.Margin = new Padding(3, 2, 3, 2);
            btnAssignShifts.Name = "btnAssignShifts";
            btnAssignShifts.Size = new Size(165, 24);
            btnAssignShifts.TabIndex = 0;
            btnAssignShifts.Text = "Assign Random Shifts";
            btnAssignShifts.UseVisualStyleBackColor = true;
            btnAssignShifts.Click += btnAssignTheShift_Click;
            // 
            // lbShifts
            // 
            lbShifts.FormattingEnabled = true;
            lbShifts.ItemHeight = 15;
            lbShifts.Location = new Point(26, 76);
            lbShifts.Margin = new Padding(3, 2, 3, 2);
            lbShifts.Name = "lbShifts";
            lbShifts.Size = new Size(574, 199);
            lbShifts.TabIndex = 1;
            // 
            // startDate
            // 
            startDate.Location = new Point(360, 10);
            startDate.Margin = new Padding(3, 2, 3, 2);
            startDate.Name = "startDate";
            startDate.Size = new Size(219, 23);
            startDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Start date: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 44);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "End date: ";
            // 
            // endDate
            // 
            endDate.Location = new Point(360, 44);
            endDate.Margin = new Padding(3, 2, 3, 2);
            endDate.Name = "endDate";
            endDate.Size = new Size(219, 23);
            endDate.TabIndex = 5;
            // 
            // AssignShiftAutomatic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(endDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startDate);
            Controls.Add(lbShifts);
            Controls.Add(btnAssignShifts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AssignShiftAutomatic";
            Text = "AssignShiftAutomatic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAssignShifts;
        private ListBox lbShifts;
        private DateTimePicker startDate;
        private Label label1;
        private Label label2;
        private DateTimePicker endDate;
    }
}