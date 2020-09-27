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

        private void buttonImportCSV_Click(object sender, EventArgs e)
        {
            listView_srcCSV.Clear();
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
            
            String dataNewCSV = Destination.ToMatrix(listBlocks);

            if (saveCSVDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveCSVDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(dataNewCSV);
                writer.Close();
            }
        }

        private void addItemSortie(string title)
        {
            listView_destCSV.Items.Add(title);
        }

        private void comboBox_functoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_functoid.SelectedItem == "Merge")
            {
                mergeBox.Visible = true;
                splitBox.Visible = false;
            }
            if (comboBox_functoid.SelectedItem == "Split")
            {
                mergeBox.Visible = false;
                splitBox.Visible = true;
            }
            if (comboBox_functoid.SelectedItem == "Transferer")
            {
                mergeBox.Visible = false;
                splitBox.Visible = false;

                addItemSortie(listView_srcCSV.SelectedItems[0].Text);
            }
        }

        private void merge_button_Click(object sender, EventArgs e)
        {
            var merge = new Merge();

            List<Block> listeEntre = new List<Block>();

            var car = carMerge.Text;

            foreach (ListViewItem item in listView_srcCSV.SelectedItems)
            {
                listeEntre.Add(new Block()
                {
                    Id = 1,
                    Entry = item.Text
                });


            }

            var dic = new Dictionary<string, string>();

            dic["mergeChar"] = car;

            var sortie = merge.CreateBlock(listeEntre, dic);

            addItemSortie(sortie[0].Entry);

        }

            private void listView_srcCSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_functoid.Visible = true;
        }

        private void button_executer_Click(object sender, EventArgs e)
        {
            var split = new Split();

            List<Block> listeEntre = new List<Block>();

            var car = carSep.Text;
            int nbSort;
            Int32.TryParse(nbSortie.Text, out nbSort);

            foreach (ListViewItem item in listView_srcCSV.SelectedItems)
            {
                listeEntre.Add(new Block()
                {
                    Id = 1,
                    Entry = item.Text
                });


            }

            var dic = new Dictionary<string, string>();

            dic["splitChar"] = car;

            var sortie = split.CreateBlock(listeEntre, dic, nbSort);

            foreach (Block res in sortie)
            {
                addItemSortie(res.Entry);
                Console.WriteLine(res.Entry);
            }
        }
    }
}
