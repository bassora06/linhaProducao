using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linhaProducao
{
    internal class Setores : Conexao { 

        public int id;
        public int id_empresa;
        public int id_responsavel;
        public string nome;
        public DateTime data_cadastro;


        public List<Setores> GetListaProdutos()
        {
            List<Setores> ListaSetores = new List<Setores>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM setor;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Setores novoSetor = new Setores();

                            novoSetor.id             = Convert.ToInt32(reader.GetString("id"));
                            novoSetor.id_empresa     = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoSetor.id_responsavel = Convert.ToInt32(reader.GetString("id_responsavel"));
                            novoSetor.nome           = reader.GetString("nome");
                            novoSetor.data_cadastro  = DateTime.Parse(reader.GetString("data_cadastro"));


                            ListaSetores.Add(novoSetor);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaSetores;
        }
        public bool Inserir()
        {
            try
            {
              
                string query = "INSERT INTO `setores` (`nome`, `id_empresa`, `id_responsavel`) VALUES (@nome, @id_empresa, @id_responsavel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_responsavel", this.id_responsavel),
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
