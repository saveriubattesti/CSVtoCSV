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
            }


            var listeTest = new List<String>();

            listeTest.Add("truc");
            listeTest.Add("pas truc");

            foreach (string el in listeTest)
            {
                listView_srcCSV.Items.Add(el);
            }
        }

        private void button_executer_Click(object sender, EventArgs e)
        {
            if(listView_srcCSV.SelectedItems.Count != 0)
            {
                if(comboBox_functoid.SelectedItem == "Concat")
                {

                }
                if (comboBox_functoid.SelectedItem == "Split")
                {

                }
                if (comboBox_functoid.SelectedItem == "Transferer")
                {

                }
            }
           
        }

        private void saveCSVDest_Click(object sender, EventArgs e)
        {
            Stream myStream;
            DialogResult result = saveCSVDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if ((myStream = saveCSVDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }
    }
}
