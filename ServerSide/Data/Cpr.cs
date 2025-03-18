using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerSide.Data
{
    public class Cpr
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string CprNr { get; set; } = string.Empty;

        // Foreign key to Identity User
        [Required]
        public string UserId { get; set; } = string.Empty;

        // Navigation Property for Identity User
        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }
    }
}
