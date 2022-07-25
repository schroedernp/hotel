using MySql.Data.MySqlClient;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    public class FornecedoresDAL
    {
        private string connStr = BaseDAL.connStr; // Poderia ser deste outro jeito: BaseDAL.connStr = "datasource=localhost;port=3306;username=root;password=;database=salarios;SslMode=none"; 
                                                  //datasource pode ser o ip da minha maquina

        public int InserirFornecedor(Fornecedores fornecedor) //metodo para guardar na BD
        {
            int registro = 0;
            string query = "INSERT INTO fornecedores (nome, nif, endereco, telefone, email) VALUES(@nome, @nif, @endereco, @telefone, @email)";
            //Este @ dos values é apenas pra se diferenciar do referencia anterior, poderia ser referencia1

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn; //Comando do Mysql igualado a conexao 
                    conn.Open(); //Open é um metodo do MySqlConnection e não retorna nada.

                    cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
                    cmd.Parameters.AddWithValue("@nif", fornecedor.nif);
                    cmd.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                    cmd.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                    cmd.Parameters.AddWithValue("@email", fornecedor.email);

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

      

        public int EditarFornecedores(Fornecedores fornecedor)
        {
            int valida = 0;
            string query = "UPDATE fornecedores SET nome=@nome,  nif=@nif, endereco=@endereco, telefone=@telefone, email=@email WHERE id= @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", fornecedor.id);
                    cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
                    cmd.Parameters.AddWithValue("@nif", fornecedor.nif);
                    cmd.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                    cmd.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                    cmd.Parameters.AddWithValue("@email", fornecedor.email);

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

        public int ExcluirFornecedores(Fornecedores fornecedor)
        {
            int valida = 0;
            string query = "DELETE FROM fornecedores WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", fornecedor.id);


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
        public List<Fornecedores> ListarTodosFornecedores()
        {
            List<Fornecedores> listfornecedores = new List<Fornecedores>();
            string query = "SELECT * FROM fornecedores as f ORDER BY f.nome";
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
                                listfornecedores.Add(new Fornecedores(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    reader["email"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return listfornecedores;
        }


        public List<Fornecedores> FiltrarFornecedoroNome(Fornecedores f)
        {
            List<Fornecedores> lscBuscaForne = new List<Fornecedores>();
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
                                lscBuscaForne.Add(new Fornecedores(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    reader["email"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return lscBuscaForne;
        }

            public List<Fornecedores> FiltrarFornecedorNIF(String forne_nif)
        {
            List<Fornecedores> lstBuscarFornecedor = new List<Fornecedores>();
            //string query = "SELECT f.id, f.nome, f.nif, f.endereco, f.telefone, f.email FROM fornecedores as f WHERE REPLACE(f.nif, ' ', '') =@nif";
            string query = "SELECT f.id, f.nome, f.nif, f.endereco, f.telefone, f.email FROM fornecedores as f WHERE f.nif =@nif";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@nif", forne_nif);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lstBuscarFornecedor.Add(new Fornecedores(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    reader["email"].ToString()
                                    ));
                            }
                        }
                    }

                }
            }
            return lstBuscarFornecedor;
        }
        public int BuscarNIF(String n)
        {
            int valor = 0;

            List<Fornecedores> lstBuscarFornecedor = new List<Fornecedores>();
            string query = "SELECT * FROM fornecedores as f WHERE nif=@nif ";
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
                                lstBuscarFornecedor.Add(new Fornecedores( // string nome, string nif, string endereco, string telefone, int idCargo)
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    reader["nif"].ToString(),
                                    reader["endereco"].ToString(),
                                    reader["telefone"].ToString(),
                                    reader["email"].ToString()
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
