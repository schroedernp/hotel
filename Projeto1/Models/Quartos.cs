using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Quartos
    {
        public  int id_quarto { get; set; }

        public int cod_quarto { get; set; }

        public int num_pessoas { get; set; }


        public Quartos(int cod_quarto, int id_quarto)
        {
            this.cod_quarto = cod_quarto;
            this.id_quarto = id_quarto;
        }

        public Quartos(int id_quarto, int cod_quarto, int num_pessoas)
        {
            this.id_quarto = id_quarto;
            this.cod_quarto = cod_quarto;
            this.num_pessoas = num_pessoas;
        }

        public Quartos()
        {

        }
    }
}
