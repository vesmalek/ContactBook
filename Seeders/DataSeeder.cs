using Microsoft.AspNetCore.Identity;
using ContactBook.Models;

namespace ContactBook.Seeders;

public static class DataSeeder
{
    public static async Task SeedAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider
            .GetRequiredService<RoleManager<IdentityRole>>();

        var userManager = serviceProvider
            .GetRequiredService<UserManager<AppUser>>();

        await RoleSeeder.SeedAsync(roleManager);
        await UserSeeder.SeedAsync(userManager);
        await ContactSeeder.SeedAsync(serviceProvider);
    }
}