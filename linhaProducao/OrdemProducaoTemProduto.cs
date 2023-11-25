using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linhaProducao
{
    internal class OrdemProducaoTemProduto : Conexao
    {
        public int id;
        public int id_ordem;
        public int id_produto;
        public int quantidade;
        public DateTime data_cadastro;


        public List<OrdemProducaoTemProduto> GetListaOrdemProducaoTemProduto()
        {
            List<OrdemProducaoTemProduto> ListaOrdemProducaoTemProduto = new List<OrdemProducaoTemProduto>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM ordem_producao_tem_produto;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrdemProducaoTemProduto novaOrdemProducaoTemProduto = new OrdemProducaoTemProduto();

                            novaOrdemProducaoTemProduto.id = Convert.ToInt32(reader.GetString("id"));
                            novaOrdemProducaoTemProduto.id_ordem = Convert.ToInt32(reader.GetString("id_ordem"));
                            novaOrdemProducaoTemProduto.id_produto = Convert.ToInt32(reader.GetString("id_produto"));
                            novaOrdemProducaoTemProduto.quantidade = Convert.ToInt32(reader.GetString("quantidade"));
                            novaOrdemProducaoTemProduto.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));


                            ListaOrdemProducaoTemProduto.Add(novaOrdemProducaoTemProduto);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaOrdemProducaoTemProduto;
        }
        public bool Inserir()
        {
            try
            {

                string query = "INSERT INTO `ordem_producao_tem_produto` (`id_ordem`, `id_produto`, `quantidade`) VALUES (@id_ordem, @id_produto, @quantidade);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_ordem", this.id_ordem),
                new MySqlParameter("@id_produto", this.id_produto),
                new MySqlParameter("@quantidade", this.quantidade),
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
