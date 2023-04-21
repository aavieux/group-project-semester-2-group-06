namespace Project_Media_Bazaar
{
    partial class UpdateEmployee
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
			lbName = new Label();
			tbLastName = new TextBox();
			btnSave = new Button();
			tbFirstName = new TextBox();
			tbAddress = new TextBox();
			tbSalary = new TextBox();
			tbEmail = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			tbWorkingHours = new TextBox();
			label7 = new Label();
			delete_btn = new Button();
			update_btn = new Button();
			birthdate_lbl = new Label();
			birthDate_dtp = new DateTimePicker();
			lbphone = new Label();
			tbPhone = new TextBox();
			SuspendLayout();
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbphone.Location = new System.Drawing.Point(76, 106);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(197, 35);
            this.lbphone.TabIndex = 11;
            this.lbphone.Text = "Phone number:";
            // 
            // lbName
            // 
			lbName.AutoSize = true;
			lbName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			lbName.Location = new Point(111, 44);
			lbName.Name = "lbName";
			lbName.Size = new Size(113, 28);
			lbName.TabIndex = 10;
			lbName.Text = "Last name:";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPhone.Location = new System.Drawing.Point(279, 106);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(223, 41);
            this.tbPhone.TabIndex = 9;
            // 
            // tbLastName
            // 
			tbLastName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbLastName.Location = new Point(244, 49);
			tbLastName.Margin = new Padding(3, 2, 3, 2);
			tbLastName.Name = "tbLastName";
			tbLastName.Size = new Size(196, 34);
			tbLastName.TabIndex = 8;
            // 
            // btnSave
            // 
			btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btnSave.Location = new Point(444, 9);
			btnSave.Margin = new Padding(3, 2, 3, 2);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(244, 97);
			btnSave.TabIndex = 12;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
            // 
            // tbFirstName
            // 
			tbFirstName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbFirstName.Location = new Point(244, 11);
			tbFirstName.Margin = new Padding(3, 2, 3, 2);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.Size = new Size(196, 34);
			tbFirstName.TabIndex = 13;
            // 
            // tbAddress
            // 
			tbAddress.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbAddress.Location = new Point(244, 165);
			tbAddress.Margin = new Padding(3, 2, 3, 2);
			tbAddress.Name = "tbAddress";
			tbAddress.Size = new Size(196, 34);
			tbAddress.TabIndex = 14;
            // 
            // tbSalary
            // 
			tbSalary.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbSalary.Location = new Point(244, 200);
			tbSalary.Margin = new Padding(3, 2, 3, 2);
			tbSalary.Name = "tbSalary";
			tbSalary.Size = new Size(196, 34);
			tbSalary.TabIndex = 15;
            // 
            // tbEmail
            // 
			tbEmail.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbEmail.Location = new Point(244, 235);
			tbEmail.Margin = new Padding(3, 2, 3, 2);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(196, 34);
			tbEmail.TabIndex = 16;
            // 
            // label1
            // 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(153, 235);
			label1.Name = "label1";
			label1.Size = new Size(69, 28);
			label1.TabIndex = 17;
			label1.Text = "Email:";
            // 
            // label2
            // 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(146, 203);
			label2.Name = "label2";
			label2.Size = new Size(76, 28);
			label2.TabIndex = 18;
			label2.Text = "Salary:";
            // 
            // label3
            // 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(130, 168);
			label3.Name = "label3";
			label3.Size = new Size(92, 28);
			label3.TabIndex = 19;
			label3.Text = "Address:";
            // 
            // label4
            // 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(111, 9);
			label4.Name = "label4";
			label4.Size = new Size(116, 28);
			label4.TabIndex = 20;
			label4.Text = "First name:";
			// 
			// tbWorkingHours
            // 
			tbWorkingHours.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbWorkingHours.Location = new Point(244, 273);
			tbWorkingHours.Margin = new Padding(3, 2, 3, 2);
			tbWorkingHours.Name = "tbWorkingHours";
			tbWorkingHours.Size = new Size(196, 34);
			tbWorkingHours.TabIndex = 25;
            // 
			// label7
            // 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(66, 273);
			label7.Name = "label7";
			label7.Size = new Size(156, 28);
			label7.TabIndex = 26;
			label7.Text = "Working hours:";
            // 
			// delete_btn
            // 
			delete_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			delete_btn.Location = new Point(446, 242);
			delete_btn.Name = "delete_btn";
			delete_btn.Size = new Size(244, 83);
			delete_btn.TabIndex = 27;
			delete_btn.Text = "Delete";
			delete_btn.UseVisualStyleBackColor = true;
			delete_btn.Click += delete_btn_Click;
            // 
			// update_btn
            // 
			update_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			update_btn.Location = new Point(444, 9);
			update_btn.Margin = new Padding(3, 2, 3, 2);
			update_btn.Name = "update_btn";
			update_btn.Size = new Size(244, 97);
			update_btn.TabIndex = 28;
			update_btn.Text = "Update";
			update_btn.UseVisualStyleBackColor = true;
			update_btn.Click += update_btn_Click;
            // 
			// birthdate_lbl
            // 
			birthdate_lbl.AutoSize = true;
			birthdate_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			birthdate_lbl.Location = new Point(100, 126);
			birthdate_lbl.Name = "birthdate_lbl";
			birthdate_lbl.Size = new Size(122, 28);
			birthdate_lbl.TabIndex = 29;
			birthdate_lbl.Text = "Birth Date :";
            // 
			// birthDate_dtp
			// 
			birthDate_dtp.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			birthDate_dtp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			birthDate_dtp.Location = new Point(244, 126);
			birthDate_dtp.Name = "birthDate_dtp";
			birthDate_dtp.Size = new Size(196, 34);
			birthDate_dtp.TabIndex = 30;
			// 
			// lbphone
			// 
			lbphone.AutoSize = true;
			lbphone.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			lbphone.Location = new Point(66, 87);
			lbphone.Name = "lbphone";
			lbphone.Size = new Size(156, 28);
			lbphone.TabIndex = 32;
			lbphone.Text = "Phone number:";
            // 
			// tbPhone
            // 
			tbPhone.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbPhone.Location = new Point(244, 87);
			tbPhone.Margin = new Padding(3, 2, 3, 2);
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(196, 34);
			tbPhone.TabIndex = 31;
            // 
            // UpdateEmployee
            // 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 338);
			Controls.Add(lbphone);
			Controls.Add(tbPhone);
			Controls.Add(birthDate_dtp);
			Controls.Add(birthdate_lbl);
			Controls.Add(update_btn);
			Controls.Add(delete_btn);
			Controls.Add(label7);
			Controls.Add(tbWorkingHours);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbEmail);
			Controls.Add(tbSalary);
			Controls.Add(tbAddress);
			Controls.Add(tbFirstName);
			Controls.Add(btnSave);
			Controls.Add(lbName);
			Controls.Add(tbLastName);
			Margin = new Padding(3, 2, 3, 2);
			Name = "UpdateEmployee";
			Text = "UpdateEmployee";
			Load += UpdateEmployee_Load;
			ResumeLayout(false);
			PerformLayout();
        }

        #endregion

        private Label lbphone;
        private Label lbName;
        private TextBox tbPhone;
        private TextBox tbLastName;
        private Button btnSave;
        private TextBox tbFirstName;
        private TextBox tbAddress;
        private TextBox tbSalary;
        private TextBox tbEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbPassword;
        private TextBox tbNickname;
        private Label label5;
        private Label label6;
        private TextBox tbWorkingHours;
        private Label label7;
		private Button delete_btn;
		private Button update_btn;
		private Label birthdate_lbl;
		private DateTimePicker birthDate_dtp;
		private Label lbphone;
		private TextBox tbPhone;
    }
}