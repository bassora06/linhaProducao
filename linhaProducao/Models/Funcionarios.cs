using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linhaProducao
{
    internal class Funcionarios : Conexao
    {
        public int id;

        public int id_empresa;

        public string nome;

        public string email;

        private string senha;

        private int nivel;

        public DateTime data_cadastro;

        public bool logado = false;

        public void setSenha(string senha)
        {
            //  this.senha = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt());
            this.senha = senha;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public void setNivel(int nivel)
        {
            this.nivel = nivel;
        }

        public int getNivel()
        {
            return this.nivel;
        }


        public List<Funcionarios> GetListaFuncionarios()
        {
            List<Funcionarios> listaFuncionario = new List<Funcionarios>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionarios;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcionarios novoFuncionario = new Funcionarios();

                            novoFuncionario.id              = Convert.ToInt32(reader.GetString("id"));
                            novoFuncionario.id_empresa      = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoFuncionario.nome            = reader.GetString("nome");
                            novoFuncionario.email           = reader.GetString("email");
                            novoFuncionario.data_cadastro   = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoFuncionario.setSenha(reader.GetString("senha"));
                            novoFuncionario.setNivel(Convert.ToInt32(reader.GetString("nivel")));


                            listaFuncionario.Add(novoFuncionario);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaFuncionario;
        }

        public Funcionarios getFuncionarioPorEmailESenha()
        {
            Funcionarios funcionarios = new Funcionarios();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM funcionarios where email = '"+ this.email + "' AND senha = '"+ this.senha +"';";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.id = Convert.ToInt32( reader.GetString("id"));
                            this.nome = reader.GetString("nome");
                            this.email = reader.GetString("email");
                            this.setNivel(Convert.ToInt16(reader.GetString("nivel")));

                            this.logado = true;
                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return this;
        }
        public bool Inserir()
        {
            try
            {

                string query = "INSERT INTO `funcionarios` (`id_empresa`, `nome`, `email`, `senha`, `nivel`) VALUES (@id_empresa, @nome, @email, @senha, @nivel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@email", this.email),
                new MySqlParameter("@senha", this.senha),
                new MySqlParameter("@nivel", this.nivel)
                };

                this.ExecuteQueryWithParameters(query, param);


                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
