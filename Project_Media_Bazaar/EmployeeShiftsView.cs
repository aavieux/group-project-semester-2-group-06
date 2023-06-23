using DataManagement;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Media_Bazaar
{
    public partial class EmployeeShiftsView : Form
    {
        DataAccessEmployeeDashboard dataAccessEmployeeDashboard;
        public EmployeeShiftsView()
        {
            InitializeComponent();

            dataAccessEmployeeDashboard = new DataAccessEmployeeDashboard(
                "Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            ShiftForm shiftForm = new ShiftForm(selectedDate);
            shiftForm.Show();
        }

        private void btnEmployeeShiftsView_Click(object sender, EventArgs e)
        {
            EmployeeShiftsView employeeShiftsView = new EmployeeShiftsView();
            employeeShiftsView.ShowDialog();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //string searchInput = comboBox1.Text;
            //comboBox1.DataSource = dataAccessEmployeeDashboard.GetEmployeesFromDB();
            //// Filter the data source based on the search input
            //List<string> filteredValues = comboBox1.DataSource
            //    .Where(value => value.StartsWith(searchInput, StringComparison.OrdinalIgnoreCase))
            //    .ToList();

            //comboBox1.DataSource = filteredValues;

            //// Show the drop-down list
            //comboBox1.DroppedDown = true;
        }

        private void EmployeeShiftsView_Load(object sender, EventArgs e)
        {

        }
    }
}
