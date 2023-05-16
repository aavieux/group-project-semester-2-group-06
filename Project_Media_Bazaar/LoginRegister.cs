using Domain;
using Domain.Enums;
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

namespace Project_Media_Bazaar;

public partial class LoginRegister : Form
{
    Administration administration;
    public LoginRegister()
    {
        InitializeComponent();
        tabControlLoginRegister.SelectTab("login_tab");
        administration = new Administration();
    }
    private void DisplayError()
    {

    }
    private void ClearFields()
    {
        //Login fields
        tbPassword.Clear();
        tbLogin.Clear();
    }
    private void tabControlLoginRegister_Click(object sender, EventArgs e) //CreateAccountTAB
    {
        ClearFields();
    }

    private void bLogin_Click(object sender, EventArgs e)
    {
        if (administration.CheckLogIn(tbLogin.Text, tbPassword.Text) != null)
        {
            Person person = administration.CheckLogIn(tbLogin.Text, tbPassword.Text);

            if (person.userRole == UserRole.Manager)
            {
                this.Hide();
                ManagementForm managementForm = new ManagementForm(person, this);
                managementForm.ShowDialog();
                this.Show();

            }
            else if (person.userRole == UserRole.Administrator)
            {
                this.Hide();
                EmployeeDashboard employeeDashboard = new EmployeeDashboard(person, this);
                employeeDashboard.ShowDialog();
                this.Show();
            }
        }
        else
        {
            DisplayError();
        }
    }

    private void login_tab_Click(object sender, EventArgs e)
    {

    }
}