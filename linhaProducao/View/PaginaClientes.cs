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
    public partial class PaginaClientes : Form
    {
        public PaginaClientes()
        {
            InitializeComponent();

            try
            {
                Clientes clientes = new Clientes();

                listViewClientes.Bounds = new Rectangle(new Point(15 , 70), new Size(700, 600));

                listViewClientes.View = System.Windows.Forms.View.Details;
                listViewClientes.LabelEdit = true;
                listViewClientes.AllowColumnReorder = true;
                listViewClientes.CheckBoxes = true;
                listViewClientes.FullRowSelect = true;
                listViewClientes.GridLines = true;
                listViewClientes.Sorting = SortOrder.Ascending;

                listViewClientes.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("EMAIL", -2, HorizontalAlignment.Center);
                listViewClientes.Columns.Add("TELEFONE", -2, HorizontalAlignment.Center);
                listViewClientes.Columns.Add("DOCUMENTO", -2, HorizontalAlignment.Center);

                foreach (Clientes cliente in clientes.GetListaClientes())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(cliente.id.ToString());
                    item.SubItems.Add(cliente.nome);
                    item.SubItems.Add(cliente.email);
                    item.SubItems.Add(cliente.telefone);
                    item.SubItems.Add(cliente.getDocumento());
                    listViewClientes.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           PaginaNovoCadastro form = new PaginaNovoCadastro();

           form.ShowDialog();
        }
    }
}
