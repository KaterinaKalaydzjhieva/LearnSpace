using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearnSpace.Infrastructure.Database.Entities.Account;
using static LearnSpace.Infrastructure.Database.Constants.DataConstants.Assignment;
namespace LearnSpace.Infrastructure.Database.Entities
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLen)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(DescriptionMaxLen)]
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }

}
