using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.AspNetCore.Identity;
using static LearnSpace.Infrastructure.Database.Constants.RoleConstants;

namespace LearnSpace.Web.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> SeedRoles(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();



            var roles = new[] { AdminRoleName, TeacherRoleName, StudentRoleName };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var admin = await userManager.FindByEmailAsync(AdminEmail);

            await userManager.AddToRoleAsync(admin, AdminRoleName);

            var studentEmails = new[] { "student1abv.bg", "student2abv.bg", "student3abv.bg", "student4abv.bg" };

            foreach (var email in studentEmails)
            {
                var user = await userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    await userManager.AddToRoleAsync(user, "Student");
                }
            }

            var teacherEmails = new[] { "teacher1abv.bg", "teacher2abv.bg" };

            foreach (var email in teacherEmails)
            {
                ApplicationUser user = await userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    await userManager.AddToRoleAsync(user, "Teacher");
                }
            }



            return app;
        }


        //public static IApplicationBuilder AddUsersToRoles(this IApplicationBuilder app)
        //{
        //    using var scopedServices = app.ApplicationServices.CreateScope();

        //    var services = scopedServices.ServiceProvider;


        //    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        //    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();



        //    return app;

        //}
    }
}
