using IRB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace IRB.Data
{

    public static class ContextSeed

    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager)
        {
            //Seed Roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "SuperAdmin", "Default" };
            IdentityResult result;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    result = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            string Email = "superadmin@gmail.com";
            string password = "Super@123";
            if (userManager.FindByEmailAsync(Email).Result==null)
            {
                ApplicationUser user = new ApplicationUser();
                user.PISNo = 1000001;
                user.UserName = Email;
                user.Email = Email;
                user.EmailConfirmed = true;
                IdentityResult resultIdentity = userManager.CreateAsync(user, password).Result;
                if (resultIdentity.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "SuperAdmin").Wait();
                }
            }

            //        PISNo = 5300000,
            //        EmailConfirmed = true,
            //        PhoneNumberConfirmed = true
           

        }
        //public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        //{
        //    //Seed Roles
        //    await roleManager.CreateAsync(new IdentityRole("Admin"));
        //    await roleManager.CreateAsync(new IdentityRole("GD Babu"));
        //    await roleManager.CreateAsync(new IdentityRole("Super Admin"));
        //    await roleManager.CreateAsync(new IdentityRole("Default"));
        //}


        //public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        //{
        //    //Seed Default User
        //    var defaultUser = new ApplicationUser
        //    {
        //        UserName = "superadmin",
        //        Email = "superadmin@gmail.com",
        //        PISNo = 5300000,
        //        EmailConfirmed = true,
        //        PhoneNumberConfirmed = true
        //    };
        //    if (userManager.Users.All(u => u.Id != defaultUser.Id))
        //    {
        //        var user = await userManager.FindByEmailAsync(defaultUser.Email);
        //        if (user == null)
        //        {
        //            await userManager.CreateAsync(defaultUser, "123Pa$$word.");
        //            await roleManager.CreateAsync(new IdentityRole("Admin"));
        //            await roleManager.CreateAsync(new IdentityRole("GD Babu"));
        //            await roleManager.CreateAsync(new IdentityRole("Super Admin"));
        //            await roleManager.CreateAsync(new IdentityRole("Default"));
        //        }

        //    }
        //}
    }
}

