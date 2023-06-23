using Domain.Enums;
using Domain;
using System.Data;
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

            List<Employee> employees = DataAccessEmployeeDashboard.GetAllUsersFromDB();
            List<Shift> shifts = new List<Shift>();
            List<Shift> shiftsEmployee = new List<Shift>();

            // Shuffle the employees randomly
            employees = employees.OrderBy(e => random.Next()).ToList();

            if (startDate.Value > endDate.Value)
            {
                MessageBox.Show("You cannot pick a starting date to be after the end date!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                foreach (Employee employee in employees)
                {
                    // Iterate through the available shifts
                    for (DateTime date = startDate.Value; date <= endDate.Value; date = date.AddDays(1))
                    {
                        // Get a random shift type for each day (assuming "DayShift" and "NightShift" are valid ShiftType values)
                        ShiftType[] shiftTypes = { ShiftType.DayShift, ShiftType.NightShift };
                        ShiftType randomShiftType = shiftTypes[random.Next(shiftTypes.Length)];
                        // Assign shifts to employees
                        shiftsEmployee = DataAccessEmployeeDashboard.GetShiftsEmployeeToday(employee, date);
                        if (shiftsEmployee.Count == 0)
                        {
                            Shift shift = new Shift(randomShiftType, date, employee.id);
                            shifts.Add(shift);
                            break;
                        }
                    }
                }
                // Assign shifts to employees based on availability and constraints
                foreach (Shift shift in shifts)
                {
                    DataAccessEmployeeDashboard.AssignEmployeeToShiftToDB(shift);
                    lbShifts.Items.Add($"{shift.date} - {DataAccessEmployeeDashboard.GetEmployeeByIdFromDB(shift.emplId).GetFirstAndLastName()} - {shift.shiftType}");
                    // Update any relevant data or UI to reflect the shift assignment
                }
                MessageBox.Show("Shifts assigned successfully!");
                lbShifts.Show();
            }
        }
    }
}