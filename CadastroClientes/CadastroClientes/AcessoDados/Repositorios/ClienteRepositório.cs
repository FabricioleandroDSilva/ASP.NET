using CadastroCliente.Models;
using CadastroClientes.AcessoDados.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.AcessoDados.Repositorios
{
    public class ClienteRepositório : RepositorioGenerico<Cliente>, IClienteRepositorio
    {
        private readonly Contexto _contexto;

        public ClienteRepositório(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

    }
}
