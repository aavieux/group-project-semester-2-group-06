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
			lbphone = new Label();
			lbName = new Label();
			tbPhone = new TextBox();
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
			tbPassword = new TextBox();
			tbNickname = new TextBox();
			label5 = new Label();
			label6 = new Label();
			tbWorkingHours = new TextBox();
			label7 = new Label();
			SuspendLayout();
			// 
			// lbphone
			// 
			lbphone.AutoSize = true;
			lbphone.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			lbphone.Location = new Point(66, 80);
			lbphone.Name = "lbphone";
			lbphone.Size = new Size(156, 28);
			lbphone.TabIndex = 11;
			lbphone.Text = "Phone number:";
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			lbName.Location = new Point(116, 46);
			lbName.Name = "lbName";
			lbName.Size = new Size(113, 28);
			lbName.TabIndex = 10;
			lbName.Text = "Last name:";
			// 
			// tbPhone
			// 
			tbPhone.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbPhone.Location = new Point(244, 80);
			tbPhone.Margin = new Padding(3, 2, 3, 2);
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(196, 34);
			tbPhone.TabIndex = 9;
			// 
			// tbLastName
			// 
			tbLastName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbLastName.Location = new Point(244, 44);
			tbLastName.Margin = new Padding(3, 2, 3, 2);
			tbLastName.Name = "tbLastName";
			tbLastName.Size = new Size(196, 34);
			tbLastName.TabIndex = 8;
			// 
			// btnSave
			// 
			btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btnSave.Location = new Point(445, 9);
			btnSave.Margin = new Padding(3, 2, 3, 2);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(244, 313);
			btnSave.TabIndex = 12;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// tbFirstName
			// 
			tbFirstName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbFirstName.Location = new Point(244, 9);
			tbFirstName.Margin = new Padding(3, 2, 3, 2);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.Size = new Size(196, 34);
			tbFirstName.TabIndex = 13;
			// 
			// tbAddress
			// 
			tbAddress.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbAddress.Location = new Point(244, 115);
			tbAddress.Margin = new Padding(3, 2, 3, 2);
			tbAddress.Name = "tbAddress";
			tbAddress.Size = new Size(196, 34);
			tbAddress.TabIndex = 14;
			// 
			// tbSalary
			// 
			tbSalary.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbSalary.Location = new Point(244, 150);
			tbSalary.Margin = new Padding(3, 2, 3, 2);
			tbSalary.Name = "tbSalary";
			tbSalary.Size = new Size(196, 34);
			tbSalary.TabIndex = 15;
			// 
			// tbEmail
			// 
			tbEmail.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbEmail.Location = new Point(244, 185);
			tbEmail.Margin = new Padding(3, 2, 3, 2);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(196, 34);
			tbEmail.TabIndex = 16;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(165, 185);
			label1.Name = "label1";
			label1.Size = new Size(69, 28);
			label1.TabIndex = 17;
			label1.Text = "Email:";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(158, 152);
			label2.Name = "label2";
			label2.Size = new Size(76, 28);
			label2.TabIndex = 18;
			label2.Text = "Salary:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(137, 117);
			label3.Name = "label3";
			label3.Size = new Size(92, 28);
			label3.TabIndex = 19;
			label3.Text = "Address:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(112, 11);
			label4.Name = "label4";
			label4.Size = new Size(116, 28);
			label4.TabIndex = 20;
			label4.Text = "First name:";
			// 
			// tbPassword
			// 
			tbPassword.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbPassword.Location = new Point(244, 256);
			tbPassword.Margin = new Padding(3, 2, 3, 2);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(196, 34);
			tbPassword.TabIndex = 21;
			// 
			// tbNickname
			// 
			tbNickname.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbNickname.Location = new Point(244, 220);
			tbNickname.Margin = new Padding(3, 2, 3, 2);
			tbNickname.Name = "tbNickname";
			tbNickname.Size = new Size(196, 34);
			tbNickname.TabIndex = 22;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(116, 223);
			label5.Name = "label5";
			label5.Size = new Size(112, 28);
			label5.TabIndex = 23;
			label5.Text = "Nickname:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(124, 258);
			label6.Name = "label6";
			label6.Size = new Size(106, 28);
			label6.TabIndex = 24;
			label6.Text = "Password:";
			// 
			// tbWorkingHours
			// 
			tbWorkingHours.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			tbWorkingHours.Location = new Point(244, 291);
			tbWorkingHours.Margin = new Padding(3, 2, 3, 2);
			tbWorkingHours.Name = "tbWorkingHours";
			tbWorkingHours.Size = new Size(196, 34);
			tbWorkingHours.TabIndex = 25;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(68, 293);
			label7.Name = "label7";
			label7.Size = new Size(156, 28);
			label7.TabIndex = 26;
			label7.Text = "Working hours:";
			// 
			// UpdateEmployee
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 338);
			Controls.Add(label7);
			Controls.Add(tbWorkingHours);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(tbNickname);
			Controls.Add(tbPassword);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbEmail);
			Controls.Add(tbSalary);
			Controls.Add(tbAddress);
			Controls.Add(tbFirstName);
			Controls.Add(btnSave);
			Controls.Add(lbphone);
			Controls.Add(lbName);
			Controls.Add(tbPhone);
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
	}
}