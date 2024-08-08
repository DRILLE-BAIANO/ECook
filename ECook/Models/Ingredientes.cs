

namespace ECook.Models;
    [Table("Ingredientes")]
    public class Ingredientes
    {
        [Key]
        public int id { get; set; }

        [Requered]
        [StringLength]
        public  string Nome { get; set; }
        
    }
