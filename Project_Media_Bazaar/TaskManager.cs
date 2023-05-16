using Domain.Enums;
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
    public partial class TaskManager : Form
    {
        DataAccessEmployeeDashboard DataAccessEmployeeDashboard;
        List<Employee> employees;
        public TaskManager()
        {
            this.DataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
            InitializeComponent();
            employees = this.DataAccessEmployeeDashboard.GetAllUsersFromDB();
            LoadData();
            var selectedValue = cbEmployeesShifts.SelectedValue;
            if (selectedValue != null)
            {
                if (selectedValue.ToString().Contains("Completed")) { progressBar1.Value = 100; }
                if (selectedValue.ToString().Contains("Working on")) { progressBar1.Value = 60; }
                if (selectedValue.ToString().Contains("In process")) { progressBar1.Value = 20; }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //TaskManager taskManager= new TaskManager();
            this.Close();
        }
        public void LoadData()
        {
            cbEmployeesShifts.Items.Clear();
            foreach (Employee employee in DataAccessEmployeeDashboard.GetAllUsersFromDB())
            {
                cbEmployeesShifts.Items.Add(employee.GetIdAndFirstAndLastName());
            }

        }
        private void btnShift_Click(object sender, EventArgs e)
        {
            int currentId = 0;
            string TaskDescription = richTextBox1.Text;
            string dateoftask = dtDateShift.Text;
            foreach (Employee employee in DataAccessEmployeeDashboard.GetEmployeesFromDB())
            {
                if (employee.GetFirstAndLastName() == cbEmployeesShifts.SelectedItem.ToString())
                {
                    currentId = employee.id;
                }
            }
            if (currentId != 0)
            {

                DataAccessEmployeeDashboard.AddTaskToEmployeeToDB(currentId, TaskDescription, dateoftask);
                //Shift shift = new Shift(Enum.Parse<ShiftType>(cbShifts.SelectedItem.ToString()), dtDateShift.Value, currentId);
                //DataAccessEmployeeDashboard.AssignEmployeeToShiftToDB(shift);
                MessageBox.Show("Done!");
                cbEmployeesShifts.SelectedIndex = -1;
                dtDateShift.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Could not find this user!");
            }
        }
    }
}
