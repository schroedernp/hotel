using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Fornecedores
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string nif { get; set; }
        public string endereco { get; set; }

        public string telefone { get; set; }

        public string email { get; set; }

        public Fornecedores(int id, string nome, string nif, string endereco, string telefone, string email)
        {
            this.id = id;
            this.nome = nome;
            this.nif = nif;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }

        public Fornecedores(string nome, string nif, string endereco, string telefone, string email)
        {
  
            this.nome = nome;
            this.nif = nif;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }

        public Fornecedores()
        {

        }
    }
}
