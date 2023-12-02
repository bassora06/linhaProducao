using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linhaProducao
{
    internal class Processos : Conexao
    {
        public int id;
        public int id_setor;
        public string nome;
        public DateTime data_cadastro;


        public List<Processos> GetListaProcesso()
        {
            List<Processos> ListaProcesso = new List<Processos>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM processos;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Processos novoProcesso = new Processos();

                            novoProcesso.id = Convert.ToInt32(reader.GetString("id"));
                            novoProcesso.nome = reader.GetString("nome");
                            novoProcesso.id_setor = Convert.ToInt32(reader.GetString("id_setor"));
                            novoProcesso.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));


                            ListaProcesso.Add(novoProcesso);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaProcesso;
        }
        public bool Inserir()
        {
            try
            {

                string query = "INSERT INTO `processos` (`nome`, `id_setor`) VALUES (@nome, @id_setor);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_setor", this.id_setor),
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
