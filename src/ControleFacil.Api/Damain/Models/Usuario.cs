using System.ComponentModel.DataAnnotations;

namespace ControleFacil.Api.Domain.Models
{


    public class Usuario
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo de email é obrigatorio.")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo de senha é obrigatorio.")]
        public string Senha { get; set; } = string.Empty;

        [Required]
        public DateTime DataCadastro { get; set; }

        public DateTime? DataInativacao { get; set; }
    }
}