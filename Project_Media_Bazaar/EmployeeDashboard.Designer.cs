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
            employee_lbl = new Label();
            label14 = new Label();
            label13 = new Label();
            btnShift = new Button();
            dtDateShift = new DateTimePicker();
            cbShifts = new ComboBox();
            cbEmployeesShifts = new ComboBox();
            tabControl1.SuspendLayout();
            tabDashboard.SuspendLayout();
            tabCreateEmployee.SuspendLayout();
            gbCredentials.SuspendLayout();
            gpPersonalData.SuspendLayout();
            tabShift.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabDashboard);
            tabControl1.Controls.Add(tabCreateEmployee);
            tabControl1.Controls.Add(tabShift);
            tabControl1.Location = new Point(34, 15);
            tabControl1.Margin = new Padding(4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1240, 575);
            tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(search_lbl);
            tabDashboard.Controls.Add(bLogout);
            tabDashboard.Controls.Add(tbF);
            tabDashboard.Controls.Add(listBoxEmployees);
            tabDashboard.Location = new Point(34, 4);
            tabDashboard.Margin = new Padding(4);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(4);
            tabDashboard.Size = new Size(1202, 567);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            search_lbl.Location = new Point(9, 49);
            search_lbl.Margin = new Padding(4, 0, 4, 0);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(390, 41);
            search_lbl.TabIndex = 7;
            search_lbl.Text = "Search Employee By Name";
            // 
            // bLogout
            // 
            bLogout.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bLogout.Location = new Point(1006, 49);
            bLogout.Margin = new Padding(4);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(150, 84);
            bLogout.TabIndex = 6;
            bLogout.Text = "Log out";
            bLogout.UseVisualStyleBackColor = true;
            bLogout.Click += bLogout_Click;
            // 
            // tbF
            // 
            tbF.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbF.Location = new Point(9, 99);
            tbF.Margin = new Padding(4);
            tbF.Name = "tbF";
            tbF.Size = new Size(494, 47);
            tbF.TabIndex = 1;
            tbF.TextChanged += tbF_TextChanged_1;
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 41;
            listBoxEmployees.Location = new Point(9, 161);
            listBoxEmployees.Margin = new Padding(4);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(1145, 291);
            listBoxEmployees.TabIndex = 0;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
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
            tabCreateEmployee.Location = new Point(34, 4);
            tabCreateEmployee.Margin = new Padding(4);
            tabCreateEmployee.Name = "tabCreateEmployee";
            tabCreateEmployee.Padding = new Padding(4);
            tabCreateEmployee.Size = new Size(1202, 567);
            tabCreateEmployee.TabIndex = 1;
            tabCreateEmployee.Text = "CreateEmployee";
            tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 395);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 25);
            label10.TabIndex = 25;
            label10.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 325);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 25);
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
            gbCredentials.Location = new Point(9, 11);
            gbCredentials.Margin = new Padding(4);
            gbCredentials.Name = "gbCredentials";
            gbCredentials.Padding = new Padding(4);
            gbCredentials.Size = new Size(466, 239);
            gbCredentials.TabIndex = 23;
            gbCredentials.TabStop = false;
            gbCredentials.Text = "Credentials";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 190);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 24;
            label8.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 64);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 14;
            label6.Text = "Nickname:";
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(286, 125);
            tbpassword.Margin = new Padding(4);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(155, 31);
            tbpassword.TabIndex = 7;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(286, 186);
            tbemail.Margin = new Padding(4);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(155, 31);
            tbemail.TabIndex = 21;
            // 
            // tbnickname
            // 
            tbnickname.Location = new Point(286, 64);
            tbnickname.Margin = new Padding(4);
            tbnickname.Name = "tbnickname";
            tbnickname.Size = new Size(155, 31);
            tbnickname.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 129);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 15;
            label7.Text = "Password:";
            // 
            // gpPersonalData
            // 
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
            gpPersonalData.Location = new Point(481, 11);
            gpPersonalData.Margin = new Padding(4);
            gpPersonalData.Name = "gpPersonalData";
            gpPersonalData.Padding = new Padding(4);
            gpPersonalData.Size = new Size(636, 546);
            gpPersonalData.TabIndex = 22;
            gpPersonalData.TabStop = false;
            gpPersonalData.Text = "Personal Data";
            // 
            // tbfirstName
            // 
            tbfirstName.Location = new Point(290, 34);
            tbfirstName.Margin = new Padding(4);
            tbfirstName.Name = "tbfirstName";
            tbfirstName.Size = new Size(212, 31);
            tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            tblastName.Location = new Point(290, 94);
            tblastName.Margin = new Padding(4);
            tblastName.Name = "tblastName";
            tblastName.Size = new Size(212, 31);
            tblastName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(34, 44);
            lbFirstName.Margin = new Padding(4, 0, 4, 0);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(101, 25);
            lbFirstName.TabIndex = 8;
            lbFirstName.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 9;
            label1.Text = "Last Name:";
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(290, 156);
            dtBirthDate.Margin = new Padding(4);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(212, 31);
            dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(290, 230);
            tbAdress.Margin = new Padding(4);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(212, 31);
            tbAdress.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(290, 295);
            tbPhoneNumber.Margin = new Padding(4);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(212, 31);
            tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            tbsalary.Location = new Point(290, 359);
            tbsalary.Margin = new Padding(4);
            tbsalary.Name = "tbsalary";
            tbsalary.Size = new Size(212, 31);
            tbsalary.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 359);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 13;
            label5.Text = "Salary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 12;
            label4.Text = "Phone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 230);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 11;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 164);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 10;
            label2.Text = "Date Of Birth:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(260, 391);
            cbRole.Margin = new Padding(4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(188, 33);
            cbRole.TabIndex = 20;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkSeaGreen;
            btnCreate.Location = new Point(14, 464);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(434, 95);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create Employee";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // tbWorkingHours
            // 
            tbWorkingHours.Location = new Point(260, 325);
            tbWorkingHours.Margin = new Padding(4);
            tbWorkingHours.Name = "tbWorkingHours";
            tbWorkingHours.Size = new Size(188, 31);
            tbWorkingHours.TabIndex = 17;
            // 
            // tabShift
            // 
            tabShift.Controls.Add(employee_lbl);
            tabShift.Controls.Add(label14);
            tabShift.Controls.Add(label13);
            tabShift.Controls.Add(btnShift);
            tabShift.Controls.Add(dtDateShift);
            tabShift.Controls.Add(cbShifts);
            tabShift.Controls.Add(cbEmployeesShifts);
            tabShift.Location = new Point(34, 4);
            tabShift.Margin = new Padding(4);
            tabShift.Name = "tabShift";
            tabShift.Size = new Size(1202, 567);
            tabShift.TabIndex = 2;
            tabShift.Text = "Assign Shift";
            tabShift.UseVisualStyleBackColor = true;
            // 
            // employee_lbl
            // 
            employee_lbl.AutoSize = true;
            employee_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            employee_lbl.Location = new Point(130, 69);
            employee_lbl.Margin = new Padding(4, 0, 4, 0);
            employee_lbl.Name = "employee_lbl";
            employee_lbl.Size = new Size(243, 41);
            employee_lbl.TabIndex = 11;
            employee_lbl.Text = "Select Employee:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(130, 270);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(87, 41);
            label14.TabIndex = 10;
            label14.Text = "Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(130, 176);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(84, 41);
            label13.TabIndex = 9;
            label13.Text = "Shift:";
            // 
            // btnShift
            // 
            btnShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnShift.Location = new Point(141, 436);
            btnShift.Margin = new Padding(4);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(974, 94);
            btnShift.TabIndex = 6;
            btnShift.Text = "Assign Shift";
            btnShift.UseVisualStyleBackColor = true;
            btnShift.Click += btnShift_Click_1;
            // 
            // dtDateShift
            // 
            dtDateShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateShift.Location = new Point(350, 260);
            dtDateShift.Margin = new Padding(4);
            dtDateShift.Name = "dtDateShift";
            dtDateShift.Size = new Size(348, 47);
            dtDateShift.TabIndex = 5;
            // 
            // cbShifts
            // 
            cbShifts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbShifts.FormattingEnabled = true;
            cbShifts.Location = new Point(428, 171);
            cbShifts.Margin = new Padding(4);
            cbShifts.Name = "cbShifts";
            cbShifts.Size = new Size(272, 49);
            cbShifts.TabIndex = 4;
            // 
            // cbEmployeesShifts
            // 
            cbEmployeesShifts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmployeesShifts.FormattingEnabled = true;
            cbEmployeesShifts.Location = new Point(428, 69);
            cbEmployeesShifts.Margin = new Padding(4);
            cbEmployeesShifts.Name = "cbEmployeesShifts";
            cbEmployeesShifts.Size = new Size(272, 49);
            cbEmployeesShifts.TabIndex = 0;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 616);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
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
            ResumeLayout(false);
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
        private ComboBox cbEmployeesShifts;
        private ComboBox cbShifts;
        private DateTimePicker dtDateShift;
        private Label label14;
        private Label label13;
        private Button btnShift;
        private Label search_lbl;
        private Label employee_lbl;
    }
}