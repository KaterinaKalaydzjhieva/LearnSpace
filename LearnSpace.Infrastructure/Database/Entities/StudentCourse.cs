using System.ComponentModel.DataAnnotations.Schema;
using LearnSpace.Infrastructure.Database.Entities.Account;

namespace LearnSpace.Infrastructure.Database.Entities
{
    public class StudentCourse
    {   
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;


        [ForeignKey(nameof(Student))]
        public int StudentId { get; set;}
        public Student Student { get; set; } = null!;
    }
}
