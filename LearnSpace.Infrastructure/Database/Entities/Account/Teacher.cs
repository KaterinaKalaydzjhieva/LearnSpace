using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static LearnSpace.Infrastructure.Database.Constants.DataConstants.Teacher;

namespace LearnSpace.Infrastructure.Database.Entities.Account
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(SubjectSpecializationMaxLen)]
        public string SubjectSpecialization { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
    }

}
