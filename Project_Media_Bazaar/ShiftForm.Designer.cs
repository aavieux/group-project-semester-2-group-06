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
            this.lbEmployeeShifts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbEmployeeShifts
            // 
            this.lbEmployeeShifts.FormattingEnabled = true;
            this.lbEmployeeShifts.ItemHeight = 20;
            this.lbEmployeeShifts.Location = new System.Drawing.Point(14, 11);
            this.lbEmployeeShifts.Name = "lbEmployeeShifts";
            this.lbEmployeeShifts.Size = new System.Drawing.Size(772, 424);
            this.lbEmployeeShifts.TabIndex = 0;
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lbEmployeeShifts);
            this.Name = "ShiftForm";
            this.Text = "ShiftForm";
            this.Load += new System.EventHandler(this.ShiftForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbEmployeeShifts;
    }
}