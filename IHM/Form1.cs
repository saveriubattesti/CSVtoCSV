using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_destCSV.Items.Add("");
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listView_destCSV.SelectedItems
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuCSVDest_Opening(object sender, CancelEventArgs e)
        {
            if (listView_destCSV.SelectedItems.Count == 0)
            {
                contextMenuCSVDest.Items["modifierToolStripMenuItem"].Enabled = false;
                contextMenuCSVDest.Items["supprimerToolStripMenuItem"].Enabled = false;
            }
            else
            {
                contextMenuCSVDest.Items["modifierToolStripMenuItem"].Enabled = true;
                contextMenuCSVDest.Items["supprimerToolStripMenuItem"].Enabled = true;
            }
        }
    }
}
