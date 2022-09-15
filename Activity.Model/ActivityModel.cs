using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspStudy2.Model
{
    #pragma warning disable CS8618 // Nullable
    [Table("activity")]
    public class ActivityModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [Column("contents")]
        public string Contents { get; set; }

        [Required]
        [Column("written_date")]
        public DateTime WrittenDate { get; set; }

        [Required]
        [Column("is_modified")]
        public bool IsModified { get; set; }

        [ForeignKey("user_id")]
        [Required]
        public int UserId { get; set; }

        //[ForeignKey("UserId")]
        //public virtual User User { get; set; }
    }
}