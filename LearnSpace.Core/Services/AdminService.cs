using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Admin;
using LearnSpace.Infrastructure.Database.Entities.Account;
using LearnSpace.Infrastructure.Database.Repository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSpace.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminService(
                UserManager<ApplicationUser> _userManager,
                IRepository _repository)
        {
            userManager = _userManager;
            repository = _repository;
        }

        public async Task AddRoleAsync(string userId, string role)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(userId));

            await userManager.AddToRoleAsync(user, role);
        }

        public async Task DeleteRoleAsync(string userId, string role)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(userId));

            await userManager.RemoveFromRoleAsync(user, role);
        }

        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            var users = repository.AllReadOnly<ApplicationUser>()
                                    .Select(a=>new UserViewModel 
                                    {
                                        Id= a.Id.ToString().ToLower(),
                                        UserName = a.UserName,
                                        FullName = a.FirstName + " " + a.LastName,
                                    }).ToList();

            foreach (var a in users) 
            {
                var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(a.Id));

                var roles = await userManager.GetRolesAsync(user);

                a.Roles = roles.ToList();
            }
            
            return users;
        }
    }
}
