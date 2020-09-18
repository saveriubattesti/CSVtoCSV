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
            this.button_executer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuCSVDest.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_srcCSV
            // 
            this.listView_srcCSV.HideSelection = false;
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
            "Concat",
            "Split",
            "Transferer"});
            this.comboBox_functoid.Location = new System.Drawing.Point(340, 137);
            this.comboBox_functoid.Name = "comboBox_functoid";
            this.comboBox_functoid.Size = new System.Drawing.Size(121, 72);
            this.comboBox_functoid.TabIndex = 8;
            // 
            // button_executer
            // 
            this.button_executer.Location = new System.Drawing.Point(358, 274);
            this.button_executer.Name = "button_executer";
            this.button_executer.Size = new System.Drawing.Size(75, 23);
            this.button_executer.TabIndex = 9;
            this.button_executer.Text = "Executer";
            this.button_executer.UseVisualStyleBackColor = true;
            this.button_executer.Click += new System.EventHandler(this.button_executer_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Caractère Séparateur";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_executer);
            this.Controls.Add(this.comboBox_functoid);
            this.Controls.Add(this.saveCSVDest);
            this.Controls.Add(this.lienCSV);
            this.Controls.Add(this.buttonImportCSV);
            this.Controls.Add(this.listView_destCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_srcCSV);
            this.Name = "Form1";
            this.Text = "CSVtoCSV";
            this.contextMenuCSVDest.ResumeLayout(false);
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
        private System.Windows.Forms.Button button_executer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

