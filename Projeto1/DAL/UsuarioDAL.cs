using MySql.Data.MySqlClient;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.DAL
{
    public class UsuarioDAL
    {
        private string connStr = BaseDAL.connStr;
        public int InserirUsuario(Usuarios user) //metodo para guardar na BD
        {
            int registro = 0;
            string query = "INSERT INTO  usuarios (nome, cargo_u, usuario, senha, data) VALUES(@nome, @cargo, @usuario, @senha, @data)";
            //Este @ dos values é apenas pra se diferenciar do referencia anterior, poderia ser referencia1

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn; //Comando do Mysql igualado a conexao 
                    conn.Open(); //Open é um metodo do MySqlConnection e não retorna nada.

                    cmd.Parameters.AddWithValue("@nome", user.nome);
                    cmd.Parameters.AddWithValue("@cargo", user.idcargo);
                    cmd.Parameters.AddWithValue("@usuario", user.usuario);
                    cmd.Parameters.AddWithValue("@senha", user.senha);
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

        public List<Usuarios> ListarTodosUsuarios()
        {
            List<Usuarios> list_user= new List<Usuarios>();
            string query = "SELECT u.id, u.nome, c.cargo, u.usuario, u.senha, u.data FROM usuarios as u, cargos as c where u.cargo_u = c.id_cargo ORDER BY u.nome;";
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
                                list_user.Add(new Usuarios(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    reader["cargo"].ToString(),
                                    reader["usuario"].ToString(),
                                    reader["senha"].ToString(),
                                    DateTime.Parse(reader["data"].ToString())
                                    ));
                            }
                        }
                    }
                }
            }
            return list_user;
        }


        public List<Usuarios> ListarUmUsuario(Usuarios user)
        {
            List<Usuarios> list_user = new List<Usuarios>();
            string query = "SELECT u.id, u.nome, u.usuario, u.senha, c.cargo, u.data FROM usuarios as u, cargos as c where u.id = @id;";
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
                                list_user.Add(new Usuarios(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    reader["usuario"].ToString(),
                                    reader["senha"].ToString(),
                                    reader["cargo"].ToString(),
                                    DateTime.Parse(reader["data"].ToString())
                                    ));
                            }
                        }
                    }
                }
            }
            return list_user;
        }



        public int EditarUsuario(Usuarios user)
        {
            int valida = 0;
            string query = "UPDATE usuarios SET nome=@nome, cargo_u=@cargo, usuario=@usuario, senha=@senha, data=@data WHERE id= @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))

            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", user.id);
                    cmd.Parameters.AddWithValue("@nome", user.nome);
                    cmd.Parameters.AddWithValue("@cargo", user.idcargo);
                    cmd.Parameters.AddWithValue("@usuario", user.usuario);
                    cmd.Parameters.AddWithValue("@senha", user.senha);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);

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

        public int ExcluirUsuario(Usuarios user)
        {
            int valida = 0;
            string query = "DELETE FROM usuarios  WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", user.id);

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

        public List<Usuarios> FiltrarUsuarioNome(Usuarios user)
        {
            List<Usuarios> lscBuscarUser = new List<Usuarios>();
            //SELECT f.id, f.nome, f.nif, f.endereco, f.telefone, f.data, c.cargo FROM funcionarios as f,cargos as c WHERE id=@id_func AND f.cargo_f = c.id_cargo;
            string query = "SELECT u.id, u.nome, c.cargo, u.usuario, u.senha, u.data FROM usuarios as u, cargos as c WHERE u.cargo_u  =c.id_cargo AND id=@id   ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@id", user.id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lscBuscarUser.Add(new Usuarios(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                     reader["cargo"].ToString(),
                                    reader["usuario"].ToString(),
                                    reader["senha"].ToString(),
                                    DateTime.Parse(reader["data"].ToString())
                                    ));
                            }
                        }
                    }

                }
            }
            return lscBuscarUser;
        }


        public int Verificar(String s)
        {
            int valor = 0;
           
                List<Usuarios> lscBuscarUser = new List<Usuarios>();
                string query = "SELECT * FROM usuarios WHERE usuario=@usuario ";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@usuario",s);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lscBuscarUser.Add(new Usuarios(
                                        Int32.Parse(reader["id"].ToString()),
                                        reader["nome"].ToString(),
                                        Int32.Parse(reader["cargo_u"].ToString()),
                                        reader["usuario"].ToString(),
                                        reader["senha"].ToString(),
                                        DateTime.Parse(reader["data"].ToString())
                                        ));
                                }
                            }else
                            {
                                valor++;
                            }
   

                    }
                }
                return valor;
            }
        }


        public (Usuarios, int valor) Login(Usuarios user)
        {
            int valor = 0;
            Usuarios user_BD = new Usuarios();
            string query = "SELECT u.id, u.nome, c.cargo, u.usuario, u.senha, u.data FROM usuarios as u, cargos as c WHERE u.cargo_u=c.id_cargo AND usuario=@usuario AND senha=@senha; ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@usuario", user.usuario);
                    cmd.Parameters.AddWithValue("@senha", user.senha);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                user_BD = (new Usuarios(
                                    Int32.Parse(reader["id"].ToString()),
                                    reader["nome"].ToString(),
                                    reader["cargo"].ToString(),
                                    reader["usuario"].ToString(),
                                    reader["senha"].ToString(),
                                    DateTime.Parse(reader["data"].ToString())
                                    ));
                            }
                        }
                        else
                        {
                            valor++;
                        }


                    }
                }
                return (user_BD, valor);
            }
        }

        
        





    }
}
