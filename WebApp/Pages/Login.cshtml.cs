using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages;

public class LoginModel : PageModel
{
    public string PageTitle { get; private set; }
    [BindProperty]
    [Required]
    public string Username { get; set; }
    [BindProperty]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    private Employee Employee { get; set; }
    public bool KeepLogged { get; set; }
    Administration administration = new Administration();
    public void OnGet()
    {
        PageTitle = "Login";
    }
    public async Task<IActionResult> OnPost()
    {
        try
        {
            KeepLogged = true;
            this.Employee = administration.LogInEmployee(Username, Password);
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, Employee.email),
                    new Claim(ClaimTypes.NameIdentifier, $"{Employee.firstName} {Employee.lastName}"),
                    new Claim("id", Employee.id.ToString())
                };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);
            AuthenticationProperties properties = new AuthenticationProperties()
            {
                AllowRefresh = true,
                IsPersistent = KeepLogged,
            };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
            return new RedirectToPageResult("Profile");
        }
        catch (Exception ex)
        {
            ViewData["ValidateMessage"] = ex.Message;
            return Page();
        }
    }
}
