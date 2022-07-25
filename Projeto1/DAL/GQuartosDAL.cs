using MySql.Data.MySqlClient;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    public class GQuartosDAL
    {
        private string connStr = BaseDAL.connStr;

        public int RegistarGQuarto(GQuartos gq) //metodo para guardar na BD
        {
            int registro = 0;
            string query = "INSERT INTO gestao_quartos (id_quarto, ocupado, hora_limpeza, observacao) VALUES(@id_quarto, @ocupado, @hora_limpeza, @observacao)";
            //Este @ dos values é apenas pra se diferenciar do referencia anterior, poderia ser referencia1

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn; //Comando do Mysql igualado a conexao 
                    conn.Open(); //Open é um metodo do MySqlConnection e não retorna nada.

                    cmd.Parameters.AddWithValue("@id_quarto", gq.id_quarto);
                    cmd.Parameters.AddWithValue("@ocupado", gq.ocupado);
                    cmd.Parameters.AddWithValue("@hora_limpeza", gq.hora_limpeza);
                    cmd.Parameters.AddWithValue("@observacao", gq.observacao);

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



        public List<GQuartos> ListarTodosQuartos()
        {
            List<GQuartos> lstquartos = new List<GQuartos>();
            string query = "SELECT gq.id, gq.id_quarto,  q.cod_quarto, q.num_pessoas, gq.ocupado, gq.hora_limpeza, gq.observacao FROM quartos as q, gestao_quartos as gq where q.id_quarto = gq.id_quarto ORDER BY q.id_quarto";
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
                                lstquartos.Add(new GQuartos(
                                    Int32.Parse(reader["id"].ToString()),
                                    Int32.Parse(reader["id_quarto"].ToString()),
                                    Int32.Parse(reader["cod_quarto"].ToString()),
                                    Int32.Parse(reader["num_pessoas"].ToString()),
                                    Boolean.Parse(reader["ocupado"].ToString()),
                                    DateTime.Parse(reader["hora_limpeza"].ToString()),
                                    reader["observacao"].ToString()
                      
                                    ));
                            }
                        }
                    }
                }
            }
            return lstquartos;
        }


        public int EditarQuartos(GQuartos gquartos)
        {
            int valida = 0;
            string query = "UPDATE gestao_quartos SET id_quarto=@id_quarto, ocupado = @ocupado, hora_limpeza=@hora_limpeza, observacao=@observacao WHERE id= @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", gquartos.id);
                    cmd.Parameters.AddWithValue("@id_quarto", gquartos.id_quarto);
                    cmd.Parameters.AddWithValue("@ocupado", gquartos.ocupado);
                    cmd.Parameters.AddWithValue("@hora_limpeza", gquartos.hora_limpeza);
                    cmd.Parameters.AddWithValue("@observacao", gquartos.observacao);

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

        public int ExcluirGQuartos(GQuartos quarto)
        {
            int valida = 0;
            string query = "DELETE FROM gestao_quartos WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", quarto.id);
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
        public int QuartosOcupados()
        {
            int count= 0;
            GQuartos gquartos = new GQuartos();
           
            string query = "SELECT COUNT(*) as qtd FROM gestao_quartos as gq where gq.ocupado = 1";
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

                              count = Int32.Parse(reader["qtd"].ToString());
                                  
                                    
                            }
                        }
                    }
                }
            }
            return count;
        }


        public int QuartosDisponivel()
        {
            int count = 0;
            GQuartos gquartos = new GQuartos();

            string query = "SELECT COUNT(*) as qtd FROM gestao_quartos as gq where gq.ocupado = 0";
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

                                count = Int32.Parse(reader["qtd"].ToString());


                            }
                        }
                    }
                }
            }
            return count;
        }


    }
}
