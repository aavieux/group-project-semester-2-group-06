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
            bLogout = new Button();
            tbIdDelete = new TextBox();
            btnDelete = new Button();
            btnFilter = new Button();
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
            tabUpdateEmployee = new TabPage();
            btnSave = new Button();
            lbphone = new Label();
            lbName = new Label();
            tbphone = new TextBox();
            tbfistName = new TextBox();
            btnSelect = new Button();
            cbSelect = new ComboBox();
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
            tabControl1.Controls.Add(tabUpdateEmployee);
            tabControl1.Location = new Point(34, 15);
            tabControl1.Margin = new Padding(4, 4, 4, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1240, 575);
            tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(bLogout);
            tabDashboard.Controls.Add(tbIdDelete);
            tabDashboard.Controls.Add(btnDelete);
            tabDashboard.Controls.Add(btnFilter);
            tabDashboard.Controls.Add(tbF);
            tabDashboard.Controls.Add(listBoxEmployees);
            tabDashboard.Location = new Point(34, 4);
            tabDashboard.Margin = new Padding(4, 4, 4, 4);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(4, 4, 4, 4);
            tabDashboard.Size = new Size(1202, 567);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // bLogout
            // 
            bLogout.Location = new Point(1054, 19);
            bLogout.Margin = new Padding(4, 4, 4, 4);
            bLogout.Name = "bLogout";
            bLogout.Size = new Size(118, 36);
            bLogout.TabIndex = 6;
            bLogout.Text = "Log out";
            bLogout.UseVisualStyleBackColor = true;
            bLogout.Click += button1_Click;
            // 
            // tbIdDelete
            // 
            tbIdDelete.Location = new Point(11, 44);
            tbIdDelete.Margin = new Padding(4, 4, 4, 4);
            tbIdDelete.Name = "tbIdDelete";
            tbIdDelete.Size = new Size(330, 31);
            tbIdDelete.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(351, 44);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
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
            btnFilter.Margin = new Padding(4, 4, 4, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 36);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click_2;
            // 
            // tbF
            // 
            tbF.Location = new Point(11, 96);
            tbF.Margin = new Padding(4, 4, 4, 4);
            tbF.Name = "tbF";
            tbF.Size = new Size(330, 31);
            tbF.TabIndex = 1;
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 41;
            listBoxEmployees.Location = new Point(8, 161);
            listBoxEmployees.Margin = new Padding(4, 4, 4, 4);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(1145, 332);
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
            tabCreateEmployee.Location = new Point(64, 4);
            tabCreateEmployee.Margin = new Padding(4, 4, 4, 4);
            tabCreateEmployee.Name = "tabCreateEmployee";
            tabCreateEmployee.Padding = new Padding(4, 4, 4, 4);
            tabCreateEmployee.Size = new Size(1172, 567);
            tabCreateEmployee.TabIndex = 1;
            tabCreateEmployee.Text = "CreateEmployee";
            tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 395);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 25);
            label10.TabIndex = 25;
            label10.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 325);
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
            gbCredentials.Location = new Point(8, 11);
            gbCredentials.Margin = new Padding(4, 4, 4, 4);
            gbCredentials.Name = "gbCredentials";
            gbCredentials.Padding = new Padding(4, 4, 4, 4);
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
            tbpassword.Margin = new Padding(4, 4, 4, 4);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(155, 31);
            tbpassword.TabIndex = 7;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(286, 186);
            tbemail.Margin = new Padding(4, 4, 4, 4);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(155, 31);
            tbemail.TabIndex = 21;
            // 
            // tbnickname
            // 
            tbnickname.Location = new Point(286, 64);
            tbnickname.Margin = new Padding(4, 4, 4, 4);
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
            gpPersonalData.Margin = new Padding(4, 4, 4, 4);
            gpPersonalData.Name = "gpPersonalData";
            gpPersonalData.Padding = new Padding(4, 4, 4, 4);
            gpPersonalData.Size = new Size(636, 546);
            gpPersonalData.TabIndex = 22;
            gpPersonalData.TabStop = false;
            gpPersonalData.Text = "Personal Data";
            // 
            // tbfirstName
            // 
            tbfirstName.Location = new Point(290, 34);
            tbfirstName.Margin = new Padding(4, 4, 4, 4);
            tbfirstName.Name = "tbfirstName";
            tbfirstName.Size = new Size(155, 31);
            tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            tblastName.Location = new Point(290, 94);
            tblastName.Margin = new Padding(4, 4, 4, 4);
            tblastName.Name = "tblastName";
            tblastName.Size = new Size(155, 31);
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
            dtBirthDate.Margin = new Padding(4, 4, 4, 4);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(292, 31);
            dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(290, 230);
            tbAdress.Margin = new Padding(4, 4, 4, 4);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(155, 31);
            tbAdress.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(290, 295);
            tbPhoneNumber.Margin = new Padding(4, 4, 4, 4);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(155, 31);
            tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            tbsalary.Location = new Point(290, 359);
            tbsalary.Margin = new Padding(4, 4, 4, 4);
            tbsalary.Name = "tbsalary";
            tbsalary.Size = new Size(155, 31);
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
            cbRole.Margin = new Padding(4, 4, 4, 4);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(188, 33);
            cbRole.TabIndex = 20;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkSeaGreen;
            btnCreate.Location = new Point(14, 464);
            btnCreate.Margin = new Padding(4, 4, 4, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(434, 95);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create Employee";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // tbWorkingHours
            // 
            tbWorkingHours.Location = new Point(260, 325);
            tbWorkingHours.Margin = new Padding(4, 4, 4, 4);
            tbWorkingHours.Name = "tbWorkingHours";
            tbWorkingHours.Size = new Size(188, 31);
            tbWorkingHours.TabIndex = 17;
            // 
            // tabShift
            // 
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
            tabShift.Location = new Point(64, 4);
            tabShift.Margin = new Padding(4, 4, 4, 4);
            tabShift.Name = "tabShift";
            tabShift.Size = new Size(1172, 567);
            tabShift.TabIndex = 2;
            tabShift.Text = "Assign Shift";
            tabShift.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(148, 318);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(53, 25);
            label14.TabIndex = 10;
            label14.Text = "Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(148, 260);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(52, 25);
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
            btnShift.Location = new Point(141, 436);
            btnShift.Margin = new Padding(4, 4, 4, 4);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(974, 94);
            btnShift.TabIndex = 6;
            btnShift.Text = "Assign Shift";
            btnShift.UseVisualStyleBackColor = true;
            btnShift.Click += btnShift_Click;
            // 
            // dtDateShift
            // 
            dtDateShift.Location = new Point(365, 318);
            dtDateShift.Margin = new Padding(4, 4, 4, 4);
            dtDateShift.Name = "dtDateShift";
            dtDateShift.Size = new Size(312, 31);
            dtDateShift.TabIndex = 5;
            // 
            // cbShifts
            // 
            cbShifts.FormattingEnabled = true;
            cbShifts.Location = new Point(365, 256);
            cbShifts.Margin = new Padding(4, 4, 4, 4);
            cbShifts.Name = "cbShifts";
            cbShifts.Size = new Size(188, 33);
            cbShifts.TabIndex = 4;
            // 
            // tbphoneShift
            // 
            tbphoneShift.Location = new Point(365, 199);
            tbphoneShift.Margin = new Padding(4, 4, 4, 4);
            tbphoneShift.Name = "tbphoneShift";
            tbphoneShift.Size = new Size(155, 31);
            tbphoneShift.TabIndex = 3;
            // 
            // tbNameEmShift
            // 
            tbNameEmShift.Location = new Point(365, 129);
            tbNameEmShift.Margin = new Padding(4, 4, 4, 4);
            tbNameEmShift.Name = "tbNameEmShift";
            tbNameEmShift.Size = new Size(155, 31);
            tbNameEmShift.TabIndex = 2;
            // 
            // btnSelectEmployeeToShift
            // 
            btnSelectEmployeeToShift.Location = new Point(365, 48);
            btnSelectEmployeeToShift.Margin = new Padding(4, 4, 4, 4);
            btnSelectEmployeeToShift.Name = "btnSelectEmployeeToShift";
            btnSelectEmployeeToShift.Size = new Size(118, 36);
            btnSelectEmployeeToShift.TabIndex = 1;
            btnSelectEmployeeToShift.Text = "Select";
            btnSelectEmployeeToShift.UseVisualStyleBackColor = true;
            btnSelectEmployeeToShift.Click += btnSelectEmployeeToShift_Click;
            // 
            // cbEmployeesShifts
            // 
            cbEmployeesShifts.FormattingEnabled = true;
            cbEmployeesShifts.Location = new Point(141, 48);
            cbEmployeesShifts.Margin = new Padding(4, 4, 4, 4);
            cbEmployeesShifts.Name = "cbEmployeesShifts";
            cbEmployeesShifts.Size = new Size(188, 33);
            cbEmployeesShifts.TabIndex = 0;
            // 
            // tabUpdateEmployee
            // 
            tabUpdateEmployee.Controls.Add(btnSave);
            tabUpdateEmployee.Controls.Add(lbphone);
            tabUpdateEmployee.Controls.Add(lbName);
            tabUpdateEmployee.Controls.Add(tbphone);
            tabUpdateEmployee.Controls.Add(tbfistName);
            tabUpdateEmployee.Controls.Add(btnSelect);
            tabUpdateEmployee.Controls.Add(cbSelect);
            tabUpdateEmployee.Location = new Point(64, 4);
            tabUpdateEmployee.Margin = new Padding(4, 4, 4, 4);
            tabUpdateEmployee.Name = "tabUpdateEmployee";
            tabUpdateEmployee.Size = new Size(1172, 567);
            tabUpdateEmployee.TabIndex = 3;
            tabUpdateEmployee.Text = "UpdateEmployee";
            tabUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(291, 420);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(602, 65);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_2;
            // 
            // lbphone
            // 
            lbphone.AutoSize = true;
            lbphone.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbphone.Location = new Point(291, 306);
            lbphone.Margin = new Padding(4, 0, 4, 0);
            lbphone.Name = "lbphone";
            lbphone.Size = new Size(233, 41);
            lbphone.TabIndex = 5;
            lbphone.Text = "Phone number:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(291, 205);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(109, 41);
            lbName.TabIndex = 4;
            lbName.Text = "Name:";
            // 
            // tbphone
            // 
            tbphone.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            tbphone.Location = new Point(615, 299);
            tbphone.Margin = new Padding(4, 4, 4, 4);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(278, 47);
            tbphone.TabIndex = 3;
            // 
            // tbfistName
            // 
            tbfistName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            tbfistName.Location = new Point(615, 205);
            tbfistName.Margin = new Padding(4, 4, 4, 4);
            tbfistName.Name = "tbfistName";
            tbfistName.Size = new Size(278, 47);
            tbfistName.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelect.Location = new Point(685, 89);
            btnSelect.Margin = new Padding(4, 4, 4, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(209, 60);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click_2;
            // 
            // cbSelect
            // 
            cbSelect.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            cbSelect.FormattingEnabled = true;
            cbSelect.Location = new Point(291, 89);
            cbSelect.Margin = new Padding(4, 4, 4, 4);
            cbSelect.Name = "cbSelect";
            cbSelect.Size = new Size(243, 49);
            cbSelect.TabIndex = 0;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 616);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 4, 4, 4);
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
    }
}