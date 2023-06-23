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
            //try
            //{
            //    int cursorPosition = comboBox1.SelectionStart;
            //    string searchInput = comboBox1.Text;

            //    comboBox1.DroppedDown = true;


            //    comboBox1.Items.Clear();
            //    foreach (Employee employee in dataAccessEmployeeDashboard.GetAllUsersFromDB())
            //    {
            //        if (employee.GetFirstAndLastName().ToLower().Contains(searchInput.ToLower()))
            //        {
            //            comboBox1.Items.Add(employee.GetIdAndFirstAndLastName());
            //        }
            //    }
            //    comboBox1.SelectionStart = cursorPosition;
            //}
            //catch (Exception)
            //{

            //}

        }

        private void EmployeeShiftsView_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

            //foreach (Employee employee in dataAccessEmployeeDashboard.GetEmployeesFromDB())
            //{
            //    try
            //    {
            //        if (comboBox1.SelectedItem.ToString() == employee.GetIdAndFirstAndLastName().ToString())
            //        {
            //            MessageBox.Show("ok");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //    }
            //}

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

            string searchInput = search_txt.Text;
            listBox_search.Items.Clear();
            if (!string.IsNullOrEmpty(searchInput))
            {
                foreach (Employee employee in dataAccessEmployeeDashboard.GetAllUsersFromDB())
                {
                    if (employee.GetFirstAndLastName().ToLower().Contains(searchInput.ToLower()))
                    {
                        listBox_search.Items.Add(employee.GetIdAndFirstAndLastName());
                    }
                }
            }
            else
            {
                listBox_shifts.Items.Clear();
            }

        }

        private void listBox_search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (Employee employee in dataAccessEmployeeDashboard.GetAllUsersFromDB())
                {
                    if (employee.GetIdAndFirstAndLastName().ToString() == listBox_search.Text.ToString())
                    {
                        listBox_shifts.Items.Clear();
                        List<Shift> shiftsForEmpoyee = dataAccessEmployeeDashboard.GetShiftsForEmployee(employee.id);
                        if (shiftsForEmpoyee.Count != 0)
                        {
                            listBox_shifts.Items.Add($"Showing shifts for {employee.GetFirstAndLastName()}");
                            listBox_shifts.Items.Add($"-------------------------------------");
                            foreach (Shift shift in shiftsForEmpoyee)
                            {

                                listBox_shifts.Items.Add(shift.GetTypeAndDate());
                            }
                        }
                        else
                        {
                            listBox_shifts.Items.Add("No shifts found for this user!");
                        }

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void listBox_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
