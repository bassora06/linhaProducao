using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linhaProducao
{
    internal class Etapas : Conexao
    {
        public int id;
        public int id_processo;
        public string nome;
        public string ordem;
        public DateTime data_cadastro;


        public List<Etapas> GetListaEtapas()
        {
            List<Etapas> ListaEtapa = new List<Etapas>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM etapa;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Etapas novaEtapa = new Etapas();

                            novaEtapa.id                = Convert.ToInt32(reader.GetString("id"));
                            novaEtapa.id_processo       = Convert.ToInt32(reader.GetString("id_processo"));
                            novaEtapa.nome              = reader.GetString("nome");
                            novaEtapa.ordem             = reader.GetString("ordem");
                            novaEtapa.data_cadastro     = DateTime.Parse(reader.GetString("data_cadastro"));


                            ListaEtapa.Add(novaEtapa);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaEtapa;
        }

        public bool Inserir()
        {
            try
            {

                string query = "INSERT INTO `etapa` (`nome`, `ordem`, `id_processo`) VALUES (@nome, @ordem, @id_processo);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@ordem", this.ordem),
                new MySqlParameter("@id_processo", this.id_processo),
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