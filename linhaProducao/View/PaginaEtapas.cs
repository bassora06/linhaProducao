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
    public partial class PaginaEtapas : Form
    {
        public PaginaEtapas()
        {
            InitializeComponent();

            try
            {
                Etapas etapas = new Etapas();

                listViewEtapas.Bounds = new Rectangle(new Point(15, 70), new Size(700, 600));

                listViewEtapas.View = System.Windows.Forms.View.Details;
                listViewEtapas.LabelEdit = true;
                listViewEtapas.AllowColumnReorder = true;
                listViewEtapas.CheckBoxes = true;
                listViewEtapas.FullRowSelect = true;
                listViewEtapas.GridLines = true;
                listViewEtapas.Sorting = SortOrder.Ascending;

                listViewEtapas.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ORDEM ", -2, HorizontalAlignment.Center);

                foreach (Etapas etapa in etapas.GetListaEtapas())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(etapa.id.ToString());
                    item.SubItems.Add(etapa.nome);
                    item.SubItems.Add(etapa.ordem);
                    listViewEtapas.Items.Add(item);
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
    }
}
