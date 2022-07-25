using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Cargos
    {
        public int id { get; set; }
        public string cargo { get; set; }

        public Cargos(string cargo)
        {
            this.cargo = cargo;
        }

        public Cargos(int id, string nomecargo)
        {
            this.id = id;
            this.cargo = nomecargo;
        }

        public Cargos()
        {

        }
    }
}
