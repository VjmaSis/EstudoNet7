using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetrpg.Core.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Sucesso { get; set; } = true;
        public string Mensagem { get; set; } = string.Empty;

    }
}
