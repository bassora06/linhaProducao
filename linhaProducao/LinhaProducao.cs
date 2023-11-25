﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linhaProducao
{
    internal class LinhaProducao : Conexao
    {
        public int id;
        public int id_empresa; 
        public int id_setor;
        public int id_responsavel;
        public string nome;
        public DateTime data_cadastro;


        public List<LinhaProducao> GetListaLinhaProducao()
        {
            List<LinhaProducao> ListaLinhaProducao = new List<LinhaProducao>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM LinhaProducao;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LinhaProducao novaLinhaProducao = new LinhaProducao();

                            novaLinhaProducao.id = Convert.ToInt32(reader.GetString("id"));
                            novaLinhaProducao.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novaLinhaProducao.id_setor = Convert.ToInt32(reader.GetString("id_setor"));
                            novaLinhaProducao.id_responsavel = Convert.ToInt32(reader.GetString("id_responsavel"));
                            novaLinhaProducao.nome = reader.GetString("nome");
                            novaLinhaProducao.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));


                            ListaLinhaProducao.Add(novaLinhaProducao);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaLinhaProducao;
        }
        public bool Inserir()
        {
            try
            {

                string query = "INSERT INTO `linha_producao` (`nome`, `id_empresa`, `id_setor`, `id_responsavel`) VALUES (@nome, @id_empresa, @id_setor, @id_responsavel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_setor", this.id_setor),
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
