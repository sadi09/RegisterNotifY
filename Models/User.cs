using System.ComponentModel.DataAnnotations;

namespace RegisterNotify.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(50, MinimumLength =4)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
