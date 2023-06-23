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
    public partial class EmployeeShiftsView : Form
    {
        public EmployeeShiftsView()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
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
    }
}
