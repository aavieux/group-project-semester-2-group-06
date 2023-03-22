using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
            tabControlLoginRegister.SelectTab("login_tab");
            LoadLogInData();
        }
        private void LoadLogInData()
        {

        }
        private void ClearFields()
        {
            //Login fields
            loginpasswordtxt.Clear();
            loginemailtxt.Clear();
            //Register fields
            fullnametxt.Clear();
            emailadresstxt.Clear();
            passwordtxt.Clear();
            phonenumbertxt.Clear();
        }
        private void tabControlLoginRegister_Click(object sender, EventArgs e) //CreateAccountTAB
        {
            ClearFields();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //connectedUser connectedUser = new connectedUser();
            //connectedUser.ShowDialog();
            //open new tab
            this.Close();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = fullnametxt.Text;
                string email = emailadresstxt.Text;
                string phone = phonenumbertxt.Text;
                string password = passwordtxt.Text;
                bool exists = false;

                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(password))
                {

                }
                else
                {
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OpenUser(Object user)
        {

        }
    }
}