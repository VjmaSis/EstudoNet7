using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoBlazor.Shared.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo é 100")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatorio")]
        [MaxLength(200, ErrorMessage = "O tamanho máximo é 200")]
        public string? Descricao { get; set; }
        //public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
