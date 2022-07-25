using MySql.Data.MySqlClient;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    public class ServicoDAL
    {
        private string connStr = BaseDAL.connStr;
        public int InserirServico(Servicos servico) //metodo para guardar na BD
        {
            int registro = 0;
            string query = "INSERT INTO servicos (nome_servico, valor_servico) VALUES(@nome_servico, @valor_servico)";
            //Este @ dos values é apenas pra se diferenciar do referencia anterior, poderia ser referencia1

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn; //Comando do Mysql igualado a conexao 
                    conn.Open(); //Open é um metodo do MySqlConnection e não retorna nada.

                    cmd.Parameters.AddWithValue("@nome_servico", servico.nome_servico);
                    cmd.Parameters.AddWithValue("@valor_servico", servico.valor_servico);

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

        public List<Servicos> ListarTodosServicos()
        {
            List<Servicos> list_ser = new List<Servicos>();
            string query = "SELECT servicos.id, servicos.nome_servico, servicos.valor_servico FROM servicos ORDER BY servicos.nome_servico;";
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
                                list_ser.Add(new Servicos(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome_servico"].ToString(), 
                                    Decimal.Parse(reader["valor_servico"].ToString())                          
                                    ));
                            }
                        }
                    }
                }
            }
            return list_ser;
        }


       


        public int EditarServicos(Servicos servi)
        {
            int valida = 0;
            string query = "UPDATE servicos SET nome_servico=@nome, valor_servico=@valor WHERE id= @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))

            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", servi.id);
                    cmd.Parameters.AddWithValue("@nome", servi.nome_servico);
                    cmd.Parameters.AddWithValue("@valor", servi.valor_servico);


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

        public int ExcluirServico(Servicos servi)
        {
            int valida = 0;
            string query = "DELETE FROM servicos  WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", servi.id);

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

        

        public int VerificarNome(String servico)
        {
            int valor = 0;

            List<Servicos> lscBuscarServico = new List<Servicos>();
            string query = "SELECT * FROM servicos WHERE servicos.nome_servico=@servico ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@servico", servico);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lscBuscarServico.Add(new Servicos(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome_servico"].ToString(),
                                    Decimal.Parse(reader["valor_servico"].ToString())
                                   
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
    }
}
