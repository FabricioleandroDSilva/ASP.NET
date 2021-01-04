using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage="Este Campo é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string DataNascimento { get; set; }

        [RegularExpression(@"^[M,F,m,f]+$", ErrorMessage = "Utilize M - Masculino e F - Feminino")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public char Sexo  { get; set; }
        public string Cep { get; set; }
        public string Endereço { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }


    }
}
