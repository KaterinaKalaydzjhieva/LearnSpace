using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearnSpace.Infrastructure.Database.Entities.Account;
using static LearnSpace.Common.DataConstants.Notification;

namespace LearnSpace.Infrastructure.Database.Entities
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MessageMaxLen)]
        public string Message { get; set; } = string.Empty;

        [Required]
        public DateTime DateSent { get; set; }

        [Required]
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; } = null!;
    }

}
