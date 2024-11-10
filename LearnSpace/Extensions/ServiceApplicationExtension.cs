using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Services;
using LearnSpace.Infrastructure.Database;
using LearnSpace.Infrastructure.Database.Contracts;
using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LearnSpace.Web.Extensions
{
    public static class ServiceApplicationExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            // <InterfaceService, Service>
            //services.AddScoped<ICakeService, CakeService>();
            //services.AddScoped<IAdminCakeService, AdminCakeService>();
            //services.AddScoped<IBiscuitService, BiscuitService>();
            //services.AddScoped<IAdminBiscuitService, AdminBiscuitService>();
            //services.AddTransient<IHomeService, HomeService>();
            //services.AddTransient<ICartService, CartService>();
            //services.AddScoped<IAdminOrderService, AdminOrderService>();
            //services.AddScoped<IOrderService, OrderService>();
            //services.AddTransient<IApplicationUserService, ApplicationUserService>();

            //Roles Authorization
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Administrator", policy => policy.RequireRole("Administrator"));
            //    options.AddPolicy("User", policy => policy.RequireRole("User"));
            //});
            //Authentication
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //})
            //.AddCookie(options =>
            //{
            //    options.LoginPath = "/User/Login";
            //});

            return services;
        }
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<LearnSpaceDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();


            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
            })
            .AddEntityFrameworkStores<LearnSpaceDbContext>()
            .AddDefaultTokenProviders();

            return services;
        }
    }
}
