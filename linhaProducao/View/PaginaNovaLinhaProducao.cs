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
    public partial class PaginaNovaLinhaProducao : Form
    {
        public PaginaNovaLinhaProducao()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                LinhaProducao lp = new LinhaProducao();

                lp.id_empresa = 3;
                lp.id_setor = 4;
                lp.id_responsavel = 7;
                lp.nome = TextBoxNome.Text;


                lp.Inserir();

                MessageBox.Show("Linha de produção adicionadoa com sucesso!");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
