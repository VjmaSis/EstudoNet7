using dotnetrpg.core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetrpg.Data
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal()
        {
            
        }
        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters => Set<Character>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=.\\SqlExpress; Database=dotnet-rpg; Trusted_Connection=true; TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Character
            modelBuilder.Entity<Character>().Property(m => m.Strength).IsRequired(true);
            modelBuilder.Entity<Character>().Property(m => m.Defense).IsRequired(true);
            modelBuilder.Entity<Character>().Property(m => m.Class).IsRequired(true);
            modelBuilder.Entity<Character>().Property(m => m.HitPoints).IsRequired(true);
            modelBuilder.Entity<Character>().Property(m => m.Intelligence).IsRequired(true);
            modelBuilder.Entity<Character>().Property(m => m.Name).IsRequired(true).HasMaxLength(250);
            #endregion
        }
    }
}
