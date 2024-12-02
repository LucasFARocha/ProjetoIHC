using System.ComponentModel.DataAnnotations;

namespace ProjetoIHC.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Informe seu nome")]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string name { get; set; }

        [Required(ErrorMessage = "Informe sua data de nascimento")]
        [Display(Name = "Data de nascimento")]
        public DateOnly dataNascimento { get; set; }

        [Required(ErrorMessage = "Informe seu RG")]
        [Display(Name = "RG")]
        [StringLength(15)]
        public string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe seu CPF")]
        [Display(Name = "CPF")]
        [StringLength(11)]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o endereço")]
        [Display(Name = "Endereço")]
        [StringLength(100)]
        public string Logradouro { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe o número")]
        [Display(Name = "Número")]
        [StringLength(30)]
        public string Numero { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe o bairro")]
        [Display(Name = "Bairro")]
        [StringLength(30)]
        public string Bairro { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe a cidade")]
        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string Cidade { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe a UF")]
        [Display(Name = "UF")]
        [StringLength(30)]
        public string UF { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe o CEP")]
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string CEP { get; set; } = string.Empty;
    }
}
