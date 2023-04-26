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
    [Required]
    [BindProperty]
    public string NewPasswordConfirm { get; set; }
    [Required]
    [BindProperty]
    public string OldPassword { get; set; }

    public Employee Employee { get; set; }
    Administration administration = new Administration();
    public void OnGet()
    {
    }
    public IActionResult OnPost()
    {
        Employee = administration.GetEmployeeById(Convert.ToInt32(User.FindFirst("id").Value));
        if (ModelState.IsValid && NewPassword == NewPasswordConfirm && Employee.password == OldPassword)
        {
            administration.UpdateEmployeePassword(Employee.id, NewPassword);
            return new RedirectToPageResult("/PasswordChanged");
        }
        else if(Employee.password != OldPassword)
        {
            ViewData["ErrorMessage"] = "Wrong current password";
        }
        else if(NewPassword != NewPasswordConfirm)
        {
            ViewData["ErrorMessage"] = "Passwords don't match";
        }
        return Page();
    }
}
