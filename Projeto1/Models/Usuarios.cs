using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idcargo { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string cargo { get; set; }
        public DateTime data { get; set; }

        public Usuarios()
        {
        }

        public Usuarios( string nome, int idcargo, string usuario, string senha, DateTime data)
        {

            this.nome = nome;
            this.idcargo = idcargo;
            this.usuario = usuario;
            this.senha = senha;
            this.data = data;
        }

        public Usuarios(int id, string nome, int idcargo, string usuario, string senha, DateTime data)
        {
            this.id = id;
            this.nome = nome;
            this.idcargo = idcargo;
            this.usuario = usuario;
            this.senha = senha;
            this.data = data;
        }
        public Usuarios(int id, string nome, string cargo, string usuario, string senha, DateTime data)
        {
            this.id=id;
            this.nome = nome;
            this.cargo = cargo;
            this.usuario=usuario;
            this.senha=senha;
            this.data=data;
        }

        public Usuarios( string nome, string usuario, string senha)
        {
            this.nome = nome;
            this.usuario = usuario;
            this.senha = senha;
          
        }
        public Usuarios(string usuario, string senha)
        {
          
            this.usuario = usuario;
            this.senha = senha;

        }




    }
}
