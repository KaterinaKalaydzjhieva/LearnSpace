using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static LearnSpace.Common.DataConstants.Teacher;

namespace LearnSpace.Infrastructure.Database.Entities.Account
{
    public class Teacher
    {
        public Teacher()
        {
            Id = Guid.NewGuid();
            this.Courses = new HashSet<Course>();
            this.Assignments = new HashSet<Assignment>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(SubjectSpecializationMaxLen)]
        public string SubjectSpecialization { get; set; } = string.Empty;
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;
    }

}
