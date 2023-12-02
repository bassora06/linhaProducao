﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linhaProducao
{
    internal class Clientes : Conexao
    {
        public int id;
        public int id_empresa;
        public string nome;
        public string telefone;
        private string documento;
        public string email;
        public DateTime data_cadastro;

        public void setDocumento(string documento)
        {
            this.documento = documento;
        }

        public string getDocumento()
        {
            return this.documento;
        }


        public List<Clientes> GetListaClientes()
        {
            List<Clientes> ListaClientes = new List<Clientes>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM clientes;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clientes novoCliente = new Clientes();

                            novoCliente.id = Convert.ToInt32(reader.GetString("id"));
                            novoCliente.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoCliente.nome = reader.GetString("nome");
                            novoCliente.telefone = reader.GetString("telefone");
                            novoCliente.email = reader.GetString("email");
                            novoCliente.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            novoCliente.setDocumento(reader.GetString("documento"));

                            ListaClientes.Add(novoCliente);

                        }


                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return ListaClientes;
        }

        public bool Inserir()
        {
            try
            {

                string query = "INSERT INTO `clientes` (`id_empresa`, `nome`, `telefone`, `documento`, `email`) VALUES (@id_empresa, @nome, @telefone, @documento, @email);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@telefone", this.telefone),
                new MySqlParameter("@documento", this.documento),
                new MySqlParameter("@email", this.email),
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
