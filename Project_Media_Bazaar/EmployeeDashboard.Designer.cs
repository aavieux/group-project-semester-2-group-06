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
            this.button1 = new System.Windows.Forms.Button();
            this.tbIdDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnShift = new System.Windows.Forms.Button();
            this.dtDateShift = new System.Windows.Forms.DateTimePicker();
            this.cbShifts = new System.Windows.Forms.ComboBox();
            this.tbphoneShift = new System.Windows.Forms.TextBox();
            this.tbNameEmShift = new System.Windows.Forms.TextBox();
            this.btnSelectEmployeeToShift = new System.Windows.Forms.Button();
            this.cbEmployeesShifts = new System.Windows.Forms.ComboBox();
            this.tabUpdateEmployee = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbfistName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabCreateEmployee.SuspendLayout();
            this.gbCredentials.SuspendLayout();
            this.gpPersonalData.SuspendLayout();
            this.tabShift.SuspendLayout();
            this.tabUpdateEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabCreateEmployee);
            this.tabControl1.Controls.Add(this.tabShift);
            this.tabControl1.Controls.Add(this.tabUpdateEmployee);
            this.tabControl1.Location = new System.Drawing.Point(27, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.button1);
            this.tabDashboard.Controls.Add(this.tbIdDelete);
            this.tabDashboard.Controls.Add(this.btnDelete);
            this.tabDashboard.Controls.Add(this.btnFilter);
            this.tabDashboard.Controls.Add(this.tbF);
            this.tabDashboard.Controls.Add(this.listBoxEmployees);
            this.tabDashboard.Location = new System.Drawing.Point(30, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(958, 452);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbIdDelete
            // 
            this.tbIdDelete.Location = new System.Drawing.Point(9, 35);
            this.tbIdDelete.Name = "tbIdDelete";
            this.tbIdDelete.Size = new System.Drawing.Size(265, 27);
            this.tbIdDelete.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(281, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_2);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Coral;
            this.btnFilter.Location = new System.Drawing.Point(281, 76);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 29);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_2);
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(9, 77);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(265, 27);
            this.tbF.TabIndex = 1;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 35;
            this.listBoxEmployees.Location = new System.Drawing.Point(6, 129);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(917, 284);
            this.listBoxEmployees.TabIndex = 0;
            this.listBoxEmployees.DoubleClick += new System.EventHandler(this.listBoxEmployees_DoubleClick);
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
            this.tabCreateEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateEmployee.Size = new System.Drawing.Size(958, 452);
            this.tabCreateEmployee.TabIndex = 1;
            this.tabCreateEmployee.Text = "CreateEmployee";
            this.tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Role:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 260);
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
            this.gbCredentials.Location = new System.Drawing.Point(6, 9);
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
            this.tbfirstName.Size = new System.Drawing.Size(125, 27);
            this.tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            this.tblastName.Location = new System.Drawing.Point(232, 75);
            this.tblastName.Name = "tblastName";
            this.tblastName.Size = new System.Drawing.Size(125, 27);
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
            this.dtBirthDate.Size = new System.Drawing.Size(234, 27);
            this.dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(232, 184);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(125, 27);
            this.tbAdress.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(232, 236);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(125, 27);
            this.tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            this.tbsalary.Location = new System.Drawing.Point(232, 287);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(125, 27);
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
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
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
            this.tabShift.Controls.Add(this.label14);
            this.tabShift.Controls.Add(this.label13);
            this.tabShift.Controls.Add(this.label12);
            this.tabShift.Controls.Add(this.label11);
            this.tabShift.Controls.Add(this.btnShift);
            this.tabShift.Controls.Add(this.dtDateShift);
            this.tabShift.Controls.Add(this.cbShifts);
            this.tabShift.Controls.Add(this.tbphoneShift);
            this.tabShift.Controls.Add(this.tbNameEmShift);
            this.tabShift.Controls.Add(this.btnSelectEmployeeToShift);
            this.tabShift.Controls.Add(this.cbEmployeesShifts);
            this.tabShift.Location = new System.Drawing.Point(30, 4);
            this.tabShift.Name = "tabShift";
            this.tabShift.Size = new System.Drawing.Size(958, 452);
            this.tabShift.TabIndex = 2;
            this.tabShift.Text = "Assign Shift";
            this.tabShift.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Shift:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Phone number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Name:";
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(113, 349);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(779, 75);
            this.btnShift.TabIndex = 6;
            this.btnShift.Text = "Assign Shift";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // dtDateShift
            // 
            this.dtDateShift.Location = new System.Drawing.Point(292, 254);
            this.dtDateShift.Name = "dtDateShift";
            this.dtDateShift.Size = new System.Drawing.Size(250, 27);
            this.dtDateShift.TabIndex = 5;
            // 
            // cbShifts
            // 
            this.cbShifts.FormattingEnabled = true;
            this.cbShifts.Location = new System.Drawing.Point(292, 205);
            this.cbShifts.Name = "cbShifts";
            this.cbShifts.Size = new System.Drawing.Size(151, 28);
            this.cbShifts.TabIndex = 4;
            // 
            // tbphoneShift
            // 
            this.tbphoneShift.Location = new System.Drawing.Point(292, 159);
            this.tbphoneShift.Name = "tbphoneShift";
            this.tbphoneShift.Size = new System.Drawing.Size(125, 27);
            this.tbphoneShift.TabIndex = 3;
            // 
            // tbNameEmShift
            // 
            this.tbNameEmShift.Location = new System.Drawing.Point(292, 103);
            this.tbNameEmShift.Name = "tbNameEmShift";
            this.tbNameEmShift.Size = new System.Drawing.Size(125, 27);
            this.tbNameEmShift.TabIndex = 2;
            // 
            // btnSelectEmployeeToShift
            // 
            this.btnSelectEmployeeToShift.Location = new System.Drawing.Point(292, 38);
            this.btnSelectEmployeeToShift.Name = "btnSelectEmployeeToShift";
            this.btnSelectEmployeeToShift.Size = new System.Drawing.Size(94, 29);
            this.btnSelectEmployeeToShift.TabIndex = 1;
            this.btnSelectEmployeeToShift.Text = "Select";
            this.btnSelectEmployeeToShift.UseVisualStyleBackColor = true;
            this.btnSelectEmployeeToShift.Click += new System.EventHandler(this.btnSelectEmployeeToShift_Click);
            // 
            // cbEmployeesShifts
            // 
            this.cbEmployeesShifts.FormattingEnabled = true;
            this.cbEmployeesShifts.Location = new System.Drawing.Point(113, 38);
            this.cbEmployeesShifts.Name = "cbEmployeesShifts";
            this.cbEmployeesShifts.Size = new System.Drawing.Size(151, 28);
            this.cbEmployeesShifts.TabIndex = 0;
            // 
            // tabUpdateEmployee
            // 
            this.tabUpdateEmployee.Controls.Add(this.btnSave);
            this.tabUpdateEmployee.Controls.Add(this.lbphone);
            this.tabUpdateEmployee.Controls.Add(this.lbName);
            this.tabUpdateEmployee.Controls.Add(this.tbphone);
            this.tabUpdateEmployee.Controls.Add(this.tbfistName);
            this.tabUpdateEmployee.Controls.Add(this.btnSelect);
            this.tabUpdateEmployee.Controls.Add(this.cbSelect);
            this.tabUpdateEmployee.Location = new System.Drawing.Point(30, 4);
            this.tabUpdateEmployee.Name = "tabUpdateEmployee";
            this.tabUpdateEmployee.Size = new System.Drawing.Size(958, 452);
            this.tabUpdateEmployee.TabIndex = 3;
            this.tabUpdateEmployee.Text = "UpdateEmployee";
            this.tabUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(233, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(482, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_2);
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbphone.Location = new System.Drawing.Point(233, 245);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(197, 35);
            this.lbphone.TabIndex = 5;
            this.lbphone.Text = "Phone number:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(233, 164);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(92, 35);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name:";
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbphone.Location = new System.Drawing.Point(492, 239);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(223, 41);
            this.tbphone.TabIndex = 3;
            // 
            // tbfistName
            // 
            this.tbfistName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbfistName.Location = new System.Drawing.Point(492, 164);
            this.tbfistName.Name = "tbfistName";
            this.tbfistName.Size = new System.Drawing.Size(223, 41);
            this.tbfistName.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.Location = new System.Drawing.Point(548, 71);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(167, 48);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_2);
            // 
            // cbSelect
            // 
            this.cbSelect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(233, 71);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(195, 43);
            this.cbSelect.TabIndex = 0;
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
            this.tabUpdateEmployee.ResumeLayout(false);
            this.tabUpdateEmployee.PerformLayout();
            this.ResumeLayout(false);

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
        private Button button1;
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
    }
}