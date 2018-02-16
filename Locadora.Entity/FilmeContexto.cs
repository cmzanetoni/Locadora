using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Entity
{
    public class FilmeContexto : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            var mapFilme = modelBuilder.Entity<Filme>();

            mapFilme.Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            mapFilme.Property(x => x.Titulo)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(200);

            mapFilme.Property(x => x.Descricao)
                .IsVariableLength()
                .IsOptional()
                .HasMaxLength(2000);

            mapFilme.Property(x => x.DataLancamento)
                .HasColumnType("datetime")
                .IsRequired();

            mapFilme.Property(x => x.ValorLocacao)
                .IsRequired();

            mapFilme.Property(x => x.ValorVenda)
                .IsOptional();

            mapFilme.HasKey(x => x.Id);

            mapFilme.ToTable("Filmes");
        }

        public System.Data.Entity.DbSet<Locadora.Filme> Filmes { get; set; }
    }
}
