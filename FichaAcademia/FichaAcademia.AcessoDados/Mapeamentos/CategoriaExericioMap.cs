using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class CategoriaExericioMap : IEntityTypeConfiguration<CategoriaExercicio>
    {
        public void Configure(EntityTypeBuilder<CategoriaExercicio> builder)
        {
            builder.HasKey(c => c.CategoriaExercicioId);

            builder.Property(c => c.Nome).IsRequired();


            builder.HasMany(c => c.Exercicio).WithOne(c=> c.CategoriaExercicio).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("CategoriasExericios");
        }
    }
}
