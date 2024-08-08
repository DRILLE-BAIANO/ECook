

namespace ECook.Models;
[Table("Categoria")]
 public class Categoria
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [StringLength(300)]
        
    }
