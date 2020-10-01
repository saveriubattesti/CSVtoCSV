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
        private List<List<Block>> listOfAllColumns;
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
            string user = Environment.UserName;
            openCSVDialog.InitialDirectory = "C:\\Users\\" + user + "\\Source\\Repos\\CSVtoCSV\\IHM\\Input";
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
                this.listOfAllColumns = source.MakeColunms(CSVfile, listeEntry);

            }


        }

        private void saveCSVDest_Click(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            saveCSVDialog.InitialDirectory = "C:\\Users\\" + user + "\\Source\\Repos\\CSVtoCSV\\IHM\\Output";

            
            
            String dataNewCSV = Destination.generateCSV(listOfAllColumns);

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
            if ( comboBox_functoid.SelectedItem == "Merge")
            {
                mergeBox.Visible = true;
                splitBox.Visible = false;
            }
            if (comboBox_functoid.SelectedItem == "Split")
            {
                mergeBox.Visible = false;
                splitBox.Visible = true;
            }

        }

        private void merge_button_Click(object sender, EventArgs e)
        {
            var merge = new Merge();

            List<Int32> idColumsShouldBeMerged = new List<Int32>();
            var car = carMerge.Text;
            foreach (ListViewItem item in listView_srcCSV.SelectedItems)
            {
  
                idColumsShouldBeMerged.Add(item.Index);
            }

            var sortie = merge.CreateBlock(listOfAllColumns, idColumsShouldBeMerged, car.ToCharArray()[0]);
            listOfAllColumns.Add(sortie[0]);
            for (var i = idColumsShouldBeMerged.Count-1; i >= 0; i--)
            {
                listOfAllColumns.RemoveAt(idColumsShouldBeMerged[i]);
                listView_srcCSV.Items.RemoveAt(i);
                    
            }
            listView_srcCSV.Items.Add(sortie[0][0].Entry);
            addItemSortie(sortie[0][0].Entry);

        }

            private void listView_srcCSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_functoid.Visible = true;
        }

        private void button_executer_Click(object sender, EventArgs e)
        {
            var split = new Split();

            List<Int32> idColumsShouldBeSplit= new List<Int32>();
            var car = carSep.Text;

            foreach (ListViewItem item in listView_srcCSV.SelectedItems)
            {
    
                idColumsShouldBeSplit.Add(item.Index);

            }

            var sortie = split.CreateBlock(listOfAllColumns, idColumsShouldBeSplit, car.ToCharArray()[0]);

            for (var i = idColumsShouldBeSplit.Count - 1; i >= 0; i--)
            {
                listOfAllColumns.RemoveAt(idColumsShouldBeSplit[i]);
            }
            foreach (List<Block> res in sortie)
            {
                listOfAllColumns.Add(res);
                addItemSortie(res[0].Entry);
                listView_srcCSV.Items.Add(res[0].Entry);
            }

            
        }


    }
}
