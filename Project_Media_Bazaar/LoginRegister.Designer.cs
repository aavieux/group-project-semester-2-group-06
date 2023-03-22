namespace LoginRegister
{
    partial class LoginRegister
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
            tabControlLoginRegister = new TabControl();
            login_tab = new TabPage();
            loginpasswordtxt = new TextBox();
            loginemailtxt = new TextBox();
            loginemaillbl = new Label();
            loginpasswordlbl = new Label();
            loginbtn = new Button();
            login_lbl = new Label();
            register_tab = new TabPage();
            passwordlbl = new Label();
            emailadresslbl = new Label();
            phonenumberlbl = new Label();
            fullnamelbl = new Label();
            passwordtxt = new TextBox();
            emailadresstxt = new TextBox();
            phonenumbertxt = new TextBox();
            fullnametxt = new TextBox();
            registerbtn = new Button();
            crateanaccount_lbl = new Label();
            tabControlLoginRegister.SuspendLayout();
            login_tab.SuspendLayout();
            register_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlLoginRegister
            // 
            tabControlLoginRegister.Alignment = TabAlignment.Left;
            tabControlLoginRegister.Controls.Add(login_tab);
            tabControlLoginRegister.Controls.Add(register_tab);
            tabControlLoginRegister.Location = new Point(12, 12);
            tabControlLoginRegister.Multiline = true;
            tabControlLoginRegister.Name = "tabControlLoginRegister";
            tabControlLoginRegister.SelectedIndex = 0;
            tabControlLoginRegister.Size = new Size(776, 440);
            tabControlLoginRegister.TabIndex = 0;
            // 
            // login_tab
            // 
            login_tab.BackColor = Color.Transparent;
            //login_tab.BackgroundImage = Properties.Resources.istockphoto_540232822_612x612;
            login_tab.Controls.Add(loginpasswordtxt);
            login_tab.Controls.Add(loginemailtxt);
            login_tab.Controls.Add(loginemaillbl);
            login_tab.Controls.Add(loginpasswordlbl);
            login_tab.Controls.Add(loginbtn);
            login_tab.Controls.Add(login_lbl);
            login_tab.Location = new Point(27, 4);
            login_tab.Name = "login_tab";
            login_tab.Padding = new Padding(3);
            login_tab.Size = new Size(745, 432);
            login_tab.TabIndex = 0;
            login_tab.Text = "Log In";
            // 
            // loginpasswordtxt
            // 
            loginpasswordtxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginpasswordtxt.Location = new Point(167, 186);
            loginpasswordtxt.Margin = new Padding(3, 2, 3, 2);
            loginpasswordtxt.Name = "loginpasswordtxt";
            loginpasswordtxt.PasswordChar = '*';
            loginpasswordtxt.Size = new Size(401, 23);
            loginpasswordtxt.TabIndex = 19;
            // 
            // loginemailtxt
            // 
            loginemailtxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginemailtxt.Location = new Point(167, 122);
            loginemailtxt.Margin = new Padding(3, 2, 3, 2);
            loginemailtxt.Name = "loginemailtxt";
            loginemailtxt.Size = new Size(401, 23);
            loginemailtxt.TabIndex = 16;
            // 
            // loginemaillbl
            // 
            loginemaillbl.AutoSize = true;
            loginemaillbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginemaillbl.Location = new Point(167, 90);
            loginemaillbl.Name = "loginemaillbl";
            loginemaillbl.Size = new Size(98, 19);
            loginemaillbl.TabIndex = 17;
            loginemaillbl.Text = "Email Adress:";
            // 
            // loginpasswordlbl
            // 
            loginpasswordlbl.AutoSize = true;
            loginpasswordlbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginpasswordlbl.Location = new Point(167, 156);
            loginpasswordlbl.Name = "loginpasswordlbl";
            loginpasswordlbl.Size = new Size(77, 19);
            loginpasswordlbl.TabIndex = 18;
            loginpasswordlbl.Text = "Password:";
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.White;
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.Location = new Point(167, 238);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(401, 43);
            loginbtn.TabIndex = 15;
            loginbtn.Text = "Log In";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // login_lbl
            // 
            login_lbl.AutoSize = true;
            login_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            login_lbl.Location = new Point(321, 51);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(70, 28);
            login_lbl.TabIndex = 1;
            login_lbl.Text = "Log in";
            // 
            // register_tab
            // 
            //register_tab.BackgroundImage = Properties.Resources.istockphoto_540232822_612x612;
            register_tab.Controls.Add(passwordlbl);
            register_tab.Controls.Add(emailadresslbl);
            register_tab.Controls.Add(phonenumberlbl);
            register_tab.Controls.Add(fullnamelbl);
            register_tab.Controls.Add(passwordtxt);
            register_tab.Controls.Add(emailadresstxt);
            register_tab.Controls.Add(phonenumbertxt);
            register_tab.Controls.Add(fullnametxt);
            register_tab.Controls.Add(registerbtn);
            register_tab.Controls.Add(crateanaccount_lbl);
            register_tab.Location = new Point(27, 4);
            register_tab.Name = "register_tab";
            register_tab.Padding = new Padding(3);
            register_tab.Size = new Size(745, 432);
            register_tab.TabIndex = 1;
            register_tab.Text = "Register";
            register_tab.UseVisualStyleBackColor = true;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordlbl.Location = new Point(172, 292);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(70, 17);
            passwordlbl.TabIndex = 39;
            passwordlbl.Text = "Password:";
            // 
            // emailadresslbl
            // 
            emailadresslbl.AutoSize = true;
            emailadresslbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailadresslbl.Location = new Point(172, 224);
            emailadresslbl.Name = "emailadresslbl";
            emailadresslbl.Size = new Size(91, 17);
            emailadresslbl.TabIndex = 38;
            emailadresslbl.Text = "Email Adress:";
            // 
            // phonenumberlbl
            // 
            phonenumberlbl.AutoSize = true;
            phonenumberlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phonenumberlbl.Location = new Point(172, 145);
            phonenumberlbl.Name = "phonenumberlbl";
            phonenumberlbl.Size = new Size(106, 17);
            phonenumberlbl.TabIndex = 37;
            phonenumberlbl.Text = "Phone Number:";
            // 
            // fullnamelbl
            // 
            fullnamelbl.AutoSize = true;
            fullnamelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullnamelbl.Location = new Point(172, 74);
            fullnamelbl.Name = "fullnamelbl";
            fullnamelbl.Size = new Size(75, 17);
            fullnamelbl.TabIndex = 36;
            fullnamelbl.Text = "Full Name:";
            // 
            // passwordtxt
            // 
            passwordtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordtxt.Location = new Point(172, 313);
            passwordtxt.Margin = new Padding(3, 2, 3, 2);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(401, 25);
            passwordtxt.TabIndex = 35;
            // 
            // emailadresstxt
            // 
            emailadresstxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailadresstxt.Location = new Point(172, 245);
            emailadresstxt.Margin = new Padding(3, 2, 3, 2);
            emailadresstxt.Name = "emailadresstxt";
            emailadresstxt.Size = new Size(401, 25);
            emailadresstxt.TabIndex = 34;
            // 
            // phonenumbertxt
            // 
            phonenumbertxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phonenumbertxt.Location = new Point(172, 169);
            phonenumbertxt.Margin = new Padding(3, 2, 3, 2);
            phonenumbertxt.Name = "phonenumbertxt";
            phonenumbertxt.Size = new Size(401, 25);
            phonenumbertxt.TabIndex = 33;
            // 
            // fullnametxt
            // 
            fullnametxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullnametxt.Location = new Point(172, 95);
            fullnametxt.Margin = new Padding(3, 2, 3, 2);
            fullnametxt.Name = "fullnametxt";
            fullnametxt.Size = new Size(401, 25);
            fullnametxt.TabIndex = 32;
            // 
            // registerbtn
            // 
            registerbtn.FlatStyle = FlatStyle.Popup;
            registerbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            registerbtn.Location = new Point(172, 356);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(401, 41);
            registerbtn.TabIndex = 31;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // crateanaccount_lbl
            // 
            crateanaccount_lbl.AutoSize = true;
            crateanaccount_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            crateanaccount_lbl.Location = new Point(277, 39);
            crateanaccount_lbl.Name = "crateanaccount_lbl";
            crateanaccount_lbl.Size = new Size(183, 28);
            crateanaccount_lbl.TabIndex = 30;
            crateanaccount_lbl.Text = "Create an account";
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(tabControlLoginRegister);
            Name = "LoginRegister";
            Text = "LoginRegister";
            tabControlLoginRegister.ResumeLayout(false);
            login_tab.ResumeLayout(false);
            login_tab.PerformLayout();
            register_tab.ResumeLayout(false);
            register_tab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlLoginRegister;
        private TabPage login_tab;
        private TextBox loginpasswordtxt;
        private TextBox loginemailtxt;
        private Label loginemaillbl;
        private Label loginpasswordlbl;
        private Button loginbtn;
        private Label login_lbl;
        private TabPage register_tab;
        private Label passwordlbl;
        private Label emailadresslbl;
        private Label phonenumberlbl;
        private Label fullnamelbl;
        private TextBox passwordtxt;
        private TextBox emailadresstxt;
        private TextBox phonenumbertxt;
        private TextBox fullnametxt;
        private Button registerbtn;
        private Label crateanaccount_lbl;
    }
}