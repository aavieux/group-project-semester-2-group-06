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
    public partial class AssignShiftAutomatic : Form
    {
        DataAccessEmployeeDashboard DataAccessEmployeeDashboard;
        Random random;
        public AssignShiftAutomatic()
        {
            
            InitializeComponent();
            this.DataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
        }

        private void btnAssignTheShift_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // Get a random date within the following week
            DateTime currentDate = DateTime.Now;
            DateTime nextWeek = currentDate.AddDays(7);

            List<Employee> employees = DataAccessEmployeeDashboard.GetAllUsersFromDB();
            List<Shift> shifts = new List<Shift>();

            // Shuffle the employees randomly
            employees = employees.OrderBy(e => random.Next()).ToList();

            // Iterate through the available shifts
            for (DateTime date = currentDate; date < nextWeek; date = date.AddDays(1))
            {
                // Get a random shift type for each day (assuming "DayShift" and "NightShift" are valid ShiftType values)
                ShiftType[] shiftTypes = { ShiftType.DayShift, ShiftType.NightShift };
                ShiftType randomShiftType = shiftTypes[random.Next(shiftTypes.Length)];

                // Assign shifts to employees
                if (employees.Count > 0)
                {
                    
                    Employee employee = employees[0];
                    Shift shift = new Shift(randomShiftType, date, employee.id);
                    shifts.Add(shift);
                    employees.RemoveAt(0);
                }
            }

            // Assign shifts to employees based on availability and constraints
            foreach (Shift shift in shifts)
            {
                DataAccessEmployeeDashboard.AssignEmployeeToShiftToDB(shift);
                foreach (var item in shifts)
                {
                    lbShifts.Items.Add($"{shift.date} - {shift.emplId} - {shift.shiftType}");
                }
               
                // Update any relevant data or UI to reflect the shift assignment
            }

            MessageBox.Show("Shifts assigned successfully!");

        }
    }
    }
