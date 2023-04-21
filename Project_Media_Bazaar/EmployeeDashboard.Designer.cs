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
            tabControl1 = new TabControl();
            tabDashboard = new TabPage();
            search_lbl = new Label();
            bLogout = new Button();
            tbF = new TextBox();
            listBoxEmployees = new ListBox();
            tabCreateEmployee = new TabPage();
            label10 = new Label();
            label9 = new Label();
            gbCredentials = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            tbpassword = new TextBox();
            tbemail = new TextBox();
            tbnickname = new TextBox();
            label7 = new Label();
            gpPersonalData = new GroupBox();
            tbfirstName = new TextBox();
            tblastName = new TextBox();
            lbFirstName = new Label();
            label1 = new Label();
            dtBirthDate = new DateTimePicker();
            tbAdress = new TextBox();
            tbPhoneNumber = new TextBox();
            tbsalary = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbRole = new ComboBox();
            btnCreate = new Button();
            tbWorkingHours = new TextBox();
            tabShift = new TabPage();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnShift = new Button();
            dtDateShift = new DateTimePicker();
            cbShifts = new ComboBox();
            tbphoneShift = new TextBox();
            tbNameEmShift = new TextBox();
            btnSelectEmployeeToShift = new Button();
            cbEmployeesShifts = new ComboBox();
            employee_lbl = new Label();
            tabControl1.SuspendLayout();
            tabDashboard.SuspendLayout();
            tabCreateEmployee.SuspendLayout();
            gbCredentials.SuspendLayout();
            gpPersonalData.SuspendLayout();
            tabShift.SuspendLayout();
            tabUpdateEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabDashboard);
            tabControl1.Controls.Add(tabCreateEmployee);
            tabControl1.Controls.Add(tabShift);
            tabControl1.Location = new Point(24, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(868, 345);
            tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(search_lbl);
            tabDashboard.Controls.Add(bLogout);
            tabDashboard.Controls.Add(tbIdDelete);
            tabDashboard.Controls.Add(btnDelete);
            tabDashboard.Controls.Add(btnFilter);
            tabDashboard.Controls.Add(tbF);
            tabDashboard.Controls.Add(listBoxEmployees);
            tabDashboard.Location = new Point(27, 4);
            tabDashboard.Margin = new Padding(3, 2, 3, 2);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3, 2, 3, 2);
            tabDashboard.Size = new Size(837, 337);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            search_lbl.Location = new Point(6, 29);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(265, 28);
            search_lbl.TabIndex = 7;
            search_lbl.Text = "Search Employee By Name";
            // 
            // bLogout
            // 
            bLogout.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bLogout.Location = new Point(704, 29);
            bLogout.Margin = new Padding(3, 2, 3, 2);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(105, 50);
            bLogout.TabIndex = 6;
            bLogout.Text = "Log out";
            bLogout.UseVisualStyleBackColor = true;
            bLogout.Click += button1_Click;
            // 
            // tbIdDelete
            // 
            tbIdDelete.Location = new Point(11, 44);
            tbIdDelete.Margin = new Padding(4);
            tbIdDelete.Name = "tbIdDelete";
            tbIdDelete.Size = new Size(330, 31);
            tbIdDelete.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(351, 44);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_2;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Coral;
            btnFilter.Location = new Point(351, 95);
            btnFilter.Margin = new Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 36);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click_2;
            // 
            // tbF
            // 
            tbF.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbF.Location = new Point(6, 59);
            tbF.Margin = new Padding(3, 2, 3, 2);
            tbF.Name = "tbF";
            tbF.Size = new Size(347, 34);
            tbF.TabIndex = 1;
            tbF.TextChanged += tbF_TextChanged;
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 28;
            listBoxEmployees.Location = new Point(6, 97);
            listBoxEmployees.Margin = new Padding(3, 2, 3, 2);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(803, 200);
            listBoxEmployees.TabIndex = 0;
            listBoxEmployees.DoubleClick += listBoxEmployees_DoubleClick;
            // 
            // tabCreateEmployee
            // 
            tabCreateEmployee.Controls.Add(label10);
            tabCreateEmployee.Controls.Add(label9);
            tabCreateEmployee.Controls.Add(gbCredentials);
            tabCreateEmployee.Controls.Add(gpPersonalData);
            tabCreateEmployee.Controls.Add(cbRole);
            tabCreateEmployee.Controls.Add(btnCreate);
            tabCreateEmployee.Controls.Add(tbWorkingHours);
            tabCreateEmployee.Location = new Point(27, 4);
            tabCreateEmployee.Margin = new Padding(3, 2, 3, 2);
            tabCreateEmployee.Name = "tabCreateEmployee";
            tabCreateEmployee.Padding = new Padding(3, 2, 3, 2);
            tabCreateEmployee.Size = new Size(837, 337);
            tabCreateEmployee.TabIndex = 1;
            tabCreateEmployee.Text = "CreateEmployee";
            tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 237);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 25;
            label10.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 195);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 24;
            label9.Text = "Working Hours:";
            // 
            // gbCredentials
            // 
            gbCredentials.Controls.Add(label8);
            gbCredentials.Controls.Add(label6);
            gbCredentials.Controls.Add(tbpassword);
            gbCredentials.Controls.Add(tbemail);
            gbCredentials.Controls.Add(tbnickname);
            gbCredentials.Controls.Add(label7);
            gbCredentials.Location = new Point(6, 7);
            gbCredentials.Margin = new Padding(3, 2, 3, 2);
            gbCredentials.Name = "gbCredentials";
            gbCredentials.Padding = new Padding(3, 2, 3, 2);
            gbCredentials.Size = new Size(326, 143);
            gbCredentials.TabIndex = 23;
            gbCredentials.TabStop = false;
            gbCredentials.Text = "Credentials";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 114);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 24;
            label8.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 38);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 14;
            label6.Text = "Nickname:";
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(200, 75);
            tbpassword.Margin = new Padding(3, 2, 3, 2);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(110, 23);
            tbpassword.TabIndex = 7;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(200, 112);
            tbemail.Margin = new Padding(3, 2, 3, 2);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(110, 23);
            tbemail.TabIndex = 21;
            // 
            // tbnickname
            // 
            tbnickname.Location = new Point(200, 38);
            tbnickname.Margin = new Padding(3, 2, 3, 2);
            tbnickname.Name = "tbnickname";
            tbnickname.Size = new Size(110, 23);
            tbnickname.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 77);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 15;
            label7.Text = "Password:";
            // 
            // gpPersonalData
            // 
            gpPersonalData.Controls.Add(lDepartment);
            gpPersonalData.Controls.Add(cbDepartment);
            gpPersonalData.Controls.Add(tbfirstName);
            gpPersonalData.Controls.Add(tblastName);
            gpPersonalData.Controls.Add(lbFirstName);
            gpPersonalData.Controls.Add(label1);
            gpPersonalData.Controls.Add(dtBirthDate);
            gpPersonalData.Controls.Add(tbAdress);
            gpPersonalData.Controls.Add(tbPhoneNumber);
            gpPersonalData.Controls.Add(tbsalary);
            gpPersonalData.Controls.Add(label5);
            gpPersonalData.Controls.Add(label4);
            gpPersonalData.Controls.Add(label3);
            gpPersonalData.Controls.Add(label2);
            gpPersonalData.Location = new Point(337, 7);
            gpPersonalData.Margin = new Padding(3, 2, 3, 2);
            gpPersonalData.Name = "gpPersonalData";
            gpPersonalData.Padding = new Padding(3, 2, 3, 2);
            gpPersonalData.Size = new Size(445, 328);
            gpPersonalData.TabIndex = 22;
            gpPersonalData.TabStop = false;
            gpPersonalData.Text = "Personal Data";
            // 
            // lDepartment
            // 
            lDepartment.AutoSize = true;
            lDepartment.Location = new Point(34, 418);
            lDepartment.Margin = new Padding(4, 0, 4, 0);
            lDepartment.Name = "lDepartment";
            lDepartment.Size = new Size(111, 25);
            lDepartment.TabIndex = 15;
            lDepartment.Text = "Department:";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Items.AddRange(new object[] { "TV", "HiFi", "Computers", "Mobile", "Personal Care", "Home Care", "Kitchen Appliances", "Automotive" });
            cbDepartment.Location = new Point(290, 415);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(182, 33);
            cbDepartment.TabIndex = 14;
            // 
            // tbfirstName
            // 
            tbfirstName.Location = new Point(203, 20);
            tbfirstName.Margin = new Padding(3, 2, 3, 2);
            tbfirstName.Name = "tbfirstName";
            tbfirstName.Size = new Size(149, 23);
            tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            tblastName.Location = new Point(203, 56);
            tblastName.Margin = new Padding(3, 2, 3, 2);
            tblastName.Name = "tblastName";
            tblastName.Size = new Size(149, 23);
            tblastName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(24, 26);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(67, 15);
            lbFirstName.TabIndex = 8;
            lbFirstName.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 9;
            label1.Text = "Last Name:";
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(203, 94);
            dtBirthDate.Margin = new Padding(3, 2, 3, 2);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(149, 23);
            dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(203, 138);
            tbAdress.Margin = new Padding(3, 2, 3, 2);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(149, 23);
            tbAdress.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(203, 177);
            tbPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(149, 23);
            tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            tbsalary.Location = new Point(203, 215);
            tbsalary.Margin = new Padding(3, 2, 3, 2);
            tbsalary.Name = "tbsalary";
            tbsalary.Size = new Size(149, 23);
            tbsalary.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 215);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 13;
            label5.Text = "Salary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 177);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 12;
            label4.Text = "Phone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 138);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 98);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Date Of Birth:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(182, 235);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(133, 23);
            cbRole.TabIndex = 20;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkSeaGreen;
            btnCreate.Location = new Point(10, 278);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(304, 57);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create Employee";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // tbWorkingHours
            // 
            tbWorkingHours.Location = new Point(182, 195);
            tbWorkingHours.Margin = new Padding(3, 2, 3, 2);
            tbWorkingHours.Name = "tbWorkingHours";
            tbWorkingHours.Size = new Size(133, 23);
            tbWorkingHours.TabIndex = 17;
            // 
            // tabShift
            // 
            tabShift.Controls.Add(employee_lbl);
            tabShift.Controls.Add(label14);
            tabShift.Controls.Add(label13);
            tabShift.Controls.Add(label12);
            tabShift.Controls.Add(label11);
            tabShift.Controls.Add(btnShift);
            tabShift.Controls.Add(dtDateShift);
            tabShift.Controls.Add(cbShifts);
            tabShift.Controls.Add(tbphoneShift);
            tabShift.Controls.Add(tbNameEmShift);
            tabShift.Controls.Add(btnSelectEmployeeToShift);
            tabShift.Controls.Add(cbEmployeesShifts);
            tabShift.Location = new Point(27, 4);
            tabShift.Margin = new Padding(3, 2, 3, 2);
            tabShift.Name = "tabShift";
            tabShift.Size = new Size(837, 337);
            tabShift.TabIndex = 2;
            tabShift.Text = "Assign Shift";
            tabShift.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(91, 162);
            label14.Name = "label14";
            label14.Size = new Size(57, 28);
            label14.TabIndex = 10;
            label14.Text = "Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(91, 106);
            label13.Name = "label13";
            label13.Size = new Size(56, 28);
            label13.TabIndex = 9;
            label13.Text = "Shift:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(148, 199);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(133, 25);
            label12.TabIndex = 8;
            label12.Text = "Phone number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(148, 129);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(63, 25);
            label11.TabIndex = 7;
            label11.Text = "Name:";
            // 
            // btnShift
            // 
            btnShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnShift.Location = new Point(99, 262);
            btnShift.Margin = new Padding(3, 2, 3, 2);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(682, 56);
            btnShift.TabIndex = 6;
            btnShift.Text = "Assign Shift";
            btnShift.UseVisualStyleBackColor = true;
            btnShift.Click += btnShift_Click;
            // 
            // dtDateShift
            // 
            dtDateShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateShift.Location = new Point(245, 156);
            dtDateShift.Margin = new Padding(3, 2, 3, 2);
            dtDateShift.Name = "dtDateShift";
            dtDateShift.Size = new Size(245, 34);
            dtDateShift.TabIndex = 5;
            // 
            // cbShifts
            // 
            cbShifts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbShifts.FormattingEnabled = true;
            cbShifts.Location = new Point(299, 103);
            cbShifts.Margin = new Padding(3, 2, 3, 2);
            cbShifts.Name = "cbShifts";
            cbShifts.Size = new Size(191, 36);
            cbShifts.TabIndex = 4;
            // 
            // tbphoneShift
            // 
            tbphoneShift.Location = new Point(365, 199);
            tbphoneShift.Margin = new Padding(4);
            tbphoneShift.Name = "tbphoneShift";
            tbphoneShift.Size = new Size(155, 31);
            tbphoneShift.TabIndex = 3;
            // 
            // tbNameEmShift
            // 
            tbNameEmShift.Location = new Point(365, 129);
            tbNameEmShift.Margin = new Padding(4);
            tbNameEmShift.Name = "tbNameEmShift";
            tbNameEmShift.Size = new Size(155, 31);
            tbNameEmShift.TabIndex = 2;
            // 
            // btnSelectEmployeeToShift
            // 
            btnSelectEmployeeToShift.Location = new Point(365, 48);
            btnSelectEmployeeToShift.Margin = new Padding(4);
            btnSelectEmployeeToShift.Name = "btnSelectEmployeeToShift";
            btnSelectEmployeeToShift.Size = new Size(118, 36);
            btnSelectEmployeeToShift.TabIndex = 1;
            btnSelectEmployeeToShift.Text = "Select";
            btnSelectEmployeeToShift.UseVisualStyleBackColor = true;
            btnSelectEmployeeToShift.Click += btnSelectEmployeeToShift_Click;
            // 
            // cbEmployeesShifts
            // 
            cbEmployeesShifts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmployeesShifts.FormattingEnabled = true;
            cbEmployeesShifts.Location = new Point(299, 41);
            cbEmployeesShifts.Margin = new Padding(3, 2, 3, 2);
            cbEmployeesShifts.Name = "cbEmployeesShifts";
            cbEmployeesShifts.Size = new Size(191, 36);
            cbEmployeesShifts.TabIndex = 0;
            // 
            // employee_lbl
            // 
            employee_lbl.AutoSize = true;
            employee_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            employee_lbl.Location = new Point(91, 41);
            employee_lbl.Name = "employee_lbl";
            employee_lbl.Size = new Size(159, 28);
            employee_lbl.TabIndex = 11;
            employee_lbl.Text = "Select Employee:";
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 370);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeDashboard";
            Text = "EmployeeDashboard";
            tabControl1.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            tabCreateEmployee.ResumeLayout(false);
            tabCreateEmployee.PerformLayout();
            gbCredentials.ResumeLayout(false);
            gbCredentials.PerformLayout();
            gpPersonalData.ResumeLayout(false);
            gpPersonalData.PerformLayout();
            tabShift.ResumeLayout(false);
            tabShift.PerformLayout();
            tabUpdateEmployee.ResumeLayout(false);
            tabUpdateEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDashboard;
        private Button btnFilter;
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
        private Button btnDelete;
        private TextBox tbIdDelete;
        private TabPage tabUpdateEmployee;
        private TextBox tbfistName;
        private Button btnSelect;
        private ComboBox cbSelect;
        private TextBox tbphone;
        private Button btnSave;
        private Label lbphone;
        private Label lbName;
        private Label label10;
        private Label label9;
        private GroupBox gbCredentials;
        private Label label8;
        private GroupBox gpPersonalData;
        private Button bLogout;
        private Button btnSelectEmployeeToShift;
        private ComboBox cbEmployeesShifts;
        private TextBox tbphoneShift;
        private TextBox tbNameEmShift;
        private ComboBox cbShifts;
        private DateTimePicker dtDateShift;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnShift;
        private Label search_lbl;
        private Label employee_lbl;
    }
}