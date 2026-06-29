using ContactBook.Data;
using ContactBook.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactBook.Seeders;

public static class ContactSeeder
{
    public static async Task SeedAsync(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<AppDbContext>();
        
        var contactsToSeed = new List<Contact>
        {
            new() { FirstName="John", LastName="Doe", Email="john.doe@example.com", PhoneNumber="0711000001", Company="Microsoft" },
            new() { FirstName="Jane", LastName="Smith", Email="jane.smith@example.com", PhoneNumber="0711000002", Company="Google" },
            new() { FirstName="Ahmed", LastName="Ali", Email="ahmed.ali@example.com", PhoneNumber="0711000003", Company="Amazon" },
            new() { FirstName="Fatima", LastName="Hassan", Email="fatima.hassan@example.com", PhoneNumber="0711000004", Company="Apple" },
            new() { FirstName="Michael", LastName="Brown", Email="michael.brown@example.com", PhoneNumber="0711000005", Company="Tesla" },
            new() { FirstName="Sarah", LastName="Wilson", Email="sarah.wilson@example.com", PhoneNumber="0711000006", Company="Meta" },
            new() { FirstName="David", LastName="Johnson", Email="david.johnson@example.com", PhoneNumber="0711000007", Company="Netflix" },
            new() { FirstName="Emily", LastName="Davis", Email="emily.davis@example.com", PhoneNumber="0711000008", Company="Spotify" },
            new() { FirstName="Daniel", LastName="Miller", Email="daniel.miller@example.com", PhoneNumber="0711000009", Company="Adobe" },
            new() { FirstName="Sophia", LastName="Taylor", Email="sophia.taylor@example.com", PhoneNumber="0711000010", Company="Oracle" },

            new() { FirstName="James", LastName="Anderson", Email="james.anderson@example.com", PhoneNumber="0711000011", Company="IBM" },
            new() { FirstName="Olivia", LastName="Thomas", Email="olivia.thomas@example.com", PhoneNumber="0711000012", Company="Intel" },
            new() { FirstName="William", LastName="Jackson", Email="william.jackson@example.com", PhoneNumber="0711000013", Company="Cisco" },
            new() { FirstName="Ava", LastName="White", Email="ava.white@example.com", PhoneNumber="0711000014", Company="Samsung" },
            new() { FirstName="Benjamin", LastName="Harris", Email="benjamin.harris@example.com", PhoneNumber="0711000015", Company="Sony" },
            new() { FirstName="Mia", LastName="Martin", Email="mia.martin@example.com", PhoneNumber="0711000016", Company="Dell" },
            new() { FirstName="Lucas", LastName="Thompson", Email="lucas.thompson@example.com", PhoneNumber="0711000017", Company="HP" },
            new() { FirstName="Charlotte", LastName="Garcia", Email="charlotte.garcia@example.com", PhoneNumber="0711000018", Company="Lenovo" },
            new() { FirstName="Henry", LastName="Martinez", Email="henry.martinez@example.com", PhoneNumber="0711000019", Company="Asus" },
            new() { FirstName="Amelia", LastName="Robinson", Email="amelia.robinson@example.com", PhoneNumber="0711000020", Company="Acer" },

            new() { FirstName="Alexander", LastName="Clark", Email="alexander.clark@example.com", PhoneNumber="0711000021", Company="Nvidia" },
            new() { FirstName="Harper", LastName="Rodriguez", Email="harper.rodriguez@example.com", PhoneNumber="0711000022", Company="AMD" },
            new() { FirstName="Ethan", LastName="Lewis", Email="ethan.lewis@example.com", PhoneNumber="0711000023", Company="Qualcomm" },
            new() { FirstName="Evelyn", LastName="Lee", Email="evelyn.lee@example.com", PhoneNumber="0711000024", Company="PayPal" },
            new() { FirstName="Jacob", LastName="Walker", Email="jacob.walker@example.com", PhoneNumber="0711000025", Company="Stripe" },
            new() { FirstName="Abigail", LastName="Hall", Email="abigail.hall@example.com", PhoneNumber="0711000026", Company="Uber" },
            new() { FirstName="Logan", LastName="Allen", Email="logan.allen@example.com", PhoneNumber="0711000027", Company="Airbnb" },
            new() { FirstName="Ella", LastName="Young", Email="ella.young@example.com", PhoneNumber="0711000028", Company="Zoom" },
            new() { FirstName="Sebastian", LastName="King", Email="sebastian.king@example.com", PhoneNumber="0711000029", Company="Slack" },
            new() { FirstName="Grace", LastName="Wright", Email="grace.wright@example.com", PhoneNumber="0711000030", Company="Dropbox" },

            new() { FirstName="Jack", LastName="Scott", Email="jack.scott@example.com", PhoneNumber="0711000031", Company="Shopify" },
            new() { FirstName="Chloe", LastName="Green", Email="chloe.green@example.com", PhoneNumber="0711000032", Company="Twilio" },
            new() { FirstName="Owen", LastName="Baker", Email="owen.baker@example.com", PhoneNumber="0711000033", Company="Atlassian" },
            new() { FirstName="Lily", LastName="Adams", Email="lily.adams@example.com", PhoneNumber="0711000034", Company="Salesforce" },
            new() { FirstName="Samuel", LastName="Nelson", Email="samuel.nelson@example.com", PhoneNumber="0711000035", Company="SAP" },
            new() { FirstName="Zoey", LastName="Carter", Email="zoey.carter@example.com", PhoneNumber="0711000036", Company="ServiceNow" },
            new() { FirstName="Matthew", LastName="Mitchell", Email="matthew.mitchell@example.com", PhoneNumber="0711000037", Company="Workday" },
            new() { FirstName="Nora", LastName="Perez", Email="nora.perez@example.com", PhoneNumber="0711000038", Company="Snowflake" },
            new() { FirstName="Joseph", LastName="Roberts", Email="joseph.roberts@example.com", PhoneNumber="0711000039", Company="Databricks" },
            new() { FirstName="Hannah", LastName="Turner", Email="hannah.turner@example.com", PhoneNumber="0711000040", Company="Cloudflare" },

            new() { FirstName="Andrew", LastName="Phillips", Email="andrew.phillips@example.com", PhoneNumber="0711000041", Company="DigitalOcean" },
            new() { FirstName="Scarlett", LastName="Campbell", Email="scarlett.campbell@example.com", PhoneNumber="0711000042", Company="GitHub" },
            new() { FirstName="Joshua", LastName="Parker", Email="joshua.parker@example.com", PhoneNumber="0711000043", Company="GitLab" },
            new() { FirstName="Victoria", LastName="Evans", Email="victoria.evans@example.com", PhoneNumber="0711000044", Company="JetBrains" },
            new() { FirstName="Christopher", LastName="Edwards", Email="christopher.edwards@example.com", PhoneNumber="0711000045", Company="OpenAI" },
            new() { FirstName="Aria", LastName="Collins", Email="aria.collins@example.com", PhoneNumber="0711000046", Company="Anthropic" },
            new() { FirstName="Nathan", LastName="Stewart", Email="nathan.stewart@example.com", PhoneNumber="0711000047", Company="MongoDB" },
            new() { FirstName="Penelope", LastName="Sanchez", Email="penelope.sanchez@example.com", PhoneNumber="0711000048", Company="Redis" },
            new() { FirstName="Ryan", LastName="Morris", Email="ryan.morris@example.com", PhoneNumber="0711000049", Company="Elastic" },
            new() { FirstName="Layla", LastName="Rogers", Email="layla.rogers@example.com", PhoneNumber="0711000050", Company="Docker" },

            new() { FirstName="Isaac", LastName="Reed", Email="isaac.reed@example.com", PhoneNumber="0711000051", Company="KPMG" },
            new() { FirstName="Aisha", LastName="Khan", Email="aisha.khan@example.com", PhoneNumber="0711000052", Company="Deloitte" },
            new() { FirstName="Noah", LastName="Ward", Email="noah.ward@example.com", PhoneNumber="0711000053", Company="PwC" },
            new() { FirstName="Zainab", LastName="Mohamed", Email="zainab.mohamed@example.com", PhoneNumber="0711000054", Company="EY" },
            new() { FirstName="Adam", LastName="Ngowi", Email="adam.ngowi@example.com", PhoneNumber="0711000055", Company="Vodacom" },
            new() { FirstName="Amina", LastName="Mushi", Email="amina.mushi@example.com", PhoneNumber="0711000056", Company="Airtel" },
            new() { FirstName="Kelvin", LastName="Massawe", Email="kelvin.massawe@example.com", PhoneNumber="0711000057", Company="CRDB" },
            new() { FirstName="Neema", LastName="Mwakipesile", Email="neema.mwakipesile@example.com", PhoneNumber="0711000058", Company="NMB" },
            new() { FirstName="Peter", LastName="Mrema", Email="peter.mrema@example.com", PhoneNumber="0711000059", Company="NBC" },
            new() { FirstName="Rehema", LastName="Mfinanga", Email="rehema.mfinanga@example.com", PhoneNumber="0711000060", Company="Stanbic" }
        };

        foreach (var contact in contactsToSeed)
        {
            bool exists = await context.Contacts
                .AnyAsync(c => c.Email == contact.Email);

            if (!exists)
            {
                context.Contacts.Add(contact);
            }
        }

        await context.SaveChangesAsync();
    }
}