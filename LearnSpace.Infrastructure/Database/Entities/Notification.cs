using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearnSpace.Infrastructure.Database.Entities.Account;
using static LearnSpace.Infrastructure.Database.Constants.DataConstants.Notification;

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
        public string StudentId { get; set; } = string.Empty;
        public Student Student { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; } = string.Empty;
        public Teacher Teacher { get; set; } = null!;
    }

}
