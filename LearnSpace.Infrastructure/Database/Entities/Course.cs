using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearnSpace.Infrastructure.Database.Entities.Account;
using static LearnSpace.Infrastructure.Database.Constants.DataConstants.Course;

namespace LearnSpace.Infrastructure.Database.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLen)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(DescriptionMaxLen)]
        public string Description { get; set; } = string.Empty;

        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; } = null!;
        public ICollection<StudentCourse> CourseStudents { get; set; } = new List<StudentCourse>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
    }

}
