using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linhaProducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {


                Empresas empresas = new Empresas();

                empresas.nome = "Ci&T";
                empresas.cnpj = "333333333";
                empresas.email = "246@gmail.com";


                empresas.Inserir();

                MessageBox.Show("Empresa adicionada com sucesso");



                Etapas etapa = new Etapas();

                etapa.id_processo = 3;
                etapa.nome = "Fundimento";
                etapa.ordem = "123";


                etapa.Inserir();

                MessageBox.Show("etapa adicionada com sucesso");

                Funcionarios funcionario = new Funcionarios();

                funcionario.id_empresa = 7;
                funcionario.nome = "Fundimento";
                funcionario.email = "123";
                funcionario.setSenha("abcdef");
                funcionario.setNivel(1);


                funcionario.Inserir();

                MessageBox.Show("Funcionario adicionada com sucesso");


                Clientes cliente = new Clientes();

                cliente.id_empresa = 7;
                cliente.nome = "luaksdfjanfjefje";
                cliente.email = "emailcom";
                cliente.setDocumento("abcdef");
                cliente.telefone = "123124134";

                funcionario.Inserir();

                MessageBox.Show("Cliente adicionado com sucesso");

                Insumos insumos = new Insumos();

                insumos.id_produto = 3;
                insumos.nome = "farinha";
                insumos.quantidade = 200;
                insumos.unidade = "kg";

                insumos.Inserir();

                MessageBox.Show("Insumos adicionados  com sucesso");

                LinhaProducao LP = new LinhaProducao();

                LP.id_empresa = 7;
                LP.id_setor = 4;
                LP.id_responsavel = 8;
                LP.nome = "kg";

                LP.Inserir();

                MessageBox.Show("Insumos adicionados  com sucesso");


                OrdemProducao OP = new OrdemProducao();

                OP.id_empresa = 3;
                OP.id_setor = 4;
                OP.id_cliente = 18;

                OP.Inserir();

                MessageBox.Show("Ordem de produção adicionada com sucesso");

                OrdemProducaoTemProduto OPTP = new OrdemProducaoTemProduto();

                OPTP.id_ordem = 3;
                OPTP.id_produto = 3;
                OPTP.quantidade = 1899;


                OPTP.Inserir();

                MessageBox.Show("Ordem de produção tem produto adicionada  com sucesso");


                Processos processos = new Processos();

                processos.nome = "Derretimento";
                processos.id_setor = 4;



                processos.Inserir();

                MessageBox.Show("Processo adicionado com sucesso");


                Produtos produtos = new Produtos();

                produtos.nome = "hamburguer";
                produtos.id_empresa = 4;



                produtos.Inserir();

                MessageBox.Show("Produto adicionado com sucesso");


                Setores setores = new Setores();

                setores.nome = "setor de fundição";
                setores.id_empresa = 4;
                setores.id_responsavel = 8;



                setores.Inserir();

                MessageBox.Show("Setor adicionado com sucesso");








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
