using Microsoft.AspNetCore.Identity;
using ContactBook.Models;

namespace ContactBook.Seeders;

public static class UserSeeder
{
    public static async Task SeedAsync(UserManager<AppUser> userManager)
    {
        await CreateUserIfNotExists(userManager, 
            email: "admin@app.com",
            password: "admin123",
            role: "Admin");

        await CreateUserIfNotExists(userManager,
            email: "viewer@app.com",
            password: "viewer123",
            role: "Viewer");
    }

    private static async Task CreateUserIfNotExists(
        UserManager<AppUser> userManager,
        string email,
        string password,
        string role)
    {
        var existingUser = await userManager.FindByEmailAsync(email);

        if (existingUser is not null)
        {
            return;
        }

        var user = new AppUser
        {
            UserName = email,
            Email = email,
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(user, password);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, role);
        }
    }
}