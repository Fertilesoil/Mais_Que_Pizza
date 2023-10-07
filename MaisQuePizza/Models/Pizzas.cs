using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaisQuePizza.Models
{
    public class Pizzas
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Borda { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Tamanho { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal (8,2)")]
        public decimal Preco { get; set; }
        public virtual Categoria? Categoria { get; set; }
    }
}