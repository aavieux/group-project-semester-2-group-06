namespace Project_Media_Bazaar
{
    partial class EmployeeShiftsView
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
            monthCalendar1 = new MonthCalendar();
            search_lbl = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(5, 2);
            monthCalendar1.Dock = DockStyle.Fill;
            monthCalendar1.Location = new Point(0, 0);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.MaximumSize = new Size(689, 309);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            search_lbl.Location = new Point(700, 9);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(150, 28);
            search_lbl.TabIndex = 11;
            search_lbl.Text = "Search by name";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Append;
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(700, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(435, 36);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.TextChanged += comboBox1_TextChanged;
            comboBox1.Click += comboBox1_Click;
            // 
            // EmployeeShiftsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 318);
            Controls.Add(comboBox1);
            Controls.Add(search_lbl);
            Controls.Add(monthCalendar1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeShiftsView";
            Text = "EmployeeShiftsView";
            Load += EmployeeShiftsView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label search_lbl;
        private ComboBox comboBox1;
    }
}