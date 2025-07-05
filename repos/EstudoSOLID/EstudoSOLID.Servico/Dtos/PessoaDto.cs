using System.ComponentModel.DataAnnotations;

namespace EstudoSOLID.Servico.Dtos
{
    public class PessoaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O nome pode ter no máximo 100 caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email deve ser válido.")]
        [MaxLength(100, ErrorMessage = "O email pode ter no máximo 100 caracteres.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"\d{3}\.\d{3}\.\d{3}-\d{2}", ErrorMessage = "O CPF deve estar no formato 000.000.000-00.")]
        public string? CPF { get; set; }

        [MaxLength(15, ErrorMessage = "O telefone pode ter no máximo 15 caracteres.")]
        public string? Telefone { get; set; }
    }
}
