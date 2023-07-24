using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoBlazor.Shared.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo é 100")]
        public string? Nome { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "O Valor é obrigatorio")]
        public decimal Preco { get; set; }

        [MaxLength(300, ErrorMessage = "O tamanho máximo é 300")]
        [Required(ErrorMessage = "Detalhe do produto é obrigatório")]
        [Display(Name = "Detalhes do Produto")]
        public string? Detalhe { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatorio")]
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }

        public string? ImagemBase64 { get; set; }
    }
}
