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
        public string Item { get; set; } = string.Empty;

        // Navigation Property
        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }
    }
}
