using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace WebApp.Pages;

[Authorize]
public class ProfileModel : PageModel
{
    public Employee CurrentEmployee { get; set; }
    Administration administration = new Administration();

    public void OnGet()
    {
        CurrentEmployee = administration.GetEmployeeById(Convert.ToInt32(User.FindFirst("id").Value));
    }
}
