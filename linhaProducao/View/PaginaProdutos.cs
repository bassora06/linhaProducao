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
    public partial class PaginaProdutos : Form
    {
        public PaginaProdutos()
        {
            InitializeComponent();

            try
            {
                Produtos produtos = new Produtos();

                listViewProdutos.Bounds = new Rectangle(new Point(15, 70), new Size(700, 600));

                listViewProdutos.View = System.Windows.Forms.View.Details;
                listViewProdutos.LabelEdit = true;
                listViewProdutos.AllowColumnReorder = true;
                listViewProdutos.CheckBoxes = true;
                listViewProdutos.FullRowSelect = true;
                listViewProdutos.GridLines = true;
                listViewProdutos.Sorting = SortOrder.Ascending;

                listViewProdutos.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewProdutos.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewProdutos.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Produtos produto in produtos.GetListaProdutos())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(produto.id.ToString());
                    item.SubItems.Add(produto.nome);
                    listViewProdutos.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            PaginaNovoProduto form = new PaginaNovoProduto();

            form.ShowDialog();
        }
    }
}
