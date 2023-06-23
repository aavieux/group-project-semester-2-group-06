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
            tbWorkingHours = new TextBox();
            cbRole = new ComboBox();
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
            btnCreate = new Button();
            tabShift = new TabPage();
            selectedEmployees_lbl = new Label();
            selectFromEmployees_lbl = new Label();
            selectedEmployees_clb = new ListBox();
            selectEmployees_clb = new ListBox();
            remove_btn = new Button();
            select_btn = new Button();
            label14 = new Label();
            label13 = new Label();
            btnShift = new Button();
            dtDateShift = new DateTimePicker();
            cbShifts = new ComboBox();
            btnEmployeeShiftsView = new Button();
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
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(24, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 374);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(search_lbl);
            tabDashboard.Controls.Add(bLogout);
            tabDashboard.Controls.Add(tbF);
            tabDashboard.Controls.Add(listBoxEmployees);
            tabDashboard.Location = new Point(27, 4);
            tabDashboard.Margin = new Padding(3, 2, 3, 2);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(2, 1, 2, 1);
            tabDashboard.Size = new Size(869, 366);
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
            bLogout.Location = new Point(754, 13);
            bLogout.Margin = new Padding(2, 1, 2, 1);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(110, 60);
            bLogout.TabIndex = 6;
            bLogout.Text = "Log out";
            bLogout.UseVisualStyleBackColor = true;
            bLogout.Click += bLogout_Click;
            // 
            // tbF
            // 
            tbF.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbF.Location = new Point(6, 59);
            tbF.Margin = new Padding(3, 2, 3, 2);
            tbF.Name = "tbF";
            tbF.Size = new Size(364, 34);
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
            listBoxEmployees.Size = new Size(858, 256);
            listBoxEmployees.TabIndex = 0;
            listBoxEmployees.MouseDoubleClick += listBoxEmployees_MouseDoubleClick;
            // 
            // tabCreateEmployee
            // 
            tabCreateEmployee.Controls.Add(tbWorkingHours);
            tabCreateEmployee.Controls.Add(cbRole);
            tabCreateEmployee.Controls.Add(label10);
            tabCreateEmployee.Controls.Add(label9);
            tabCreateEmployee.Controls.Add(gbCredentials);
            tabCreateEmployee.Controls.Add(gpPersonalData);
            tabCreateEmployee.Controls.Add(btnCreate);
            tabCreateEmployee.Location = new Point(27, 4);
            tabCreateEmployee.Margin = new Padding(3, 2, 3, 2);
            tabCreateEmployee.Name = "tabCreateEmployee";
            tabCreateEmployee.Padding = new Padding(2, 1, 2, 1);
            tabCreateEmployee.Size = new Size(869, 366);
            tabCreateEmployee.TabIndex = 1;
            tabCreateEmployee.Text = "CreateEmployee";
            tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // tbWorkingHours
            // 
            tbWorkingHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbWorkingHours.Location = new Point(168, 170);
            tbWorkingHours.Margin = new Padding(2, 1, 2, 1);
            tbWorkingHours.Name = "tbWorkingHours";
            tbWorkingHours.Size = new Size(144, 29);
            tbWorkingHours.TabIndex = 17;
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "JuniorSales", "SeniorSales", "FloorManager" });
            cbRole.Location = new Point(168, 201);
            cbRole.Margin = new Padding(2, 1, 2, 1);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(144, 29);
            cbRole.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(30, 196);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 21);
            label10.TabIndex = 25;
            label10.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 170);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(118, 21);
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
            gbCredentials.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbCredentials.Location = new Point(4, 4);
            gbCredentials.Margin = new Padding(2, 1, 2, 1);
            gbCredentials.Name = "gbCredentials";
            gbCredentials.Padding = new Padding(2, 1, 2, 1);
            gbCredentials.Size = new Size(328, 244);
            gbCredentials.TabIndex = 23;
            gbCredentials.TabStop = false;
            gbCredentials.Text = "Credentials";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 114);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 24;
            label8.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 38);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 14;
            label6.Text = "Nickname:";
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(164, 74);
            tbpassword.Margin = new Padding(3, 2, 3, 2);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(144, 29);
            tbpassword.TabIndex = 7;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(164, 114);
            tbemail.Margin = new Padding(3, 2, 3, 2);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(144, 29);
            tbemail.TabIndex = 21;
            // 
            // tbnickname
            // 
            tbnickname.Location = new Point(164, 38);
            tbnickname.Margin = new Padding(3, 2, 3, 2);
            tbnickname.Name = "tbnickname";
            tbnickname.Size = new Size(144, 29);
            tbnickname.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 77);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
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
            gpPersonalData.Location = new Point(337, 7);
            gpPersonalData.Margin = new Padding(3, 2, 3, 2);
            gpPersonalData.Name = "gpPersonalData";
            gpPersonalData.Padding = new Padding(2, 1, 2, 1);
            gpPersonalData.Size = new Size(527, 241);
            gpPersonalData.TabIndex = 22;
            gpPersonalData.TabStop = false;
            gpPersonalData.Text = "Personal Data";
            // 
            // tbfirstName
            // 
            tbfirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbfirstName.Location = new Point(167, 18);
            tbfirstName.Margin = new Padding(2, 1, 2, 1);
            tbfirstName.Name = "tbfirstName";
            tbfirstName.Size = new Size(231, 31);
            tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            tblastName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tblastName.Location = new Point(167, 52);
            tblastName.Margin = new Padding(2, 1, 2, 1);
            tblastName.Name = "tblastName";
            tblastName.Size = new Size(231, 31);
            tblastName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbFirstName.Location = new Point(17, 18);
            lbFirstName.Margin = new Padding(2, 0, 2, 0);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(101, 25);
            lbFirstName.TabIndex = 8;
            lbFirstName.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 9;
            label1.Text = "Last Name:";
            // 
            // dtBirthDate
            // 
            dtBirthDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirthDate.Location = new Point(167, 85);
            dtBirthDate.Margin = new Padding(2, 1, 2, 1);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(231, 31);
            dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            tbAdress.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbAdress.Location = new Point(167, 121);
            tbAdress.Margin = new Padding(2, 1, 2, 1);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(231, 31);
            tbAdress.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNumber.Location = new Point(167, 154);
            tbPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(231, 31);
            tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            tbsalary.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbsalary.Location = new Point(167, 187);
            tbsalary.Margin = new Padding(2, 1, 2, 1);
            tbsalary.Name = "tbsalary";
            tbsalary.Size = new Size(231, 31);
            tbsalary.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 189);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 13;
            label5.Text = "Salary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 12;
            label4.Text = "Phone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 121);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 11;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 10;
            label2.Text = "Date Of Birth:";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkSeaGreen;
            btnCreate.Location = new Point(8, 287);
            btnCreate.Margin = new Padding(2, 1, 2, 1);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(324, 60);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create Employee";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreateEmployee_Click_1;
            // 
            // tabShift
            // 
            tabShift.Controls.Add(btnEmployeeShiftsView);
            tabShift.Controls.Add(selectedEmployees_lbl);
            tabShift.Controls.Add(selectFromEmployees_lbl);
            tabShift.Controls.Add(selectedEmployees_clb);
            tabShift.Controls.Add(selectEmployees_clb);
            tabShift.Controls.Add(remove_btn);
            tabShift.Controls.Add(select_btn);
            tabShift.Controls.Add(label14);
            tabShift.Controls.Add(label13);
            tabShift.Controls.Add(btnShift);
            tabShift.Controls.Add(dtDateShift);
            tabShift.Controls.Add(cbShifts);
            tabShift.Location = new Point(27, 4);
            tabShift.Margin = new Padding(2, 1, 2, 1);
            tabShift.Name = "tabShift";
            tabShift.Size = new Size(869, 366);
            tabShift.TabIndex = 2;
            tabShift.Text = "Assign Shift";
            tabShift.UseVisualStyleBackColor = true;
            // 
            // selectedEmployees_lbl
            // 
            selectedEmployees_lbl.AutoSize = true;
            selectedEmployees_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            selectedEmployees_lbl.Location = new Point(653, 5);
            selectedEmployees_lbl.Margin = new Padding(2, 0, 2, 0);
            selectedEmployees_lbl.Name = "selectedEmployees_lbl";
            selectedEmployees_lbl.Size = new Size(185, 28);
            selectedEmployees_lbl.TabIndex = 18;
            selectedEmployees_lbl.Text = "Selected Employees";
            // 
            // selectFromEmployees_lbl
            // 
            selectFromEmployees_lbl.AutoSize = true;
            selectFromEmployees_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            selectFromEmployees_lbl.Location = new Point(421, 5);
            selectFromEmployees_lbl.Margin = new Padding(2, 0, 2, 0);
            selectFromEmployees_lbl.Name = "selectFromEmployees_lbl";
            selectFromEmployees_lbl.Size = new Size(214, 28);
            selectFromEmployees_lbl.TabIndex = 17;
            selectFromEmployees_lbl.Text = "Select From Employees";
            // 
            // selectedEmployees_clb
            // 
            selectedEmployees_clb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectedEmployees_clb.FormattingEnabled = true;
            selectedEmployees_clb.ItemHeight = 21;
            selectedEmployees_clb.Location = new Point(653, 35);
            selectedEmployees_clb.Margin = new Padding(2);
            selectedEmployees_clb.Name = "selectedEmployees_clb";
            selectedEmployees_clb.SelectionMode = SelectionMode.MultiSimple;
            selectedEmployees_clb.Size = new Size(214, 277);
            selectedEmployees_clb.TabIndex = 16;
            // 
            // selectEmployees_clb
            // 
            selectEmployees_clb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectEmployees_clb.FormattingEnabled = true;
            selectEmployees_clb.ItemHeight = 21;
            selectEmployees_clb.Location = new Point(422, 35);
            selectEmployees_clb.Margin = new Padding(2);
            selectEmployees_clb.Name = "selectEmployees_clb";
            selectEmployees_clb.SelectionMode = SelectionMode.MultiSimple;
            selectEmployees_clb.Size = new Size(213, 277);
            selectEmployees_clb.TabIndex = 15;
            // 
            // remove_btn
            // 
            remove_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            remove_btn.Location = new Point(653, 316);
            remove_btn.Margin = new Padding(2);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(214, 37);
            remove_btn.TabIndex = 14;
            remove_btn.Text = "Remove";
            remove_btn.UseVisualStyleBackColor = true;
            remove_btn.Click += remove_btn_Click;
            // 
            // select_btn
            // 
            select_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            select_btn.Location = new Point(422, 316);
            select_btn.Margin = new Padding(2);
            select_btn.Name = "select_btn";
            select_btn.Size = new Size(213, 37);
            select_btn.TabIndex = 13;
            select_btn.Text = "Select";
            select_btn.UseVisualStyleBackColor = true;
            select_btn.Click += select_btn_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(47, 148);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(63, 30);
            label14.TabIndex = 10;
            label14.Text = "Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(49, 97);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(61, 30);
            label13.TabIndex = 9;
            label13.Text = "Shift:";
            // 
            // btnShift
            // 
            btnShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnShift.Location = new Point(2, 309);
            btnShift.Margin = new Padding(2, 1, 2, 1);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(403, 50);
            btnShift.TabIndex = 6;
            btnShift.Text = "Assign Shift";
            btnShift.UseVisualStyleBackColor = true;
            btnShift.Click += btnAssignShift_Click_1;
            // 
            // dtDateShift
            // 
            dtDateShift.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dtDateShift.Location = new Point(145, 148);
            dtDateShift.Margin = new Padding(2, 1, 2, 1);
            dtDateShift.Name = "dtDateShift";
            dtDateShift.Size = new Size(226, 36);
            dtDateShift.TabIndex = 5;
            // 
            // cbShifts
            // 
            cbShifts.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbShifts.FormattingEnabled = true;
            cbShifts.Location = new Point(145, 97);
            cbShifts.Margin = new Padding(2, 1, 2, 1);
            cbShifts.Name = "cbShifts";
            cbShifts.Size = new Size(226, 38);
            cbShifts.TabIndex = 4;
            // 
            // btnEmployeeShiftsView
            // 
            btnEmployeeShiftsView.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeeShiftsView.Location = new Point(3, 261);
            btnEmployeeShiftsView.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeShiftsView.Name = "btnEmployeeShiftsView";
            btnEmployeeShiftsView.Size = new Size(402, 45);
            btnEmployeeShiftsView.TabIndex = 19;
            btnEmployeeShiftsView.Text = "View employee shifts";
            btnEmployeeShiftsView.UseVisualStyleBackColor = true;
            btnEmployeeShiftsView.Click += btnEmployeeShiftsView_Click;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 394);
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
        private Label selectedEmployees_lbl;
        private Label selectFromEmployees_lbl;
        private ListBox selectedEmployees_clb;
        private ListBox selectEmployees_clb;
        private Button remove_btn;
        private Button select_btn;
        private Label label10;
        private Label label9;
        private Button btnEmployeeShiftsView;
    }
}