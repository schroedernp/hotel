using MySql.Data.MySqlClient;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    public class ProdutosDAL
    {
        private string connStr = BaseDAL.connStr;

        public int InserirProduto(Produtos prod) //metodo para guardar na BD
        {
            int registro = 0;
            string query = "INSERT INTO produtos (nome_prod, descricao, fornecedor, valor_venda, data) VALUES(@nome, @descricao, @fornecedor, @valor_venda, curDate())";
            //Este @ dos values é apenas pra se diferenciar do referencia anterior, poderia ser referencia1

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn; //Comando do Mysql igualado a conexao 
                    conn.Open(); //Open é um metodo do MySqlConnection e não retorna nada.

                    cmd.Parameters.AddWithValue("@nome", prod.nome);
                    cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                    cmd.Parameters.AddWithValue("@fornecedor", prod.fornecedor);
                    cmd.Parameters.AddWithValue("@valor_venda", prod.valor_venda);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);


                    try
                    {
                        registro = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        //throw new Exception(e.Message, e);
                    }
                }
            }
            return registro;
        }

        public List<Produtos> ListarTodosProdutos()
        {
            List<Produtos> list_produtos = new List<Produtos>();
            string query = "SELECT p.id, p.nome_prod, p.descricao, p.estoque, f.nome, p.valor_venda, p.valor_compra, p.data, p.imagem FROM produtos as p, fornecedores as f where f.id = p.fornecedor ORDER BY p.nome_prod ASC";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                list_produtos.Add(new Produtos(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome_prod"].ToString(),
                                    reader["descricao"].ToString(),
                                    Int32.Parse(reader["estoque"].ToString()),
                                    reader["nome"].ToString(),
                                    Decimal.Parse(reader["valor_venda"].ToString()),
                                    Decimal.Parse(reader["valor_compra"].ToString()),
                                    DateTime.Parse(reader["data"].ToString()),
                                    reader["imagem"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return list_produtos;
        }


        public int EditarProduto(Produtos prod)
        {
            int valida = 0;
            string query = "UPDATE produtos SET nome_prod=@nome, descricao=@descricao, estoque=@estoque, fornecedor=@fornecedor, valor_venda=@valor_venda, valor_compra=@valor_compra, data=@data WHERE id=@id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", prod.id);
                    cmd.Parameters.AddWithValue("@nome", prod.nome);
                    cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                    cmd.Parameters.AddWithValue("@estoque", prod.estoque);
                    cmd.Parameters.AddWithValue("@fornecedor", prod.fornecedor);
                    cmd.Parameters.AddWithValue("@valor_venda", prod.valor_venda);
                    cmd.Parameters.AddWithValue("@valor_compra", prod.valor_compra);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);
                    cmd.Parameters.AddWithValue("@imagem", prod.imagem);

                    try
                    {
                        valida = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {


                    }
                }
            }

            return valida;
        }

        public int ExcluirProdutos(Produtos prod)
        {
            int valida = 0;
            string query = "DELETE FROM produtos WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", prod.id);

                    try
                    {
                        valida = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {


                    }
                }
            }

            return valida;

        }

        public List<Produtos> FiltrarProdutoNome(Produtos prod)
        {
            List<Produtos> lscBuscarProd = new List<Produtos>();
            string query = "SELECT p.id, p.nome_prod, p.descricao, p.estoque, f.nome, p.valor_venda, p.valor_compra, p.data, p.imagem FROM produtos as p INNER JOIN fornecedores as f ON p.fornecedor=f.id WHERE p.id = @id ORDER BY p.nome_prod ASC";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@id", prod.id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lscBuscarProd.Add(new Produtos(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome_prod"].ToString(),
                                    reader["descricao"].ToString(),
                                    Int32.Parse(reader["estoque"].ToString()),
                                    reader["nome"].ToString(),
                                    Decimal.Parse(reader["valor_venda"].ToString()),
                                    Decimal.Parse(reader["valor_compra"].ToString()),
                                    DateTime.Parse(reader["data"].ToString()),
                                    reader["imagem"].ToString()
                                    ));
                            }
                        }
                    }
                }
            }
            return lscBuscarProd;
        }


        public int VerificarNome(String nome)
        {
            int valor = 0;

            List<Produtos> lscBuscarProd = new List<Produtos>();
            string query = "SELECT * FROM produtos WHERE nome_prod=@nome ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nome", nome);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lscBuscarProd.Add(new Produtos(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome_prod"].ToString(),
                                    reader["descricao"].ToString(),
                                    Int32.Parse(reader["estoque"].ToString()),
                                    Int32.Parse(reader["fornecedor"].ToString()),
                                    Decimal.Parse(reader["valor_venda"].ToString()),
                                    Decimal.Parse(reader["valor_compra"].ToString()),
                                    DateTime.Parse(reader["data"].ToString()),
                                    reader["imagem"].ToString()
                                    ));
                            }
                        }
                        else
                        {
                            valor++;
                        }

                    }
                }
                return valor;
            }

        }

        public int AtualizarEstoque(Produtos prod)
        {
            int valida = 0;
            string query = "UPDATE produtos SET estoque=@estoque, fornecedor=@fornecedor, valor_compra=@valor_compra WHERE id=@id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", prod.id);
                    cmd.Parameters.AddWithValue("@estoque", prod.estoque);
                    cmd.Parameters.AddWithValue("@fornecedor", prod.fornecedor);
                    cmd.Parameters.AddWithValue("@valor_compra", prod.valor_compra);


                    try
                    {
                        valida = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {


                    }
                }
            }

            return valida;
        }


    }
}
