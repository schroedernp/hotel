using MySql.Data.MySqlClient;
using Projeto1.DAL;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class CargoDAL
    {
        //CONEXAO COM BD LOCAL


    
    private string connStr = BaseDAL.connStr;// BaseDAL.connStr = "datasource=localhost;port=3306;username=root;password=;database=salarios;SslMode=none"; 
                                             //datasource pode ser o ip da minha maquina 


        public int InserirCargo(Cargos c) //metodo para guardar na BD
        {
            int registo = 0;
            string query = "INSERT INTO cargos (cargo) VALUES(@cargo)";
            //Este @ dos values é apenas pra se diferenciar do referencia anterior, poderia ser referencia1

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn; //Comando do Mysql igualado a conexao 
                    conn.Open(); //Open é um metodo do MySqlConnection e não retorna nada.

                    cmd.Parameters.AddWithValue("@cargo",c.cargo); //AddwithValue 
        

                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        //throw new Exception(e.Message, e);
                    }
                }
            }
            return registo;
        }

        public List<Cargos> ListarTodosCargos()
        {
            List<Cargos> list_cargos = new List<Cargos>();
            string query = "SELECT * FROM cargos ORDER BY cargo ASC ";
            using(MySqlConnection conn = new MySqlConnection(connStr))
            {
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                list_cargos.Add(new Cargos(
                                    Int32.Parse(reader["id_cargo"].ToString()),
                                    reader["cargo"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return list_cargos;
        }

        public List<Cargos> ListarUmCargo(Cargos c)
        {
            List<Cargos> list_cargos = new List<Cargos>();
            string query = "SELECT * FROM cargos WHERE id_cargos=@id ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", c.id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                list_cargos.Add(new Cargos(
                                    Int32.Parse(reader["id_cargo"].ToString()),
                                    reader["cargo"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return list_cargos;
        }


        public int EditarCargo(Cargos _c)
        {
            int valida = 0;
            string query = "UPDATE cargos SET cargo = @cargo WHERE id_cargo = @id";
            using(MySqlConnection conn =new MySqlConnection(connStr))
            {
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", _c.id);
                    cmd.Parameters.AddWithValue("@cargo", _c.cargo);
             

                    try
                    {
                        valida = cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {

                        
                    }
                }
            }

                return valida;
        }

        public int ExcluirCargo(int _c)
        {
            int valida = 0;
            string query = "DELETE FROM cargos  WHERE id_cargo = @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", _c);

                    try
                    {
                        valida = cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {

                    }
                }
            }

            return valida;

        }

        //Colocar este método no funcionario
        public List<Funcionarios> ListarFuncionario(int id_cargo)
        {

            List<Funcionarios> lista_funcionarios = new List<Funcionarios>();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM funcionarios WHERE cargo_f = @cargo";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cargo", id_cargo);
                MySqlDataReader read = cmd.ExecuteReader(); //Vou ler algo do BD

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lista_funcionarios.Add(new Funcionarios(
                            Int32.Parse(read["id"].ToString()),
                            read["nome"].ToString(),
                            DateTime.Parse(read["dataNasc"].ToString()),
                            read["nif"].ToString(),
                            read["endereco"].ToString(),
                            read["telefone"].ToString(),
                            DateTime.Parse(read["data"].ToString()),
                            read["cargo_f"].ToString()
                            ));
                    }
                }

            }
            catch (MySqlException ex) 
            {
                
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                conn.Close();
            }
            return lista_funcionarios;
        }




    }
}
