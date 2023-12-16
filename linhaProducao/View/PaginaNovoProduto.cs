using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linhaProducao.View
{
    public partial class PaginaNovoProduto : Form
    {
        public PaginaNovoProduto()
        {
            InitializeComponent();
        }

        private void PaginaNovoProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produto = new Produtos();

                produto.id_empresa = 3;
                produto.nome = TextBoxNome.Text;


                produto.Inserir();

                MessageBox.Show("Produto adicionado com sucesso!");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
