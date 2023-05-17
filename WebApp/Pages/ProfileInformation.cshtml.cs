using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class ProfileInformationModel : PageModel
    {
        Administration administration = new Administration();
        public Employee CurrentEmployee { get; private set; }
        public void OnGet()
        {
            CurrentEmployee = administration.GetEmployeeById(Convert.ToInt32(User.FindFirst("id").Value));
        }
    }
}
