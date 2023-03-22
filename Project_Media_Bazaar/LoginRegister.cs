using Domain;
using Project_Media_Bazaar;
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
            //database.check by email and password
            
            // VVVVVVVVVV
            // Person person = new Person(//database data);

            if (Person.roleType == manager)
            {
                this.Hide();
                ManagementForm managementForm = new ManagementForm(person);
                managementForm.Show();
            }
            else if (Person.roletype == employee)
            {
                this.Hide();
                UserForm userFOrm = new UserForm(person);
                userFOrm.Show();
            }
            
            this.Close();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string name = fullnametxt.Text;
            //    string email = emailadresstxt.Text;
            //    string phone = phonenumbertxt.Text;
            //    string password = passwordtxt.Text;
            //    bool exists = false;

            //    if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(password))
            //    {
            //        Management management = new Management();
            //    }
            //    else
            //    {
            //        ClearFields();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        private void OpenUser(Object user)
        {

        }
    }
}