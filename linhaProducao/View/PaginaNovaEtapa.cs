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
    public partial class PaginaNovaEtapa : Form
    {
        public PaginaNovaEtapa()
        {
            InitializeComponent();
        }

        private void TextBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Etapas etapa = new Etapas();

                etapa.id_processo = 3;
                etapa.nome = TextBoxNome.Text;
                etapa.ordem = TextBoxOrdem.Text;


                etapa.Inserir();

                MessageBox.Show("Etapa adicionada com sucesso!");

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
