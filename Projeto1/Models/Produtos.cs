using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Produtos
    {
        private int v1;
        private string v2;
        private string v3;

        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int estoque { get; set; }

        public int fornecedor { get; set; }
        public  string nome_fornecedor { get; set; }
        public decimal valor_venda { get; set; }
        public decimal valor_compra { get; set; }

        public DateTime data { get; set; }

        public string imagem { get; set; }


        public Produtos()
        {

        }
        public Produtos(int id, string nome, string descricao, int estoque, int fornecedor, decimal valor_venda, decimal valor_compra, DateTime data, string imagem)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.estoque = estoque;
            this.fornecedor = fornecedor;
            this.valor_venda = valor_venda;
            this.valor_compra = valor_compra;
            this.data = data;
            this.imagem = imagem;
        }

       

        public Produtos(string nome, string descricao, int estoque, int fornecedor, decimal valor_venda)
        {
    
            this.nome = nome;
            this.descricao = descricao;
            this.estoque = estoque;
            this.fornecedor = fornecedor;
            this.valor_venda = valor_venda;
        }

        public Produtos(int id, string nome, string descricao, int estoque, string fornecedor, decimal valor_venda, decimal valor_compra, DateTime data, string imagem)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.estoque = estoque;
            this.nome_fornecedor = fornecedor;
            this.valor_venda = valor_venda;
            this.valor_compra = valor_compra;
            this.data = data;
            this.imagem = imagem;
        }

        public Produtos( int id, int estoque, int fornecedor, decimal valor_compra)
        {
            this.id = id;
            this.estoque = estoque;
            this.fornecedor = fornecedor;
            this.valor_compra = valor_compra;
        }
        //Produtos prod = new Produtos(txtNome.Text, txtDescricao.Text, fornecedor_cb.id, Decimal.Parse(txtValor.Text.Replace(".", ",")));

        public Produtos(string nome, string descricao, int fornecedor, decimal valor_venda )
        {
         
            this.nome = nome;
            this.descricao = descricao;
            this.fornecedor = fornecedor;
            this.valor_venda = valor_venda;
     
        }
    }
}
