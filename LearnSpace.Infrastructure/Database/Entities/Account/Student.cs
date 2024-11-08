using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnSpace.Infrastructure.Database.Entities.Account
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<Grade> Grades { get; set; } = new List<Grade>();
        public IEnumerable<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
    }
}
