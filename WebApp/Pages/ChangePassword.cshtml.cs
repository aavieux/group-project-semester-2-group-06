using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace WebApp.Pages;

[Authorize]
public class ChangePasswordModel : PageModel
{
    [Required]
    [BindProperty]
    public string NewPassword { get; set; }
    public int UserId { get; set; }
    Administration administration = new Administration();
    public void OnGet()
    {
    }
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            administration.UpdateEmployeePassword(Convert.ToInt32(User.FindFirst("id").Value), NewPassword);
        }
        return new RedirectToPageResult("/PasswordChanged");
    }
}
