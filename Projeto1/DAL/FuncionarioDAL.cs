using MySql.Data.MySqlClient;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    public class FuncionarioDAL
    {
        private string connStr = BaseDAL.connStr;

        public int InserirFuncionario(Funcionarios func) //metodo para guardar na BD
        {
            int registro = 0;
            string query = "INSERT INTO funcionarios (nome, dataNasc, nif, endereco, telefone, data, cargo_f) VALUES(@nome, @dataNasc, @nif, @endereco, @telefone, @data, @cargo)";
            //Este @ dos values é apenas pra se diferenciar do referencia anterior, poderia ser referencia1

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn; //Comando do Mysql igualado a conexao 
                    conn.Open(); //Open é um metodo do MySqlConnection e não retorna nada.

                    cmd.Parameters.AddWithValue("@nome", func.nome);
                    cmd.Parameters.AddWithValue("@dataNasc", func.dataNasc);
                    cmd.Parameters.AddWithValue("@nif", func.nif);
                    cmd.Parameters.AddWithValue("@endereco", func.endereco);
                    cmd.Parameters.AddWithValue("@telefone", func.telefone);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cargo", func.idCargo);


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

        public List<Funcionarios> ListarTodosFuncionarios()
        {
            List<Funcionarios> list_func = new List<Funcionarios>();
            string query = "SELECT * FROM funcionarios as f, cargos as c where f.cargo_f = c.id_cargo ORDER BY f.nome";
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
                                list_func.Add(new Funcionarios(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                     DateTime.Parse(reader["dataNasc"].ToString()),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    DateTime.Parse(reader["data"].ToString()),
                                    reader["cargo"].ToString()
                                    ));
                            }
                        }
                    }
                }
            }
            return list_func;
        }


        public int EditarFuncionário(Funcionarios func)
        {
            int valida = 0;
            string query = "UPDATE funcionarios SET nome=@nome, dataNasc = @dataNasc, nif=@nif, endereco=@endereco, telefone=@telefone, data=@data, cargo_f=@cargo WHERE id= @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", func.id);
                    cmd.Parameters.AddWithValue("@nome", func.nome);
                    cmd.Parameters.AddWithValue("@dataNasc", func.dataNasc);
                    cmd.Parameters.AddWithValue("@nif", func.nif);
                    cmd.Parameters.AddWithValue("@endereco", func.endereco);
                    cmd.Parameters.AddWithValue("@telefone", func.telefone);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cargo", func.idCargo);

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

        public int ExcluirFuncionario(Funcionarios _f)
        {
            int valida = 0;
            string query = "DELETE FROM funcionarios WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", _f.id);



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

        public List<Funcionarios> FiltrarFuncionarioNome(Funcionarios f)
        {
            List<Funcionarios> lscBuscaFunc = new List<Funcionarios>();
            string query = "SELECT f.id, f.nome, f.dataNasc, f.nif, f.endereco, f.telefone, f.data, c.cargo FROM funcionarios as f,cargos as c WHERE id=@id_func AND f.cargo_f = c.id_cargo;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@id_func", f.id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lscBuscaFunc.Add(new Funcionarios(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    DateTime.Parse(reader["dataNasc"].ToString()),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    DateTime.Parse(reader["data"].ToString()),
                                    reader["cargo"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return lscBuscaFunc;
        }


        public List<Funcionarios> FiltrarFuncionarioNIF(Funcionarios f)
        {
            List<Funcionarios> lscBuscaFunc = new List<Funcionarios>();
            string query = "SELECT f.id, f.nome, f.dataNasc, f.nif, f.endereco, f.telefone, f.data, c.cargo FROM funcionarios as f,cargos as c WHERE nif=@nif AND f.cargo_f = c.id_cargo;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nif", f.nif);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lscBuscaFunc.Add(new Funcionarios(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    DateTime.Parse(reader["dataNasc"].ToString()),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    DateTime.Parse(reader["data"].ToString()),
                                    reader["cargo"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return lscBuscaFunc;
        }
        public int VerificarNIF(String n)
        {
            int valor = 0;

            List<Funcionarios> lscBuscarUser = new List<Funcionarios>();
            string query = "SELECT * FROM funcionarios WHERE nif=@nif ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nif", n);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lscBuscarUser.Add(new Funcionarios( // string nome, string nif, string endereco, string telefone, int idCargo)

                                    reader["nome"].ToString(),
                                    DateTime.Parse(reader["dataNasc"].ToString()),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    Int32.Parse(reader["cargo_f"].ToString())
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
