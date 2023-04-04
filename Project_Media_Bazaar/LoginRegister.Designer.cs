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
            tabControlLoginRegister.SuspendLayout();
            login_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlLoginRegister
            // 
            tabControlLoginRegister.Alignment = TabAlignment.Left;
            tabControlLoginRegister.Controls.Add(login_tab);
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
            login_tab.Controls.Add(tbPassword);
            login_tab.Controls.Add(tbLogin);
            login_tab.Controls.Add(loginemaillbl);
            login_tab.Controls.Add(loginpasswordlbl);
            login_tab.Controls.Add(bLogin);
            login_tab.Controls.Add(login_lbl);
            login_tab.Location = new Point(27, 4);
            login_tab.Name = "login_tab";
            login_tab.Padding = new Padding(3, 3, 3, 3);
            login_tab.Size = new Size(745, 432);
            login_tab.TabIndex = 0;
            login_tab.Text = "Log In";
            login_tab.Click += login_tab_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.Location = new Point(172, 237);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(401, 34);
            tbPassword.TabIndex = 19;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            tbLogin.Location = new Point(172, 164);
            tbLogin.Margin = new Padding(3, 2, 3, 2);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(401, 34);
            tbLogin.TabIndex = 16;
            // 
            // loginemaillbl
            // 
            loginemaillbl.AutoSize = true;
            loginemaillbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            loginemaillbl.Location = new Point(172, 125);
            loginemaillbl.Name = "loginemaillbl";
            loginemaillbl.Size = new Size(138, 28);
            loginemaillbl.TabIndex = 17;
            loginemaillbl.Text = "Email Adress:";
            // 
            // loginpasswordlbl
            // 
            loginpasswordlbl.AutoSize = true;
            loginpasswordlbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            loginpasswordlbl.Location = new Point(172, 198);
            loginpasswordlbl.Name = "loginpasswordlbl";
            loginpasswordlbl.Size = new Size(106, 28);
            loginpasswordlbl.TabIndex = 18;
            loginpasswordlbl.Text = "Password:";
            // 
            // bLogin
            // 
            bLogin.BackColor = Color.White;
            bLogin.Cursor = Cursors.Hand;
            bLogin.FlatStyle = FlatStyle.Flat;
            bLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            bLogin.Location = new Point(172, 302);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(401, 43);
            bLogin.TabIndex = 15;
            bLogin.Text = "Log In";
            bLogin.UseVisualStyleBackColor = false;
            bLogin.Click += bLogin_Click;
            // 
            // login_lbl
            // 
            login_lbl.AutoSize = true;
            login_lbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            login_lbl.Location = new Point(317, 51);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(119, 46);
            login_lbl.TabIndex = 1;
            login_lbl.Text = "Log in";
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
    }
}