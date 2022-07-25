using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Funcionarios
    {

        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNasc { get; set; }
        public string  nif { get; set; }

        public string endereco { get; set; }
        public string telefone { get; set; }
        public DateTime data { get; set; }

        public int idCargo { get; set; }

        public string cargo { get; set; }


        public Funcionarios( string nome, DateTime dataNasc, string nif, string endereco, string telefone, int idCargo)
        {
           
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.nif = nif;
            this.endereco = endereco;
            this.telefone = telefone;  
            this.idCargo = idCargo;

        }
        public Funcionarios(int id, string nome, DateTime dataNasc, string nif, string endereco, string telefone, DateTime data, string cargo)
        {
            this.id = id;
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.nif = nif;
            this.endereco = endereco;
            this.telefone = telefone;
            this.data = data;
            this.cargo = cargo;

        }

        public Funcionarios()
        {

        }

    }
}
