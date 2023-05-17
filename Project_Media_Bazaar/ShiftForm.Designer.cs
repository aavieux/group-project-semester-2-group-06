namespace Project_Media_Bazaar
{
    partial class ShiftForm
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
            lbEmployeeShifts = new ListBox();
            SuspendLayout();
            // 
            // lbEmployeeShifts
            // 
            lbEmployeeShifts.FormattingEnabled = true;
            lbEmployeeShifts.ItemHeight = 15;
            lbEmployeeShifts.Location = new Point(12, 8);
            lbEmployeeShifts.Margin = new Padding(3, 2, 3, 2);
            lbEmployeeShifts.Name = "lbEmployeeShifts";
            lbEmployeeShifts.Size = new Size(676, 319);
            lbEmployeeShifts.TabIndex = 0;
            lbEmployeeShifts.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ShiftForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lbEmployeeShifts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShiftForm";
            Text = "ShiftForm";
            Load += ShiftForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbEmployeeShifts;
    }
}