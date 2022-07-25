using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class GQuartos
    {
        
        public int id { get; set; }
        public int id_quarto { get; set; }

        public Boolean ocupado { get; set; }

        public DateTime hora_limpeza { get; set; }

        public String observacao { get; set; }

        public int num_pessoas { get; set; }
        public int cod_quarto { get; set; }


        public GQuartos(int id, int id_quarto, bool ocupado, DateTime hora_limpeza, string observacao)
        {
            this.id = id;
            this.id_quarto = id_quarto;
            this.ocupado = ocupado;
            this.hora_limpeza = hora_limpeza;
            this.observacao = observacao;
        }

        public GQuartos(int id, int id_quarto, int cod_quarto, int num_pessoas, bool ocupado, DateTime hora_limpeza, string observacao )
        {
            this.id = id;
            this.id_quarto = id_quarto;
            this.cod_quarto = cod_quarto;
            this.num_pessoas = num_pessoas;
            this.ocupado = ocupado;
            this.hora_limpeza = hora_limpeza;
            this.observacao = observacao;
            
            
        }

        public GQuartos()
        {

        }
    }
}
