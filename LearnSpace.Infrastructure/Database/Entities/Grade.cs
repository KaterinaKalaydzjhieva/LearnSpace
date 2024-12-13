using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearnSpace.Infrastructure.Database.Entities.Account;
using static LearnSpace.Common.DataConstants.Grade;

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
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Submission))]
        public int SubmissionId { get; set; }
        public virtual Submission Submission { get; set; } = null!;
    }

}
