using LearnSpace.Infrastructure.Database.Entities.Account;
using System.ComponentModel.DataAnnotations;
using static LearnSpace.Common.DataConstants.Submission;

namespace LearnSpace.Infrastructure.Database.Entities
{
    public class Submission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; } = null!;

        [Required]
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; } = null!;

        [Required]
        [StringLength(FilePathMaxLength)]
        public string FilePath { get; set; } = string.Empty;

        public DateTime SubmittedOn { get; set; }
    }

}
