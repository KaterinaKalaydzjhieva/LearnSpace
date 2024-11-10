using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnSpace.Infrastructure.Database.Entities.Account
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
            this.Grades = new HashSet<Grade>();
            this.StudentCourses = new HashSet<StudentCourse>();
        }

        [Key]
        public Guid Id { get; set; }
        public virtual IEnumerable<Grade> Grades { get; set; }
        public virtual IEnumerable<StudentCourse> StudentCourses { get; set; } 

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; } = Guid.Empty;
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
