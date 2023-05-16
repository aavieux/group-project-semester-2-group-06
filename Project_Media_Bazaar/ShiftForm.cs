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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_Media_Bazaar
{
    public partial class ShiftForm : Form
    {
        DataAccessEmployeeDashboard dataacces = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
        private DateTime selectedDate;
        string formattedDate;
        List<Shift> shifts;
        public ShiftForm(DateTime date)
        {

            InitializeComponent();
            lbEmployeeShifts.Items.Clear();
           formattedDate  = date.ToString("dd/MM/yyyy");
            shifts = dataacces.GetAllShiftsFromDB();
          
               
            foreach (var shift in shifts)
            {
                if(shift.GetInfo().Contains(formattedDate)) {
                    lbEmployeeShifts.Items.Add(shift.GetInfo());
                }
            
                  

                
            }

        }

        private void ShiftForm_Load(object sender, EventArgs e)
        {
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
