using System.ComponentModel.DataAnnotations;
using static LearnSpace.Infrastructure.Database.Constants.DataConstants.Teacher;

namespace LearnSpace.Infrastructure.Database.Entities.Account
{
    public class Teacher:ApplicationUser
    {

        [Required]
        [StringLength(SubjectSpecializationMaxLen)]
        public string SubjectSpecialization { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    }

}
