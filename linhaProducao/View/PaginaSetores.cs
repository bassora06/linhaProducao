﻿using System;
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
    public partial class PaginaSetores : Form
    {
        public PaginaSetores()
        {
            InitializeComponent();

            try
            {
                Setores setores = new Setores();

                listViewSetores.Bounds = new Rectangle(new Point(15, 70), new Size(700, 600));

                listViewSetores.View = System.Windows.Forms.View.Details;
                listViewSetores.LabelEdit = true;
                listViewSetores.AllowColumnReorder = true;
                listViewSetores.CheckBoxes = true;
                listViewSetores.FullRowSelect = true;
                listViewSetores.GridLines = true;
                listViewSetores.Sorting = SortOrder.Ascending;

                listViewSetores.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewSetores.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewSetores.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (Setores setor in setores.GetListaSetores())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(setor.id.ToString());
                    item.SubItems.Add(setor.nome);
                    listViewSetores.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewSetores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarSetor_Click(object sender, EventArgs e)
        {
            PaginaNovoSetor form = new PaginaNovoSetor();

            form.ShowDialog();
        }
    }
}
