using EstudoBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoBlazor.Server.Contexto
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> options) : base(options) 
        {
            
        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}
