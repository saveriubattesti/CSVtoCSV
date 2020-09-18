namespace IHM
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("test");
            this.listView_srcCSV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_destCSV = new System.Windows.Forms.ListView();
            this.contextMenuCSVDest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonImportCSV = new System.Windows.Forms.Button();
            this.openCSVDialog = new System.Windows.Forms.OpenFileDialog();
            this.lienCSV = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveCSVDest = new System.Windows.Forms.Button();
            this.saveCSVDialog = new System.Windows.Forms.SaveFileDialog();
            this.comboBox_functoid = new System.Windows.Forms.ComboBox();
            this.splitBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_executer = new System.Windows.Forms.Button();
            this.mergeBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.merge_button = new System.Windows.Forms.Button();
            this.contextMenuCSVDest.SuspendLayout();
            this.splitBox.SuspendLayout();
            this.mergeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_srcCSV
            // 
            this.listView_srcCSV.HideSelection = false;
            this.listView_srcCSV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_srcCSV.Location = new System.Drawing.Point(12, 38);
            this.listView_srcCSV.Name = "listView_srcCSV";
            this.listView_srcCSV.Size = new System.Drawing.Size(220, 360);
            this.listView_srcCSV.TabIndex = 0;
            this.listView_srcCSV.UseCompatibleStateImageBehavior = false;
            this.listView_srcCSV.View = System.Windows.Forms.View.List;
            this.listView_srcCSV.SelectedIndexChanged += new System.EventHandler(this.listView_srcCSV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CSV Destination";
            // 
            // listView_destCSV
            // 
            this.listView_destCSV.ContextMenuStrip = this.contextMenuCSVDest;
            this.listView_destCSV.HideSelection = false;
            this.listView_destCSV.LabelEdit = true;
            this.listView_destCSV.Location = new System.Drawing.Point(568, 38);
            this.listView_destCSV.Name = "listView_destCSV";
            this.listView_destCSV.Size = new System.Drawing.Size(220, 360);
            this.listView_destCSV.TabIndex = 3;
            this.listView_destCSV.UseCompatibleStateImageBehavior = false;
            this.listView_destCSV.View = System.Windows.Forms.View.List;
            // 
            // contextMenuCSVDest
            // 
            this.contextMenuCSVDest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuCSVDest.Name = "contextMenuCSVDest";
            this.contextMenuCSVDest.Size = new System.Drawing.Size(139, 70);
            this.contextMenuCSVDest.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuCSVDest_Opening);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter...";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.modifierToolStripMenuItem.Text = "Modifier...";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer...";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // buttonImportCSV
            // 
            this.buttonImportCSV.Location = new System.Drawing.Point(12, 404);
            this.buttonImportCSV.Name = "buttonImportCSV";
            this.buttonImportCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonImportCSV.TabIndex = 4;
            this.buttonImportCSV.Text = "Parcourir";
            this.buttonImportCSV.UseVisualStyleBackColor = true;
            this.buttonImportCSV.Click += new System.EventHandler(this.buttonImportCSV_Click);
            // 
            // openCSVDialog
            // 
            this.openCSVDialog.DefaultExt = "csv";
            this.openCSVDialog.FileName = "CSV.csv";
            this.openCSVDialog.Filter = "*.csv|";
            this.openCSVDialog.InitialDirectory = "C:\\Users\\%username%\\Source\\Repos\\CSVtoCSV\\IHM\\Output";
            // 
            // lienCSV
            // 
            this.lienCSV.AutoSize = true;
            this.lienCSV.Location = new System.Drawing.Point(93, 409);
            this.lienCSV.Name = "lienCSV";
            this.lienCSV.Size = new System.Drawing.Size(0, 13);
            this.lienCSV.TabIndex = 6;
            // 
            // saveCSVDest
            // 
            this.saveCSVDest.Location = new System.Drawing.Point(713, 404);
            this.saveCSVDest.Name = "saveCSVDest";
            this.saveCSVDest.Size = new System.Drawing.Size(75, 23);
            this.saveCSVDest.TabIndex = 7;
            this.saveCSVDest.Text = "Enregistrer";
            this.saveCSVDest.UseVisualStyleBackColor = true;
            this.saveCSVDest.Click += new System.EventHandler(this.saveCSVDest_Click);
            // 
            // saveCSVDialog
            // 
            this.saveCSVDialog.FileName = "newCSV.csv";
            this.saveCSVDialog.Filter = "*.csv|";
            // 
            // comboBox_functoid
            // 
            this.comboBox_functoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_functoid.FormattingEnabled = true;
            this.comboBox_functoid.Items.AddRange(new object[] {
            "Merge",
            "Split",
            "Transferer"});
            this.comboBox_functoid.Location = new System.Drawing.Point(340, 137);
            this.comboBox_functoid.Name = "comboBox_functoid";
            this.comboBox_functoid.Size = new System.Drawing.Size(121, 72);
            this.comboBox_functoid.TabIndex = 8;
            this.comboBox_functoid.Visible = false;
            this.comboBox_functoid.SelectedIndexChanged += new System.EventHandler(this.comboBox_functoid_SelectedIndexChanged);
            // 
            // splitBox
            // 
            this.splitBox.Controls.Add(this.button_executer);
            this.splitBox.Controls.Add(this.textBox2);
            this.splitBox.Controls.Add(this.label4);
            this.splitBox.Location = new System.Drawing.Point(304, 215);
            this.splitBox.Name = "splitBox";
            this.splitBox.Size = new System.Drawing.Size(200, 100);
            this.splitBox.TabIndex = 12;
            this.splitBox.TabStop = false;
            this.splitBox.Text = "Split";
            this.splitBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Caractère Séparateur";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 20);
            this.textBox2.TabIndex = 14;
            // 
            // button_executer
            // 
            this.button_executer.Location = new System.Drawing.Point(66, 71);
            this.button_executer.Name = "button_executer";
            this.button_executer.Size = new System.Drawing.Size(75, 23);
            this.button_executer.TabIndex = 15;
            this.button_executer.Text = "Exécuter";
            this.button_executer.UseVisualStyleBackColor = true;
            // 
            // mergeBox
            // 
            this.mergeBox.Controls.Add(this.merge_button);
            this.mergeBox.Controls.Add(this.textBox3);
            this.mergeBox.Controls.Add(this.label6);
            this.mergeBox.Controls.Add(this.label5);
            this.mergeBox.Controls.Add(this.textBox1);
            this.mergeBox.Controls.Add(this.label3);
            this.mergeBox.Location = new System.Drawing.Point(304, 31);
            this.mergeBox.Name = "mergeBox";
            this.mergeBox.Size = new System.Drawing.Size(200, 100);
            this.mergeBox.TabIndex = 13;
            this.mergeBox.TabStop = false;
            this.mergeBox.Text = "Merge";
            this.mergeBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de cellules";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Caractère de merge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sélectionnez les cellules sources";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(28, 20);
            this.textBox3.TabIndex = 4;
            // 
            // merge_button
            // 
            this.merge_button.Location = new System.Drawing.Point(66, 76);
            this.merge_button.Name = "merge_button";
            this.merge_button.Size = new System.Drawing.Size(75, 23);
            this.merge_button.TabIndex = 5;
            this.merge_button.Text = "Valider";
            this.merge_button.UseVisualStyleBackColor = true;
            this.merge_button.Click += new System.EventHandler(this.merge_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.mergeBox);
            this.Controls.Add(this.comboBox_functoid);
            this.Controls.Add(this.saveCSVDest);
            this.Controls.Add(this.lienCSV);
            this.Controls.Add(this.buttonImportCSV);
            this.Controls.Add(this.listView_destCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_srcCSV);
            this.Controls.Add(this.splitBox);
            this.Name = "Form1";
            this.Text = "CSVtoCSV";
            this.contextMenuCSVDest.ResumeLayout(false);
            this.splitBox.ResumeLayout(false);
            this.splitBox.PerformLayout();
            this.mergeBox.ResumeLayout(false);
            this.mergeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_srcCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_destCSV;
        private System.Windows.Forms.ContextMenuStrip contextMenuCSVDest;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Button buttonImportCSV;
        private System.Windows.Forms.OpenFileDialog openCSVDialog;
        private System.Windows.Forms.Label lienCSV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button saveCSVDest;
        private System.Windows.Forms.SaveFileDialog saveCSVDialog;
        private System.Windows.Forms.ComboBox comboBox_functoid;
        private System.Windows.Forms.GroupBox splitBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_executer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox mergeBox;
        private System.Windows.Forms.Button merge_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

