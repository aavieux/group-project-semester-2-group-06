using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace WebApp.Pages;

[Authorize]
public class ProfileModel : PageModel
{
    public void OnGet()
    {
        //CurrentUser = peopleMan.GetUserById(Convert.ToInt32(User.FindFirst("id").Value));
        //ViewData["Username"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
