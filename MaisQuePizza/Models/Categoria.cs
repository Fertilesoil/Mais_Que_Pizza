using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace MaisQuePizza.Models
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Tipo { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<Pizzas>? Pizzas { get; set; }
    }
}