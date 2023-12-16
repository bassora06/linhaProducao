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
    public partial class PaginaNovoProcesso : Form
    {
        public PaginaNovoProcesso()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Processos processo = new Processos();

                processo.id_setor = 4;
                processo.nome = TextBoxNome.Text;


                processo.Inserir();

                MessageBox.Show("Processo adicionado com sucesso!");

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
