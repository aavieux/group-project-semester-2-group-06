namespace Project_Media_Bazaar
{
    partial class EmployeeDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.search_lbl = new System.Windows.Forms.Label();
            this.bLogout = new System.Windows.Forms.Button();
            this.tbF = new System.Windows.Forms.TextBox();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.tabCreateEmployee = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCredentials = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbnickname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gpPersonalData = new System.Windows.Forms.GroupBox();
            this.tbfirstName = new System.Windows.Forms.TextBox();
            this.tblastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbWorkingHours = new System.Windows.Forms.TextBox();
            this.tabShift = new System.Windows.Forms.TabPage();
            this.select_btn = new System.Windows.Forms.Button();
            this.employees_lbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnShift = new System.Windows.Forms.Button();
            this.dtDateShift = new System.Windows.Forms.DateTimePicker();
            this.cbShifts = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabCreateEmployee.SuspendLayout();
            this.gbCredentials.SuspendLayout();
            this.gpPersonalData.SuspendLayout();
            this.tabShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabCreateEmployee);
            this.tabControl1.Controls.Add(this.tabShift);
            this.tabControl1.Location = new System.Drawing.Point(27, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.search_lbl);
            this.tabDashboard.Controls.Add(this.bLogout);
            this.tabDashboard.Controls.Add(this.tbF);
            this.tabDashboard.Controls.Add(this.listBoxEmployees);
            this.tabDashboard.Location = new System.Drawing.Point(30, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDashboard.Size = new System.Drawing.Size(958, 452);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_lbl.Location = new System.Drawing.Point(7, 39);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(328, 35);
            this.search_lbl.TabIndex = 7;
            this.search_lbl.Text = "Search Employee By Name";
            // 
            // bLogout
            // 
            this.bLogout.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bLogout.Location = new System.Drawing.Point(805, 39);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(120, 67);
            this.bLogout.TabIndex = 6;
            this.bLogout.Text = "Log out";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click_1);
            // 
            // tbF
            // 
            this.tbF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbF.Location = new System.Drawing.Point(7, 79);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(396, 41);
            this.tbF.TabIndex = 1;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 35;
            this.listBoxEmployees.Location = new System.Drawing.Point(7, 129);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(917, 214);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // tabCreateEmployee
            // 
            this.tabCreateEmployee.Controls.Add(this.label10);
            this.tabCreateEmployee.Controls.Add(this.label9);
            this.tabCreateEmployee.Controls.Add(this.gbCredentials);
            this.tabCreateEmployee.Controls.Add(this.gpPersonalData);
            this.tabCreateEmployee.Controls.Add(this.cbRole);
            this.tabCreateEmployee.Controls.Add(this.btnCreate);
            this.tabCreateEmployee.Controls.Add(this.tbWorkingHours);
            this.tabCreateEmployee.Location = new System.Drawing.Point(30, 4);
            this.tabCreateEmployee.Name = "tabCreateEmployee";
            this.tabCreateEmployee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCreateEmployee.Size = new System.Drawing.Size(958, 452);
            this.tabCreateEmployee.TabIndex = 1;
            this.tabCreateEmployee.Text = "CreateEmployee";
            this.tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Role:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Working Hours:";
            // 
            // gbCredentials
            // 
            this.gbCredentials.Controls.Add(this.label8);
            this.gbCredentials.Controls.Add(this.label6);
            this.gbCredentials.Controls.Add(this.tbpassword);
            this.gbCredentials.Controls.Add(this.tbemail);
            this.gbCredentials.Controls.Add(this.tbnickname);
            this.gbCredentials.Controls.Add(this.label7);
            this.gbCredentials.Location = new System.Drawing.Point(7, 9);
            this.gbCredentials.Name = "gbCredentials";
            this.gbCredentials.Size = new System.Drawing.Size(373, 191);
            this.gbCredentials.TabIndex = 23;
            this.gbCredentials.TabStop = false;
            this.gbCredentials.Text = "Credentials";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nickname:";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(229, 100);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(125, 27);
            this.tbpassword.TabIndex = 7;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(229, 149);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(125, 27);
            this.tbemail.TabIndex = 21;
            // 
            // tbnickname
            // 
            this.tbnickname.Location = new System.Drawing.Point(229, 51);
            this.tbnickname.Name = "tbnickname";
            this.tbnickname.Size = new System.Drawing.Size(125, 27);
            this.tbnickname.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password:";
            // 
            // gpPersonalData
            // 
            this.gpPersonalData.Controls.Add(this.tbfirstName);
            this.gpPersonalData.Controls.Add(this.tblastName);
            this.gpPersonalData.Controls.Add(this.lbFirstName);
            this.gpPersonalData.Controls.Add(this.label1);
            this.gpPersonalData.Controls.Add(this.dtBirthDate);
            this.gpPersonalData.Controls.Add(this.tbAdress);
            this.gpPersonalData.Controls.Add(this.tbPhoneNumber);
            this.gpPersonalData.Controls.Add(this.tbsalary);
            this.gpPersonalData.Controls.Add(this.label5);
            this.gpPersonalData.Controls.Add(this.label4);
            this.gpPersonalData.Controls.Add(this.label3);
            this.gpPersonalData.Controls.Add(this.label2);
            this.gpPersonalData.Location = new System.Drawing.Point(385, 9);
            this.gpPersonalData.Name = "gpPersonalData";
            this.gpPersonalData.Size = new System.Drawing.Size(509, 437);
            this.gpPersonalData.TabIndex = 22;
            this.gpPersonalData.TabStop = false;
            this.gpPersonalData.Text = "Personal Data";
            // 
            // tbfirstName
            // 
            this.tbfirstName.Location = new System.Drawing.Point(232, 27);
            this.tbfirstName.Name = "tbfirstName";
            this.tbfirstName.Size = new System.Drawing.Size(171, 27);
            this.tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            this.tblastName.Location = new System.Drawing.Point(232, 75);
            this.tblastName.Name = "tblastName";
            this.tblastName.Size = new System.Drawing.Size(171, 27);
            this.tblastName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(27, 35);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(83, 20);
            this.lbFirstName.TabIndex = 8;
            this.lbFirstName.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last Name:";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(232, 125);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(171, 27);
            this.dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(232, 184);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(171, 27);
            this.tbAdress.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(232, 236);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(171, 27);
            this.tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            this.tbsalary.Location = new System.Drawing.Point(232, 287);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(171, 27);
            this.tbsalary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Of Birth:";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(208, 313);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(151, 28);
            this.cbRole.TabIndex = 20;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreate.Location = new System.Drawing.Point(11, 371);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(347, 76);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create Employee";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // tbWorkingHours
            // 
            this.tbWorkingHours.Location = new System.Drawing.Point(208, 260);
            this.tbWorkingHours.Name = "tbWorkingHours";
            this.tbWorkingHours.Size = new System.Drawing.Size(151, 27);
            this.tbWorkingHours.TabIndex = 17;
            // 
            // tabShift
            // 
            this.tabShift.Controls.Add(this.select_btn);
            this.tabShift.Controls.Add(this.employees_lbl);
            this.tabShift.Controls.Add(this.label14);
            this.tabShift.Controls.Add(this.label13);
            this.tabShift.Controls.Add(this.btnShift);
            this.tabShift.Controls.Add(this.dtDateShift);
            this.tabShift.Controls.Add(this.cbShifts);
            this.tabShift.Location = new System.Drawing.Point(30, 4);
            this.tabShift.Name = "tabShift";
            this.tabShift.Size = new System.Drawing.Size(958, 452);
            this.tabShift.TabIndex = 2;
            this.tabShift.Text = "Assign Shift";
            this.tabShift.UseVisualStyleBackColor = true;
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_btn.Location = new System.Drawing.Point(343, 55);
            this.select_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(219, 48);
            this.select_btn.TabIndex = 12;
            this.select_btn.Text = "Select";
            this.select_btn.UseVisualStyleBackColor = true;
            // 
            // employees_lbl
            // 
            this.employees_lbl.AutoSize = true;
            this.employees_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employees_lbl.Location = new System.Drawing.Point(104, 55);
            this.employees_lbl.Name = "employees_lbl";
            this.employees_lbl.Size = new System.Drawing.Size(212, 35);
            this.employees_lbl.TabIndex = 11;
            this.employees_lbl.Text = "Select Employees:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(104, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 35);
            this.label14.TabIndex = 10;
            this.label14.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(104, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 35);
            this.label13.TabIndex = 9;
            this.label13.Text = "Shift:";
            // 
            // btnShift
            // 
            this.btnShift.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShift.Location = new System.Drawing.Point(113, 349);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(779, 75);
            this.btnShift.TabIndex = 6;
            this.btnShift.Text = "Assign Shift";
            this.btnShift.UseVisualStyleBackColor = true;
            // 
            // dtDateShift
            // 
            this.dtDateShift.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDateShift.Location = new System.Drawing.Point(280, 208);
            this.dtDateShift.Name = "dtDateShift";
            this.dtDateShift.Size = new System.Drawing.Size(279, 41);
            this.dtDateShift.TabIndex = 5;
            // 
            // cbShifts
            // 
            this.cbShifts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbShifts.FormattingEnabled = true;
            this.cbShifts.Location = new System.Drawing.Point(343, 137);
            this.cbShifts.Name = "cbShifts";
            this.cbShifts.Size = new System.Drawing.Size(219, 43);
            this.cbShifts.TabIndex = 4;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabCreateEmployee.ResumeLayout(false);
            this.tabCreateEmployee.PerformLayout();
            this.gbCredentials.ResumeLayout(false);
            this.gbCredentials.PerformLayout();
            this.gpPersonalData.ResumeLayout(false);
            this.gpPersonalData.PerformLayout();
            this.tabShift.ResumeLayout(false);
            this.tabShift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDashboard;
        private TextBox tbF;
        private ListBox listBoxEmployees;
        private TabPage tabCreateEmployee;
        private TabPage tabShift;
        private TextBox tblastName;
        private TextBox tbfirstName;
        private DateTimePicker dtBirthDate;
        private TextBox tbAdress;
        private TextBox tbPhoneNumber;
        private TextBox tbsalary;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbFirstName;
        private TextBox tbpassword;
        private TextBox tbnickname;
        private Button btnCreate;
        private TextBox tbWorkingHours;
        private ComboBox cbRole;
        private TextBox tbemail;
        private Label label10;
        private Label label9;
        private GroupBox gbCredentials;
        private Label label8;
        private GroupBox gpPersonalData;
        private Button bLogout;
        private ComboBox cbShifts;
        private DateTimePicker dtDateShift;
        private Label label14;
        private Label label13;
        private Button btnShift;
        private Label search_lbl;
        private Label employees_lbl;
        private Button select_btn;
    }
}