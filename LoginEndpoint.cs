using Microsoft.AspNetCore.Identity;
using ContactBook.Models;

namespace ContactBook;

public static class LoginEndpoint
{
    public static void MapLoginEndpoint(this WebApplication app)
    {
        app.MapPost("/account/login", async (
            HttpContext httpContext,
            SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager) =>
        {
            var form = await httpContext.Request.ReadFormAsync();
            var email = form["email"].ToString();
            var password = form["password"].ToString();
            var returnUrl = form["returnUrl"].ToString();

            var user = await userManager.FindByEmailAsync(email);

            if (user is null)
            {
                return Results.Redirect($"/login?error=true&returnUrl={returnUrl}");
            }

            var result = await signInManager.PasswordSignInAsync(
                user,
                password,
                isPersistent: true,
                lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return string.IsNullOrEmpty(returnUrl)
                    ? Results.Redirect("/")
                    : Results.Redirect(returnUrl);
            }

            return Results.Redirect($"/login?error=true&returnUrl={returnUrl}");
        });
    }
}