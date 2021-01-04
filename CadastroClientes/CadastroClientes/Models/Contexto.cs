using CadastroCliente.Mapeamento;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            builder.ApplyConfiguration(new ClienteMap());



        }

    }
}
