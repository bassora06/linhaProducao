using linhaProducao.View;
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
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = TextBoxEmail.Text;
                string senha = TextBoxSenha.Text;

                Funcionarios funcionario = new Funcionarios();

                funcionario.email = email;
                funcionario.setSenha(senha);

                funcionario.getFuncionarioPorEmailESenha();

                if (funcionario.logado)
                {
                    this.Hide();

                    PaginaPrincipal paginaPrincipal = new PaginaPrincipal();

                    paginaPrincipal.Show();
                }
                else
                {
                    throw new Exception("Erro ao realizar login, credenciais incorretas ou não encontradas");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
