using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServerSide.Data
{
    public class Todolist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }


        public bool IsCompleted { get; set; }

        public DateTime createdDate   { get; set; } = DateTime.Now;

        // Navigation Property
        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }
    }
}
