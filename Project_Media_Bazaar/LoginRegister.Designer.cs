namespace Project_Media_Bazaar
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
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            loginemaillbl = new Label();
            loginpasswordlbl = new Label();
            bLogin = new Button();
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
            tabControlLoginRegister.Location = new Point(17, 20);
            tabControlLoginRegister.Margin = new Padding(4, 5, 4, 5);
            tabControlLoginRegister.Multiline = true;
            tabControlLoginRegister.Name = "tabControlLoginRegister";
            tabControlLoginRegister.SelectedIndex = 0;
            tabControlLoginRegister.Size = new Size(1109, 733);
            tabControlLoginRegister.TabIndex = 0;
            // 
            // login_tab
            // 
            login_tab.BackColor = Color.Transparent;
            login_tab.Controls.Add(tbPassword);
            login_tab.Controls.Add(tbLogin);
            login_tab.Controls.Add(loginemaillbl);
            login_tab.Controls.Add(loginpasswordlbl);
            login_tab.Controls.Add(bLogin);
            login_tab.Controls.Add(login_lbl);
            login_tab.Location = new Point(34, 4);
            login_tab.Margin = new Padding(4, 5, 4, 5);
            login_tab.Name = "login_tab";
            login_tab.Padding = new Padding(4, 5, 4, 5);
            login_tab.Size = new Size(1071, 725);
            login_tab.TabIndex = 0;
            login_tab.Text = "Log In";
            login_tab.Click += login_tab_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.Location = new Point(246, 395);
            tbPassword.Margin = new Padding(4, 3, 4, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(571, 47);
            tbPassword.TabIndex = 19;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            tbLogin.Location = new Point(246, 273);
            tbLogin.Margin = new Padding(4, 3, 4, 3);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(571, 47);
            tbLogin.TabIndex = 16;
            // 
            // loginemaillbl
            // 
            loginemaillbl.AutoSize = true;
            loginemaillbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            loginemaillbl.Location = new Point(246, 208);
            loginemaillbl.Margin = new Padding(4, 0, 4, 0);
            loginemaillbl.Name = "loginemaillbl";
            loginemaillbl.Size = new Size(205, 41);
            loginemaillbl.TabIndex = 17;
            loginemaillbl.Text = "Email Adress:";
            // 
            // loginpasswordlbl
            // 
            loginpasswordlbl.AutoSize = true;
            loginpasswordlbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            loginpasswordlbl.Location = new Point(246, 330);
            loginpasswordlbl.Margin = new Padding(4, 0, 4, 0);
            loginpasswordlbl.Name = "loginpasswordlbl";
            loginpasswordlbl.Size = new Size(158, 41);
            loginpasswordlbl.TabIndex = 18;
            loginpasswordlbl.Text = "Password:";
            // 
            // bLogin
            // 
            bLogin.BackColor = Color.White;
            bLogin.Cursor = Cursors.Hand;
            bLogin.FlatStyle = FlatStyle.Flat;
            bLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            bLogin.Location = new Point(246, 503);
            bLogin.Margin = new Padding(4, 5, 4, 5);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(573, 72);
            bLogin.TabIndex = 15;
            bLogin.Text = "Log In";
            bLogin.UseVisualStyleBackColor = false;
            bLogin.Click += bLogin_Click;
            // 
            // login_lbl
            // 
            login_lbl.AutoSize = true;
            login_lbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            login_lbl.Location = new Point(453, 85);
            login_lbl.Margin = new Padding(4, 0, 4, 0);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(175, 67);
            login_lbl.TabIndex = 1;
            login_lbl.Text = "Log in";
            // 
            // register_tab
            // 
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
            register_tab.Location = new Point(34, 4);
            register_tab.Margin = new Padding(4, 5, 4, 5);
            register_tab.Name = "register_tab";
            register_tab.Padding = new Padding(4, 5, 4, 5);
            register_tab.Size = new Size(1071, 725);
            register_tab.TabIndex = 1;
            register_tab.Text = "Register";
            register_tab.UseVisualStyleBackColor = true;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordlbl.Location = new Point(246, 487);
            passwordlbl.Margin = new Padding(4, 0, 4, 0);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(106, 28);
            passwordlbl.TabIndex = 39;
            passwordlbl.Text = "Password:";
            // 
            // emailadresslbl
            // 
            emailadresslbl.AutoSize = true;
            emailadresslbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailadresslbl.Location = new Point(246, 373);
            emailadresslbl.Margin = new Padding(4, 0, 4, 0);
            emailadresslbl.Name = "emailadresslbl";
            emailadresslbl.Size = new Size(138, 28);
            emailadresslbl.TabIndex = 38;
            emailadresslbl.Text = "Email Adress:";
            // 
            // phonenumberlbl
            // 
            phonenumberlbl.AutoSize = true;
            phonenumberlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phonenumberlbl.Location = new Point(246, 242);
            phonenumberlbl.Margin = new Padding(4, 0, 4, 0);
            phonenumberlbl.Name = "phonenumberlbl";
            phonenumberlbl.Size = new Size(160, 28);
            phonenumberlbl.TabIndex = 37;
            phonenumberlbl.Text = "Phone Number:";
            // 
            // fullnamelbl
            // 
            fullnamelbl.AutoSize = true;
            fullnamelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullnamelbl.Location = new Point(246, 123);
            fullnamelbl.Margin = new Padding(4, 0, 4, 0);
            fullnamelbl.Name = "fullnamelbl";
            fullnamelbl.Size = new Size(113, 28);
            fullnamelbl.TabIndex = 36;
            fullnamelbl.Text = "Full Name:";
            // 
            // passwordtxt
            // 
            passwordtxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordtxt.Location = new Point(246, 522);
            passwordtxt.Margin = new Padding(4, 3, 4, 3);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(571, 33);
            passwordtxt.TabIndex = 35;
            // 
            // emailadresstxt
            // 
            emailadresstxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailadresstxt.Location = new Point(246, 408);
            emailadresstxt.Margin = new Padding(4, 3, 4, 3);
            emailadresstxt.Name = "emailadresstxt";
            emailadresstxt.Size = new Size(571, 33);
            emailadresstxt.TabIndex = 34;
            // 
            // phonenumbertxt
            // 
            phonenumbertxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phonenumbertxt.Location = new Point(246, 282);
            phonenumbertxt.Margin = new Padding(4, 3, 4, 3);
            phonenumbertxt.Name = "phonenumbertxt";
            phonenumbertxt.Size = new Size(571, 33);
            phonenumbertxt.TabIndex = 33;
            // 
            // fullnametxt
            // 
            fullnametxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullnametxt.Location = new Point(246, 158);
            fullnametxt.Margin = new Padding(4, 3, 4, 3);
            fullnametxt.Name = "fullnametxt";
            fullnametxt.Size = new Size(571, 33);
            fullnametxt.TabIndex = 32;
            // 
            // registerbtn
            // 
            registerbtn.FlatStyle = FlatStyle.Popup;
            registerbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            registerbtn.Location = new Point(246, 593);
            registerbtn.Margin = new Padding(4, 5, 4, 5);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(573, 68);
            registerbtn.TabIndex = 31;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // crateanaccount_lbl
            // 
            crateanaccount_lbl.AutoSize = true;
            crateanaccount_lbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            crateanaccount_lbl.Location = new Point(319, 23);
            crateanaccount_lbl.Margin = new Padding(4, 0, 4, 0);
            crateanaccount_lbl.Name = "crateanaccount_lbl";
            crateanaccount_lbl.Size = new Size(450, 67);
            crateanaccount_lbl.TabIndex = 30;
            crateanaccount_lbl.Text = "Create an account";
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 773);
            Controls.Add(tabControlLoginRegister);
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label loginemaillbl;
        private Label loginpasswordlbl;
        private Button bLogin;
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