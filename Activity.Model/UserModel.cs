using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspStudy2.Model
{
    #pragma warning disable CS8618 // Nullable
    [Table("user")]
    public class UserModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("password")]
        public string Password { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }
        
        [Required]
        [Column("email")]
        public string Email { get; set; }
    }
}
