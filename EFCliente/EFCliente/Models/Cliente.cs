using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCliente.Models
{
    public class Cliente
    {
        
        public int ClienteID { get; set; }

        public String Nome { get; set; }

        public String Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public String Sexo { get; set; }

        public String Observacao { get; set; }
    }
}