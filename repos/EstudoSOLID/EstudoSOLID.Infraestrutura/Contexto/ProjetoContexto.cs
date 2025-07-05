using EstudoSOLID.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EstudoSOLID.Infraestrutura.Contexto
{
    public class ProjetoContexto(DbContextOptions<ProjetoContexto> options) : DbContext(options)
    {
        public required DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.CPF).IsRequired().HasMaxLength(14);
                entity.Property(e => e.Telefone).HasMaxLength(15);
            });
        }

    }
}
