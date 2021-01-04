using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.DataNascimento).IsRequired();
            builder.Property(c => c.Sexo).IsRequired();

            builder.ToTable("Clientes");

        }
    }
}
