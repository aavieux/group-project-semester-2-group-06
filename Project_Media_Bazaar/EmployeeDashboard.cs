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
using Domain.Enums;

namespace Project_Media_Bazaar
{
    public partial class EmployeeDashboard : Form
    {
        DataAccessEmployeeDashboard DataAccessEmployeeDashboard;
        Person currentPerson;
        public EmployeeDashboard(Person person)
        {
            currentPerson = person;
            InitializeComponent();
            this.Text = $"Logged as: {currentPerson.firstName + " " + currentPerson.lastName}";

            this.DataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
            List<Employee> employees = this.DataAccessEmployeeDashboard.GetAllUsers();

            foreach (Employee employee in employees)
            {
                cbSelect.Items.Add(employee.GetIdAndName());
            }
            cbRole.DataSource = Enum.GetValues(typeof(EmployeeRole));

            LoadData();
        }
        private void LoadData()
        {
            listBoxEmployees.Items.Clear();
            List<Employee> users = DataAccessEmployeeDashboard.GetAllUsers();
            foreach (Employee employee in users)
            {
                listBoxEmployees.Items.Add(employee.GetIdAndName());
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
            decimal salary;
            string nickname = "";
            string password = "";
            int workingHours;

            UserRole role = new UserRole();

            // Validate email address
            if (!string.IsNullOrWhiteSpace(tbemail.Text) &&
                !string.IsNullOrWhiteSpace(tbfirstName.Text) &&
                !string.IsNullOrWhiteSpace(tblastName.Text) &&
                !string.IsNullOrWhiteSpace(tbAdress.Text) &&
                !string.IsNullOrWhiteSpace(tbPhoneNumber.Text) &&
                decimal.TryParse(tbsalary.Text, out salary) &&
                !string.IsNullOrWhiteSpace(tbnickname.Text) &&
                !string.IsNullOrWhiteSpace(tbpassword.Text) &&
                int.TryParse(tbWorkingHours.Text, out workingHours) &&
                cbRole.SelectedItem != null && cbRole.SelectedItem is EmployeeRole)
            {
                try
                {
                    firstName = tbfirstName.Text.Trim();
                    lastName = tblastName.Text.Trim();
                    address = tbAdress.Text.Trim();
                    phoneNumber = tbPhoneNumber.Text.Trim();
                    nickname = tbnickname.Text.Trim();
                    password = tbpassword.Text;
                    role = (UserRole)cbRole.SelectedItem;
                    EmployeeRole employeeRole = EmployeeRole.JuniorSales;
                    dateTime = dtBirthDate.Value;
                    salary = decimal.Parse(tbsalary.Text);
                    var mailAddress = new System.Net.Mail.MailAddress(tbemail.Text);
                    email = mailAddress.Address;

                    Employee employee = new Employee(email, workingHours, role, firstName, lastName, dateTime, address, phoneNumber, salary, nickname, password, employeeRole);
                    if (DataAccessEmployeeDashboard.AddItem(employee))
                    {
                        MessageBox.Show("Done!");
                    }
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error creating an employee!");
                }
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            

            tbfirstName.Text = "";
            tblastName.Text = "";
            tbAdress.Text = "";
            tbPhoneNumber.Text = "";
            tbnickname.Text = "";
            tbpassword.Text = "";
            cbRole.SelectedItem = -1;
            tbWorkingHours.Text = "";

            tbsalary.Text = "";
            tbemail.Text = "";

            //tbRoleType deleted
        }

        //private void btnView_Click(object sender, EventArgs e)
        //{
        //    listBoxEmployees.Items.Clear();
        //    var newUser = DataAccessEmployeeDashboard.GetAllUsers();
        //    foreach (var item in newUser)
        //    {
        //        listBoxEmployees.Items.Add(item.GetInfo());
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cbSelect.Text);
            Employee newUser = DataAccessEmployeeDashboard.GetItem(id);
            tbfistName.Text = newUser.firstName;
            tbphone.Text = newUser.phoneNumber;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = tbfistName.Text;
            string phoneNumber = tbphone.Text;


           //DataAccessEmployeeDashboard.UpdateItem(newUser);

        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            //string[] parts = cbSelect.SelectedItem.ToString().Split(new string[] { " || " }, StringSplitOptions.None);
            //string secondPart = parts[1];
            //string[] subParts = secondPart.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int secondId = int.Parse(subParts[0]);
            List<Employee> employees = DataAccessEmployeeDashboard.GetAllUsers();
            int secondId = 0;
            foreach (Employee item in employees)
            {
                if (item.GetIdAndName().ToString().Contains(cbSelect.SelectedItem.ToString()))
                {
                    secondId = item.id;
                }
            }


            Employee employee = DataAccessEmployeeDashboard.GetItem(secondId);

            tbfistName.Text = $"{employee.firstName} {employee.lastName}";
            tbphone.Text = employee.phoneNumber;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            tbfirstName.Clear();
            tbphone.Clear();
            string[] parts = cbSelect.SelectedItem.ToString().Split(new string[] { " || " }, StringSplitOptions.None);
            string secondPart = parts[1];
            secondPart.Replace("Id: ", "");

            Employee employee = DataAccessEmployeeDashboard.GetItem(int.Parse(secondPart));

            employee.firstName = tbfirstName.Text;
            employee.phoneNumber = tbphone.Text;


            DataAccessEmployeeDashboard.UpdateItem(employee);

            MessageBox.Show("Done!");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbIdDelete.Text);
                DataAccessEmployeeDashboard.DeleteItem(id);
                MessageBox.Show("Succesfully deleted item");
                LoadData();
            }
            catch (Exception) { }
            LoadData();
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbF.Text);
                if (DataAccessEmployeeDashboard.GetItem(id) != null)
                {
                    Employee newUser = DataAccessEmployeeDashboard.GetItem(id);
                    listBoxEmployees.Items.Clear();
                    listBoxEmployees.Items.Add(newUser.GetInfo());

                }
                else
                    LoadData();
            }
            catch (Exception) { }
        }
    }
}
