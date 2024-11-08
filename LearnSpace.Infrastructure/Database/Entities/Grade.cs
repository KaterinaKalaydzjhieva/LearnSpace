using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearnSpace.Infrastructure.Database.Entities.Account;
using static LearnSpace.Infrastructure.Database.Constants.DataConstants.Grade;

namespace LearnSpace.Infrastructure.Database.Entities
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(ScoreMin,ScoreMax)]
        public double Score { get; set; }

        [Required]
        public DateTime DateGraded { get; set; }

        [Required]
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Assignment))]
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; } = null!;
    }

}
