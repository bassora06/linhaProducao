using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linhaProducao
{
    internal class Produtos : Conexao
    {
        public int id;
        public int id_empresa;
        public string nome; 
        public DateTime data_cadastro;


        public List<Produtos> GetListaProdutos()
        {
            List<Produtos> ListaProdutos = new List<Produtos>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM produtos;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produtos novoProduto = new Produtos();

                            novoProduto.id              = Convert.ToInt32(reader.GetString("id"));
                            novoProduto.id_empresa      = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoProduto.nome            = reader.GetString("nome");
                            novoProduto.data_cadastro   = DateTime.Parse(reader.GetString("data_cadastro"));


                            ListaProdutos.Add(novoProduto);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaProdutos;
        }
        public bool Inserir()
        {
            try
            {

                string query = "INSERT INTO `produtos` (`nome`, `id_empresa`) VALUES (@nome, @id_empresa);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_empresa", this.id_empresa),
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
