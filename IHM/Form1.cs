using DataContracts;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listView_destCSV.LabelEdit = true;
            listView_destCSV.SelectedItems[0].BeginEdit();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_destCSV.Items.RemoveAt(listView_destCSV.SelectedItems[0].Index);
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

        private void listView_srcCSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonImportCSV_Click(object sender, EventArgs e)
        {
            DialogResult result = openCSVDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string CSVfile = openCSVDialog.FileName;

                lienCSV.Text = CSVfile;

                var source = new Source();

                var listeEntry = source.getData(CSVfile);

                foreach (DataContracts.Block el in listeEntry)
                {
                    listView_srcCSV.Items.Add(el.Entry);
                }

            }

            
        }

        private void saveCSVDest_Click(object sender, EventArgs e)
        {
            var listBlocks = new List<Block>();
            foreach(ListViewItem item in listView_destCSV.Items)
            {
                listBlocks.Add(new Block()
                {
                    Id = item.Index,
                    Entry = item.Text
                });
            }

            String dataNewCSV = "non";//ToMatrix(listBlocks);

            if (saveCSVDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveCSVDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(dataNewCSV);
                writer.Close();
            }
        }

        private void button_executer_Click_1(object sender, EventArgs e)
        {
            if (listView_srcCSV.SelectedItems.Count != 0)
            {
                if (comboBox_functoid.SelectedItem == "Concat")
                {

                }
                if (comboBox_functoid.SelectedItem == "Split")
                {

                }
                if (comboBox_functoid.SelectedItem == "Transferer")
                {
                    addItemSortie(listView_srcCSV.SelectedItems[0].Text);
                }
            }
        }

        private void addItemSortie(string title)
        {
            listView_destCSV.Items.Add(title);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
