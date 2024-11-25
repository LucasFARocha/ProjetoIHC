using System.ComponentModel.DataAnnotations;

namespace ProjetoIHC.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
    }
}
