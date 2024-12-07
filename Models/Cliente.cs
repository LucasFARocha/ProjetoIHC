using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProjetoIHC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe seu nome")]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; } = String.Empty;

        [Required(ErrorMessage = "Informe sua data de nascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe seu RG")]
        [Display(Name = "RG")]
        [StringLength(15)]
        public string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe seu CPF")]
        [Display(Name = "CPF")]
        [StringLength(11)]
        public string CPF { get; set; } = string.Empty;


        [Required(ErrorMessage = "Informe a UF")]
        [Display(Name = "UF")]
        [StringLength(30)]
        public string UF { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe seu CEP")]
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string? CEP { get; set; }

        [Required(ErrorMessage = "Informe sua cidade")]
        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string Cidade { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe seu bairro")]
        [Display(Name = "Bairro")]
        [StringLength(30)]
        public string Bairro { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe seu endereço")]
        [Display(Name = "Endereço")]
        [StringLength(100)]
        public string Logradouro { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe o número")]
        [Display(Name = "Número")]
        [StringLength(30)]
        public string Numero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o complemento")]
        [Display(Name = "Complemento")]
        [StringLength(30)]
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "Informe seu estado civil")]
        [Display(Name = "Estado Civil")]
        [StringLength(15)]
        public string EstadoCivil { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome do seu pai")]
        [Display(Name = "Nome do Pai")]
        [StringLength(100)]
        public string NomePai { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome da sua mãe")]
        [Display(Name = "Nome da Mãe")]
        [StringLength(100)]
        public string NomeMae { get; set; } = string.Empty;
    }
}
