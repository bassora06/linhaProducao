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
    public partial class PaginaOrdemProducao : Form
    {
        public PaginaOrdemProducao()
        {
            InitializeComponent();

            try
            {
                OrdemProducao OrdemProducoes = new OrdemProducao();

                listViewOrdemProducao.Bounds = new Rectangle(new Point(15, 70), new Size(700, 600));

                listViewOrdemProducao.View = System.Windows.Forms.View.Details;
                listViewOrdemProducao.LabelEdit = true;
                listViewOrdemProducao.AllowColumnReorder = true;
                listViewOrdemProducao.CheckBoxes = true;
                listViewOrdemProducao.FullRowSelect = true;
                listViewOrdemProducao.GridLines = true;
                listViewOrdemProducao.Sorting = SortOrder.Ascending;

                listViewOrdemProducao.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewOrdemProducao.Columns.Add("ID", -2, HorizontalAlignment.Left);

                foreach (OrdemProducao OrdemProducao in OrdemProducoes.GetListaLinhaProducao())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(OrdemProducao.id.ToString());
                    listViewOrdemProducao.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewOrdemProducao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarOrdemProducao_Click(object sender, EventArgs e)
        {
            PaginaNovaOrdemProducao form = new PaginaNovaOrdemProducao();

            form.ShowDialog();
        }
    }
}
