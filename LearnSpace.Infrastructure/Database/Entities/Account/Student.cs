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

        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
