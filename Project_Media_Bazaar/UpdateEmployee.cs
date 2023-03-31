using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Media_Bazaar
{
    public partial class UpdateEmployee : Form
    {
        DataAccessEmployeeDashboard dataAccessEmployeeDashboard;
        private Employee employee;
        public UpdateEmployee(Employee chosenEmployee)
        {
            this.dataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
            employee = chosenEmployee;
            InitializeComponent();
            tbFirstName.Text = employee.firstName;
            tbLastName.Text = employee.lastName;
            tbPhone.Text = employee.phoneNumber;
            tbEmail.Text=employee.email;
            tbAddress.Text = employee.address;
           tbSalary.Text = employee.salary.ToString();
            tbNickname.Text=employee.nickname;
            tbPassword.Text = employee.password;
            tbWorkingHours.Text = employee.workingHours.ToString();


        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
    
           
           
            tbWorkingHours.Text = employee.workingHours.ToString();
            employee.firstName=tbFirstName.Text; 
            employee.lastName=tbLastName.Text;  
            employee.phoneNumber=tbPassword.Text;
            employee.email=tbEmail.Text;
            employee.address = tbAddress.Text;
            employee.salary =decimal.Parse( tbSalary.Text);
            employee.nickname=tbNickname.Text;
            employee.password = tbPassword.Text;
            employee.workingHours = int.Parse(tbWorkingHours.Text);
            dataAccessEmployeeDashboard.UpdateItem(employee);
            MessageBox.Show("Updated");
          

            this.Close();



        }
    }
}
