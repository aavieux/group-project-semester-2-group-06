using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        [BindProperty]
        public DateTime StartDate { get; set; }
        [BindProperty]
        public DateTime FirstDayOfMonth { get; set; }
        [BindProperty]
        public DateTime LastDayOfMonth { get; set; }
        [BindProperty]
        public int NumberOfDays { get; set; }
        [BindProperty]
        public DateTime GetDate { get; set; }
        [BindProperty]
        public List<Shift> Shifts { get; set; }
        [BindProperty]
        public int EmployeeId { get; set; }
        [BindProperty]
        public string ChosenMonth { get; set; }
        public string CurrentMonth { get; set; }
        DataAccessEmployeeDashboard dataacces = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
        Company company = new Company();
        public void OnGet()
        {
            EmployeeId = Convert.ToInt32(User.FindFirst("id").Value);
            GetDate = DateTime.Now;
            CurrentMonth = GetDate.ToString("MMMM");
            FirstDayOfMonth = new DateTime(GetDate.Year, GetDate.Month, 1);
            LastDayOfMonth = FirstDayOfMonth.AddMonths(1).AddDays(-1);
            NumberOfDays = Convert.ToInt16(LastDayOfMonth.ToString("dd"));
            StartDate = FirstDayOfMonth.AddDays(-(int)FirstDayOfMonth.DayOfWeek);
            Shifts = dataacces.GetAllShiftsFromDB();
        }
        public void OnGetNextMonth()
        {
            OnGet();
            GetDate = GetDate.AddMonths(1);
            FirstDayOfMonth = new DateTime(GetDate.Year, GetDate.Month, 1);
            LastDayOfMonth = FirstDayOfMonth.AddMonths(1).AddDays(-1);
            NumberOfDays = Convert.ToInt16(LastDayOfMonth.ToString("dd"));
            StartDate = FirstDayOfMonth.AddDays(-(int)FirstDayOfMonth.DayOfWeek);
        }
        public void OnPost()
        {
            OnGet();
            GetDate = company.GetSpecificMonthDate(ChosenMonth);
            FirstDayOfMonth = new DateTime(GetDate.Year, GetDate.Month, 1);
            LastDayOfMonth = FirstDayOfMonth.AddMonths(1).AddDays(-1);
            NumberOfDays = Convert.ToInt16(LastDayOfMonth.ToString("dd"));
            StartDate = FirstDayOfMonth.AddDays(-(int)FirstDayOfMonth.DayOfWeek);
        }
    }
}
