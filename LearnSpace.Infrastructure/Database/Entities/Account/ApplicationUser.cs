using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static LearnSpace.Infrastructure.Database.Constants.DataConstants.ApplicationUser;

namespace LearnSpace.Infrastructure.Database.Entities.Account
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [StringLength(FirstNameMaxLen)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLen)]
        public string LastName { get; set; } = null!;

        [Required]
        public DateTime DateOfBirth { get; set; }
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    }
}
