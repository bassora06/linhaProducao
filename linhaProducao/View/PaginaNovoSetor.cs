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
    public partial class PaginaNovoSetor : Form
    {
        public PaginaNovoSetor()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Setores setor = new Setores();

                setor.id_empresa = 3;
                setor.id_responsavel = 7;
                setor.nome = TextBoxNome.Text;


                setor.Inserir();

                MessageBox.Show("Produto adicionado com sucesso!");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
