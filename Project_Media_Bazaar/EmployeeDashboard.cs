using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Media_Bazaar
{
    public partial class EmployeeDashboard : Form
    {
        DataAccessEmployeeDashboard DataAccessEmployeeDashboard;
        public EmployeeDashboard()
        {
            InitializeComponent();

            this.DataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
            cbRole.DataSource = Enum.GetValues(typeof(EmployeeRole));


            var user = DataAccessEmployeeDashboard.GetItems();
            foreach (var item in user)
            {
                cbSelect.
                Items.Add(item.Id());
            }
        }


        private async void btnCreate_Click(object sender, EventArgs e)
        {
            string email = "";
            string firstName = "";
            string lastName = "";
            DateTime dateTime;
            string address = "";
            string phoneNumber = "";
            double salary;
            string nickname = "";
            string password = "";
            int workingHours;
            EmployeeRole role = new EmployeeRole();

            // Validate email address
            if (!string.IsNullOrWhiteSpace(tbemail.Text))
            {
                try
                {
                    var mailAddress = new System.Net.Mail.MailAddress(tbemail.Text);
                    email = mailAddress.Address;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid email address");
                }
            }

            // Validate first name
            if (!string.IsNullOrWhiteSpace(tbfirstName.Text))
            {
                firstName = tbfirstName.Text.Trim();
            }
            else { MessageBox.Show("Invalid first name"); }

            // Validate last name
            if (!string.IsNullOrWhiteSpace(tblastName.Text))
            {
                lastName = tblastName.Text.Trim();
            }
            else { MessageBox.Show("Invalid last name"); }
            // Validate birth date
            if (DateTime.TryParse(dtBirthDate.Text, out dateTime))
            {
                MessageBox.Show("Invalid birth date");
                // Handle invalid date format
            }

            // Validate address
            if (!string.IsNullOrWhiteSpace(tbAdress.Text))
            {
                address = tbAdress.Text.Trim();
            }
            else { MessageBox.Show("Invalid address"); }

            // Validate phone number
            if (!string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
            {
                phoneNumber = tbPhoneNumber.Text.Trim();
            }
            else { MessageBox.Show("Invalid phone number"); }

            // Validate salary
            if (double.TryParse(tbsalary.Text, out salary))
            {
                MessageBox.Show("Invalid salary");
            }

            // Validate nickname
            if (!string.IsNullOrWhiteSpace(tbnickname.Text))
            {
                nickname = tbnickname.Text.Trim();
            }
            else { MessageBox.Show("Invalid nickname"); }
            // Validate password
            if (!string.IsNullOrWhiteSpace(tbpassword.Text))
            {
                password = tbpassword.Text;
            }
            else { MessageBox.Show("Invalid password"); }

            // Validate working hours
            if (int.TryParse(tbWorkingHours.Text, out workingHours))
            {
                MessageBox.Show("Invalid working hours");
                // Handle invalid working hours format
            }

            // Validate employee role
            if (cbRole.SelectedItem != null && cbRole.SelectedItem is EmployeeRole)
            {
                role = (EmployeeRole)cbRole.SelectedItem;
            }
            else
            {
                // Handle invalid employee role selection
            }



            Employee employee = new Employee(email, workingHours, role, firstName, lastName, dateTime, address, phoneNumber, salary, nickname, password);

            var newUser = DataAccessEmployeeDashboard.AddItem(employee);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listBoxEmployees.Items.Clear();
            var newUser = DataAccessEmployeeDashboard.GetItems();
            foreach (var item in newUser)
            {
                listBoxEmployees.Items.Add(item.GetEmployee());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBoxEmployees.Items.Clear();
            int id = int.Parse(tbIdDelete.Text);
            DataAccessEmployeeDashboard.DeleteItem(id);
            MessageBox.Show("Succesfully deleted item");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbF.Text);
            var newUser = DataAccessEmployeeDashboard.GetItem(id);

            listBoxEmployees.Items.Add(newUser.GetEmployee());


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cbSelect.Text);
            var newUser = DataAccessEmployeeDashboard.GetItem(id);
            tbfistName.Text = newUser.GetName();
            tbphone.Text = newUser.phoneNumber;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = tbfistName.Text;
            string phoneNumber = tbphone.Text;


            //DataAccessEmployeeDashboard.UpdateItem(newUser);
        }
    }
}
