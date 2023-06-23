using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp.Pages;

[Authorize]
public class StatisticModel : PageModel
{
    //public StatisticModel() 
    //{
    
    //}
    private DataAccessEmployeeDashboard data = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
    private List<Shift> Shifts { get; set; }

    [BindProperty]
    public int WorkedHoursMonth { get; set; }
    [BindProperty]
    public int WorkedHoursTotal { get; set; }

    public void OnGet()
    {
        Shifts = data.GetAllShiftsFromDB();
        var firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        foreach (Shift shift in Shifts)
        {
            if (shift.emplId == Convert.ToInt32(User.FindFirst("id").Value))
            {
                WorkedHoursTotal += 8;
            }
            if (shift.emplId == Convert.ToInt32(User.FindFirst("id").Value) && shift.date > firstDayOfMonth)
            {
                WorkedHoursMonth += 8;
            }
        }

    }
}