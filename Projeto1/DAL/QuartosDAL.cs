using MySql.Data.MySqlClient;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    public class QuartosDAL
    {
        private string connStr = BaseDAL.connStr;
        public List<Quartos> ListarCodQuartos()
        {
            List<Quartos> lstquartos = new List<Quartos>();
            string query = "SELECT q.cod_quarto, q.id_quarto FROM quartos as q ORDER BY q.cod_quarto";
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
                                lstquartos.Add(new Quartos(

                                    Int32.Parse(reader["cod_quarto"].ToString()),
                                    Int32.Parse(reader["id_quarto"].ToString())
                                    ));
                            }
                        }
                    }
                }
            }
            return lstquartos;
        }

        public Quartos getQuartoByCod(int cod)

        {
            Quartos quartos = new Quartos();

            string query = "SELECT * FROM quartos WHERE cod_quarto=@1";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@1", cod);
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                quartos.id_quarto = Int32.Parse(sdr["id_quarto"].ToString());
                                quartos.cod_quarto = Int32.Parse(sdr["cod_quarto"].ToString());
                                quartos.num_pessoas = Int32.Parse(sdr["num_pessoas"].ToString());
                            }
                        }
                    }
                }
            }
            return quartos;
        }
    }
}
