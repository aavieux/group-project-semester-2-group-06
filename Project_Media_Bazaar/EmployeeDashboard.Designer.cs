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
            tbIdDelete = new TextBox();
            btnDelete = new Button();
            btnView = new Button();
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
            tbRoleType = new TextBox();
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
            tabControl1.Location = new Point(24, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(853, 345);
            tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(tbIdDelete);
            tabDashboard.Controls.Add(btnDelete);
            tabDashboard.Controls.Add(btnView);
            tabDashboard.Controls.Add(btnFilter);
            tabDashboard.Controls.Add(tbF);
            tabDashboard.Controls.Add(listBoxEmployees);
            tabDashboard.Location = new Point(27, 4);
            tabDashboard.Margin = new Padding(3, 2, 3, 2);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3, 2, 3, 2);
            tabDashboard.Size = new Size(822, 337);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tbIdDelete
            // 
            tbIdDelete.Location = new Point(5, 30);
            tbIdDelete.Margin = new Padding(3, 2, 3, 2);
            tbIdDelete.Name = "tbIdDelete";
            tbIdDelete.Size = new Size(83, 23);
            tbIdDelete.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(108, 28);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 22);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(725, 62);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(82, 22);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Coral;
            btnFilter.Location = new Point(108, 62);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(78, 22);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // tbF
            // 
            tbF.Location = new Point(5, 62);
            tbF.Margin = new Padding(3, 2, 3, 2);
            tbF.Name = "tbF";
            tbF.Size = new Size(83, 23);
            tbF.TabIndex = 1;
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 15;
            listBoxEmployees.Location = new Point(5, 97);
            listBoxEmployees.Margin = new Padding(3, 2, 3, 2);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(803, 229);
            listBoxEmployees.TabIndex = 0;
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
            tabCreateEmployee.Size = new Size(822, 337);
            tabCreateEmployee.TabIndex = 1;
            tabCreateEmployee.Text = "CreateEmployee";
            tabCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 237);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 25;
            label10.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 195);
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
            gbCredentials.Location = new Point(5, 7);
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
            gpPersonalData.Controls.Add(tbfirstName);
            gpPersonalData.Controls.Add(tblastName);
            gpPersonalData.Controls.Add(lbFirstName);
            gpPersonalData.Controls.Add(label1);
            gpPersonalData.Controls.Add(dtBirthDate);
            gpPersonalData.Controls.Add(tbAdress);
            gpPersonalData.Controls.Add(tbRoleType);
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
            // tbfirstName
            // 
            tbfirstName.Location = new Point(203, 20);
            tbfirstName.Margin = new Padding(3, 2, 3, 2);
            tbfirstName.Name = "tbfirstName";
            tbfirstName.Size = new Size(110, 23);
            tbfirstName.TabIndex = 0;
            // 
            // tblastName
            // 
            tblastName.Location = new Point(203, 56);
            tblastName.Margin = new Padding(3, 2, 3, 2);
            tblastName.Name = "tblastName";
            tblastName.Size = new Size(110, 23);
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
            dtBirthDate.Size = new Size(205, 23);
            dtBirthDate.TabIndex = 2;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(203, 138);
            tbAdress.Margin = new Padding(3, 2, 3, 2);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(110, 23);
            tbAdress.TabIndex = 3;
            // 
            // tbRoleType
            // 
            tbRoleType.Location = new Point(203, 248);
            tbRoleType.Margin = new Padding(3, 2, 3, 2);
            tbRoleType.Name = "tbRoleType";
            tbRoleType.Size = new Size(110, 23);
            tbRoleType.TabIndex = 16;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(203, 177);
            tbPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(110, 23);
            tbPhoneNumber.TabIndex = 4;
            // 
            // tbsalary
            // 
            tbsalary.Location = new Point(203, 215);
            tbsalary.Margin = new Padding(3, 2, 3, 2);
            tbsalary.Name = "tbsalary";
            tbsalary.Size = new Size(110, 23);
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
            btnCreate.Click += btnCreate_Click;
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
            tabShift.Location = new Point(27, 4);
            tabShift.Margin = new Padding(3, 2, 3, 2);
            tabShift.Name = "tabShift";
            tabShift.Size = new Size(822, 337);
            tabShift.TabIndex = 2;
            tabShift.Text = "Assign Shift";
            tabShift.UseVisualStyleBackColor = true;
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
            tabUpdateEmployee.Location = new Point(27, 4);
            tabUpdateEmployee.Margin = new Padding(3, 2, 3, 2);
            tabUpdateEmployee.Name = "tabUpdateEmployee";
            tabUpdateEmployee.Size = new Size(822, 337);
            tabUpdateEmployee.TabIndex = 3;
            tabUpdateEmployee.Text = "UpdateEmployee";
            tabUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(105, 202);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbphone
            // 
            lbphone.AutoSize = true;
            lbphone.Location = new Point(16, 142);
            lbphone.Name = "lbphone";
            lbphone.Size = new Size(89, 15);
            lbphone.TabIndex = 5;
            lbphone.Text = "Phone number:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(16, 82);
            lbName.Name = "lbName";
            lbName.Size = new Size(42, 15);
            lbName.TabIndex = 4;
            lbName.Text = "Name:";
            // 
            // tbphone
            // 
            tbphone.Location = new Point(128, 140);
            tbphone.Margin = new Padding(3, 2, 3, 2);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(110, 23);
            tbphone.TabIndex = 3;
            // 
            // tbfistName
            // 
            tbfistName.Location = new Point(128, 82);
            tbfistName.Margin = new Padding(3, 2, 3, 2);
            tbfistName.Name = "tbfistName";
            tbfistName.Size = new Size(110, 23);
            tbfistName.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(183, 22);
            btnSelect.Margin = new Padding(3, 2, 3, 2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(82, 22);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // cbSelect
            // 
            cbSelect.FormattingEnabled = true;
            cbSelect.Location = new Point(39, 22);
            cbSelect.Margin = new Padding(3, 2, 3, 2);
            cbSelect.Name = "cbSelect";
            cbSelect.Size = new Size(100, 23);
            cbSelect.TabIndex = 0;
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
        private TextBox tbRoleType;
        private ComboBox cbRole;
        private TextBox tbemail;
        private Button btnView;
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
    }
}