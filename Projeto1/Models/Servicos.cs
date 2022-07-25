using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Servicos
    {
        public int id { get; set; } 
        public string nome_servico { get; set; }
        public decimal valor_servico { get; set; }


        public Servicos()
        {
        }

        public Servicos(string nome_servico, decimal valor_servico)
        {
            this.nome_servico = nome_servico;
            this.valor_servico = valor_servico; 
        }

        public Servicos(int id, string nome_servico, decimal valor_servico)
        {
            this.id = id;
            this.nome_servico = nome_servico;
            this.valor_servico = valor_servico;
        }
    }

}
