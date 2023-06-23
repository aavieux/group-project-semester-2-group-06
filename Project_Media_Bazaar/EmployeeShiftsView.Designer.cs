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
            listBox_search = new ListBox();
            search_txt = new TextBox();
            found_users_lbl = new Label();
            listBox_shifts = new ListBox();
            shifts_lbl = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(5, 3);
            monthCalendar1.Dock = DockStyle.Fill;
            monthCalendar1.Location = new Point(0, 0);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.MaximumSize = new Size(689, 650);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            search_lbl.Location = new Point(700, 20);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(150, 28);
            search_lbl.TabIndex = 11;
            search_lbl.Text = "Search by name";
            // 
            // listBox_search
            // 
            listBox_search.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_search.FormattingEnabled = true;
            listBox_search.ItemHeight = 28;
            listBox_search.Location = new Point(699, 142);
            listBox_search.Name = "listBox_search";
            listBox_search.Size = new Size(435, 88);
            listBox_search.TabIndex = 13;
            listBox_search.SelectedIndexChanged += listBox_search_SelectedIndexChanged;
            listBox_search.MouseDoubleClick += listBox_search_MouseDoubleClick;
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            search_txt.Location = new Point(700, 51);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(435, 34);
            search_txt.TabIndex = 14;
            search_txt.TextChanged += search_txt_TextChanged;
            // 
            // found_users_lbl
            // 
            found_users_lbl.AutoSize = true;
            found_users_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            found_users_lbl.Location = new Point(699, 111);
            found_users_lbl.Name = "found_users_lbl";
            found_users_lbl.Size = new Size(117, 28);
            found_users_lbl.TabIndex = 15;
            found_users_lbl.Text = "Found users";
            // 
            // listBox_shifts
            // 
            listBox_shifts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_shifts.FormattingEnabled = true;
            listBox_shifts.HorizontalScrollbar = true;
            listBox_shifts.ItemHeight = 28;
            listBox_shifts.Location = new Point(700, 284);
            listBox_shifts.Name = "listBox_shifts";
            listBox_shifts.Size = new Size(435, 172);
            listBox_shifts.TabIndex = 16;
            // 
            // shifts_lbl
            // 
            shifts_lbl.AutoSize = true;
            shifts_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            shifts_lbl.Location = new Point(699, 253);
            shifts_lbl.Name = "shifts_lbl";
            shifts_lbl.Size = new Size(118, 28);
            shifts_lbl.TabIndex = 17;
            shifts_lbl.Text = "Found shifts";
            // 
            // EmployeeShiftsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 519);
            Controls.Add(shifts_lbl);
            Controls.Add(listBox_shifts);
            Controls.Add(found_users_lbl);
            Controls.Add(search_txt);
            Controls.Add(listBox_search);
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
        private ListBox listBox_search;
        private TextBox search_txt;
        private Label found_users_lbl;
        private ListBox listBox_shifts;
        private Label shifts_lbl;
    }
}