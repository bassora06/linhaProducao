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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario;

            panelConteudo.Controls.Clear();

            formulario = panelConteudo.Controls.OfType<Form>().FirstOrDefault();

            if (formulario == null) 
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;

                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized) 
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

                formulario.BringToFront();
            }

        }
        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirForm<PaginaClientes>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirForm<PaginaProdutos>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirForm<PaginaLinhaProducao>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirForm<PaginaOrdemProducao>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirForm<PaginaSetores>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirForm<PaginaProcessos>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirForm<PaginaEtapas>();
        }
    }
}
