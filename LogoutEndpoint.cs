using Microsoft.AspNetCore.Identity;
using ContactBook.Models;
namespace ContactBook;

public static class LogoutEndpoint
{
    public static void MapLogoutEndpoint(this WebApplication app)
    {
        app.MapPost("/account/logout", async (
            SignInManager<AppUser> signInManager) =>
        {
            await signInManager.SignOutAsync();
            return Results.Redirect("/login");
        });
    }
}