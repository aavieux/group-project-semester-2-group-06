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
            btnEmployeeShiftsView = new Button();
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
            this.tabDashboard.Controls.Add(this.search_lbl);
            this.tabDashboard.Controls.Add(this.bLogout);
            this.tabDashboard.Controls.Add(this.tbF);
            this.tabDashboard.Controls.Add(this.listBoxEmployees);
            this.tabDashboard.Location = new System.Drawing.Point(30, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabDashboard.Size = new System.Drawing.Size(995, 491);
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
            this.bLogout.Location = new System.Drawing.Point(862, 17);
            this.bLogout.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(126, 80);
            this.bLogout.TabIndex = 6;
            this.bLogout.Text = "Log out";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // tbF
            // 
            this.tbF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbF.Location = new System.Drawing.Point(7, 79);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(415, 41);
            this.tbF.TabIndex = 1;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 35;
            this.listBoxEmployees.Location = new System.Drawing.Point(7, 129);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(980, 319);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // tabCreateEmployee
            // 
            this.tabCreateEmployee.Controls.Add(this.tbWorkingHours);
            this.tabCreateEmployee.Controls.Add(this.cbRole);
            this.tabCreateEmployee.Controls.Add(this.label10);
            this.tabCreateEmployee.Controls.Add(this.label9);
            this.tabCreateEmployee.Controls.Add(this.gbCredentials);
            this.tabCreateEmployee.Controls.Add(this.gpPersonalData);
            this.tabCreateEmployee.Controls.Add(this.btnCreate);
            this.tabCreateEmployee.Location = new System.Drawing.Point(30, 4);
            this.tabCreateEmployee.Name = "tabCreateEmployee";
            this.tabCreateEmployee.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabCreateEmployee.Size = new System.Drawing.Size(995, 491);
            this.tabCreateEmployee.TabIndex = 1;
            this.tabCreateEmployee.Text = "CreateEmployee";
            this.tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // tbWorkingHours
            // 
            this.tbWorkingHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWorkingHours.Location = new System.Drawing.Point(192, 227);
            this.tbWorkingHours.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbWorkingHours.Name = "tbWorkingHours";
            this.tbWorkingHours.Size = new System.Drawing.Size(164, 34);
            this.tbWorkingHours.TabIndex = 17;
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "JuniorSales",
            "SeniorSales",
            "FloorManager"});
            this.cbRole.Location = new System.Drawing.Point(192, 268);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(164, 36);
            this.cbRole.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(34, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 28);
            this.label10.TabIndex = 25;
            this.label10.Text = "Role:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(34, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Working Hours:";
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
            gbCredentials.Size = new Size(328, 282);
            gbCredentials.TabIndex = 23;
            gbCredentials.TabStop = false;
            gbCredentials.Text = "Credentials";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nickname:";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(187, 99);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(164, 34);
            this.tbpassword.TabIndex = 7;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(187, 152);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(164, 34);
            this.tbemail.TabIndex = 21;
            // 
            // tbnickname
            // 
            this.tbnickname.Location = new System.Drawing.Point(187, 51);
            this.tbnickname.Name = "tbnickname";
            this.tbnickname.Size = new System.Drawing.Size(164, 34);
            this.tbnickname.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password:";
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
            gpPersonalData.Size = new Size(527, 279);
            gpPersonalData.TabIndex = 22;
            gpPersonalData.TabStop = false;
            gpPersonalData.Text = "Personal Data";
            // 
            // tbfirstName
            // 
            this.tbfirstName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbfirstName.Location = new System.Drawing.Point(191, 24);
            this.tbfirstName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbfirstName.Name = "tbfirstName";
            this.tbfirstName.Size = new System.Drawing.Size(263, 36);
            this.tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            this.tblastName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblastName.Location = new System.Drawing.Point(191, 69);
            this.tblastName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tblastName.Name = "tblastName";
            this.tblastName.Size = new System.Drawing.Size(263, 36);
            this.tblastName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFirstName.Location = new System.Drawing.Point(19, 24);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(122, 30);
            this.lbFirstName.TabIndex = 8;
            this.lbFirstName.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last Name:";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBirthDate.Location = new System.Drawing.Point(191, 113);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(263, 36);
            this.dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAdress.Location = new System.Drawing.Point(191, 161);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(263, 36);
            this.tbAdress.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPhoneNumber.Location = new System.Drawing.Point(191, 205);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(263, 36);
            this.tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            this.tbsalary.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbsalary.Location = new System.Drawing.Point(191, 249);
            this.tbsalary.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(263, 36);
            this.tbsalary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Of Birth:";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.White;
            btnCreate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Green;
            btnCreate.Location = new Point(8, 288);
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
            // btnEmployeeShiftsView
            // 
            btnEmployeeShiftsView.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeeShiftsView.Location = new Point(15, 308);
            btnEmployeeShiftsView.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeShiftsView.Name = "btnEmployeeShiftsView";
            btnEmployeeShiftsView.Size = new Size(402, 45);
            btnEmployeeShiftsView.TabIndex = 19;
            btnEmployeeShiftsView.Text = "View employee shifts";
            btnEmployeeShiftsView.UseVisualStyleBackColor = true;
            btnEmployeeShiftsView.Click += btnEmployeeShiftsView_Click;
            // 
            // selectedEmployees_lbl
            // 
            this.selectedEmployees_lbl.AutoSize = true;
            this.selectedEmployees_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedEmployees_lbl.Location = new System.Drawing.Point(746, 7);
            this.selectedEmployees_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedEmployees_lbl.Name = "selectedEmployees_lbl";
            this.selectedEmployees_lbl.Size = new System.Drawing.Size(235, 35);
            this.selectedEmployees_lbl.TabIndex = 18;
            this.selectedEmployees_lbl.Text = "Selected Employees";
            // 
            // selectFromEmployees_lbl
            // 
            this.selectFromEmployees_lbl.AutoSize = true;
            this.selectFromEmployees_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectFromEmployees_lbl.Location = new System.Drawing.Point(481, 7);
            this.selectFromEmployees_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectFromEmployees_lbl.Name = "selectFromEmployees_lbl";
            this.selectFromEmployees_lbl.Size = new System.Drawing.Size(272, 35);
            this.selectFromEmployees_lbl.TabIndex = 17;
            this.selectFromEmployees_lbl.Text = "Select From Employees";
            // 
            // selectedEmployees_clb
            // 
            this.selectedEmployees_clb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectedEmployees_clb.FormattingEnabled = true;
            this.selectedEmployees_clb.ItemHeight = 28;
            this.selectedEmployees_clb.Location = new System.Drawing.Point(746, 47);
            this.selectedEmployees_clb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectedEmployees_clb.Name = "selectedEmployees_clb";
            this.selectedEmployees_clb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedEmployees_clb.Size = new System.Drawing.Size(244, 368);
            this.selectedEmployees_clb.TabIndex = 16;
            // 
            // selectEmployees_clb
            // 
            this.selectEmployees_clb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectEmployees_clb.FormattingEnabled = true;
            this.selectEmployees_clb.ItemHeight = 28;
            this.selectEmployees_clb.Location = new System.Drawing.Point(482, 47);
            this.selectEmployees_clb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.selectEmployees_clb.Name = "selectEmployees_clb";
            this.selectEmployees_clb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectEmployees_clb.Size = new System.Drawing.Size(243, 368);
            this.selectEmployees_clb.TabIndex = 15;
            // 
            // remove_btn
            // 
            remove_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            remove_btn.ForeColor = Color.Firebrick;
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
            select_btn.ForeColor = SystemColors.Highlight;
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
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(54, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 37);
            this.label14.TabIndex = 10;
            this.label14.Text = "Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(56, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 37);
            this.label13.TabIndex = 9;
            this.label13.Text = "Shift:";
            // 
            // btnShift
            // 
            btnShift.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnShift.ForeColor = Color.Green;
            btnShift.Location = new Point(15, 255);
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
            this.dtDateShift.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDateShift.Location = new System.Drawing.Point(166, 197);
            this.dtDateShift.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtDateShift.Name = "dtDateShift";
            this.dtDateShift.Size = new System.Drawing.Size(258, 43);
            this.dtDateShift.TabIndex = 5;
            // 
            // cbShifts
            // 
            this.cbShifts.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbShifts.FormattingEnabled = true;
            this.cbShifts.Location = new System.Drawing.Point(166, 129);
            this.cbShifts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbShifts.Name = "cbShifts";
            this.cbShifts.Size = new System.Drawing.Size(258, 45);
            this.cbShifts.TabIndex = 4;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 525);
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