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
    public partial class PaginaNovoCadastro : Form
    {
        public PaginaNovoCadastro()
        {
            InitializeComponent();

           

            try
            {
                List<Clientes> listaClientes = new List<Clientes>();

                Clientes cliente = new Clientes();

                listaClientes = cliente.GetListaClientes();

                ComboBoxCliente.DataSource = listaClientes;
                ComboBoxCliente.DisplayMember = "Nome";
                ComboBoxCliente.ValueMember = "Id";
                ComboBoxCliente.Update();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = new Clientes();

                cliente.id_empresa = 3;
                cliente.nome = TextBoxNome.Text;
                cliente.email = TextBoxEmail.Text;
                cliente.setDocumento(TextBoxDocumento.Text);
                cliente.telefone = TextBoxTelefone.Text;

                cliente.Inserir();

                MessageBox.Show("Cliente adicionado com sucesso!");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PaginaNovoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
