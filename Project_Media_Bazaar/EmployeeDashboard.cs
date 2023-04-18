﻿using Microsoft.VisualBasic.ApplicationServices;
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
        LoginRegister loginRegister;
        DataAccessEmployeeDashboard DataAccessEmployeeDashboard;
        Person currentPerson;
        List<Employee> employees;
        public EmployeeDashboard(Person person)
        {
            currentPerson = person;
            InitializeComponent();
            this.Text = $"Logged as: {currentPerson.firstName + " " + currentPerson.lastName}";

            this.DataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
            employees = this.DataAccessEmployeeDashboard.GetAllUsersFromDB();

            foreach (Employee employee in employees)
            {
                cbSelect.Items.Add(employee.GetIdAndFirstAndLastName());
                cbEmployeesShifts.Items.Add(employee.GetIdAndFirstAndLastName());
            }
            cbRole.DataSource = Enum.GetValues(typeof(EmployeeRole));
            cbShifts.DataSource = Enum.GetValues(typeof(ShiftType));

            LoadData();
        }
        public void LoadData()
        {
            listBoxEmployees.Items.Clear();
            List<Employee> users = DataAccessEmployeeDashboard.GetAllUsersFromDB();
            foreach (Employee employee in users)
            {
                listBoxEmployees.Items.Add(employee.GetIdAndFirstAndLastName());
            }
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cbSelect.Text);
            Employee newUser = DataAccessEmployeeDashboard.GetItemFromDB(id);
            tbfistName.Text = newUser.firstName;
            tbphone.Text = newUser.phoneNumber;

        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            tbfirstName.Clear();
            tbphone.Clear();
            string[] parts = cbSelect.SelectedItem.ToString().Split(new string[] { " || " }, StringSplitOptions.None);
            string secondPart = parts[1];
            secondPart.Replace("Id: ", "");

            Employee employee = DataAccessEmployeeDashboard.GetItemFromDB(int.Parse(secondPart));

            employee.firstName = tbfirstName.Text;
            employee.phoneNumber = tbphone.Text;


            DataAccessEmployeeDashboard.UpdateEmployeeToDB(employee);

            MessageBox.Show("Done!");
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
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
                    if (DataAccessEmployeeDashboard.AddItemToDB(employee))
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
            LoadData();
            //tbRoleType deleted
        }

        private void btnDelete_Click_2(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(tbIdDelete.Text);
                DataAccessEmployeeDashboard.DeleteItemFromDB(id);
                MessageBox.Show("Succesfully deleted item");
                LoadData();
            }
            catch (Exception) { }
            LoadData();
        }

        private void btnFilter_Click_2(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbF.Text);
                if (DataAccessEmployeeDashboard.GetItemFromDB(id) != null)
                {
                    Employee newUser = DataAccessEmployeeDashboard.GetItemFromDB(id);
                    listBoxEmployees.Items.Clear();
                    listBoxEmployees.Items.Add(newUser.GetFirstAndLastName());

                }
                else
                    LoadData();
            }
            catch (Exception) { }
        }

        private void btnSelect_Click_2(object sender, EventArgs e)
        {
            //string[] parts = cbSelect.SelectedItem.ToString().Split(new string[] { " || " }, StringSplitOptions.None);
            //string secondPart = parts[1];
            //string[] subParts = secondPart.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int secondId = int.Parse(subParts[0]);
            List<Employee> employees = DataAccessEmployeeDashboard.GetAllUsersFromDB();
            int secondId = 0;
            foreach (Employee item in employees)
            {
                if (item.GetIdAndFirstAndLastName().ToString().Contains(cbSelect.SelectedItem.ToString()))
                {
                    secondId = item.id;
                }
            }


            Employee employee = DataAccessEmployeeDashboard.GetItemFromDB(secondId);

            tbfistName.Text = $"{employee.firstName} {employee.lastName}";
            tbphone.Text = employee.phoneNumber;
        }

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            List<Employee> employees = DataAccessEmployeeDashboard.GetAllUsersFromDB();
            int secondId = 0;
            foreach (Employee item in employees)
            {
                if (item.GetIdAndFirstAndLastName().ToString().Contains(cbSelect.SelectedItem.ToString()))
                {
                    secondId = item.id;

                    item.SetName(tbfistName.Text);
                    item.SetPhone(tbphone.Text);
                    DataAccessEmployeeDashboard.UpdateEmployeeToDB(item);
                }
            }

        }



        private void btnSelectEmployeeToShift_Click(object sender, EventArgs e)
        {
            //string[] parts = cbSelect.SelectedItem.ToString().Split(new string[] { " || " }, StringSplitOptions.None);
            //string secondPart = parts[1];
            //string[] subParts = secondPart.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int secondId = int.Parse(subParts[0]);
            List<Employee> employees = DataAccessEmployeeDashboard.GetAllUsersFromDB();
            int secondId = 0;
            foreach (Employee item in employees)
            {
                if (item.GetIdAndFirstAndLastName().ToString().Contains(cbEmployeesShifts.SelectedItem.ToString()))
                {
                    secondId = item.id;
                }
            }


            Employee employee = DataAccessEmployeeDashboard.GetItemFromDB(secondId);

            tbNameEmShift.Text = $"{employee.firstName} {employee.lastName}";
            tbphoneShift.Text = employee.phoneNumber;
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            List<Employee> employees = DataAccessEmployeeDashboard.GetAllUsersFromDB();
            int secondId = 0;
            foreach (Employee item in employees)
            {
                if (item.GetIdAndFirstAndLastName().ToString().Contains(cbEmployeesShifts.SelectedItem.ToString()))
                {
                    secondId = item.id;
                }
            }

            string selectedValueString = cbEmployeesShifts.ToString();
            ShiftType shiftType = ShiftType.DayShift;
            DateTime dateOfShift = dtDateShift.Value;
            Shift shift = new Shift(shiftType, dateOfShift, secondId);
            DataAccessEmployeeDashboard.AssignEmployeeToShiftToDB(shift);
            MessageBox.Show("Done!");

        }

        private void listBoxEmployees_DoubleClick(object sender, EventArgs e)
        {
            var chosenEmployee = employees[listBoxEmployees.SelectedIndex];
            UpdateEmployee updateEmployee = new UpdateEmployee(chosenEmployee, this);
            updateEmployee.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginRegister = new LoginRegister();
            this.Hide();
            loginRegister.ShowDialog();
        }
    }
}
