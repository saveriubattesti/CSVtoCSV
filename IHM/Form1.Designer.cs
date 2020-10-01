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
            this.splitBox = new System.Windows.Forms.GroupBox();
            this.button_executer = new System.Windows.Forms.Button();
            this.carSep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mergeBox = new System.Windows.Forms.GroupBox();
            this.merge_button = new System.Windows.Forms.Button();
            this.carMerge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuCSVDest.SuspendLayout();
            this.splitBox.SuspendLayout();
            this.mergeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_srcCSV
            // 
            this.listView_srcCSV.HideSelection = false;
            this.listView_srcCSV.Location = new System.Drawing.Point(18, 58);
            this.listView_srcCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_srcCSV.Name = "listView_srcCSV";
            this.listView_srcCSV.Size = new System.Drawing.Size(328, 552);
            this.listView_srcCSV.TabIndex = 0;
            this.listView_srcCSV.UseCompatibleStateImageBehavior = false;
            this.listView_srcCSV.View = System.Windows.Forms.View.List;
            this.listView_srcCSV.SelectedIndexChanged += new System.EventHandler(this.listView_srcCSV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1056, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CSV Destination";
            // 
            // listView_destCSV
            // 
            this.listView_destCSV.ContextMenuStrip = this.contextMenuCSVDest;
            this.listView_destCSV.HideSelection = false;
            this.listView_destCSV.LabelEdit = true;
            this.listView_destCSV.Location = new System.Drawing.Point(852, 58);
            this.listView_destCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_destCSV.Name = "listView_destCSV";
            this.listView_destCSV.Size = new System.Drawing.Size(328, 552);
            this.listView_destCSV.TabIndex = 3;
            this.listView_destCSV.UseCompatibleStateImageBehavior = false;
            this.listView_destCSV.View = System.Windows.Forms.View.List;
            // 
            // contextMenuCSVDest
            // 
            this.contextMenuCSVDest.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuCSVDest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuCSVDest.Name = "contextMenuCSVDest";
            this.contextMenuCSVDest.Size = new System.Drawing.Size(180, 100);
            this.contextMenuCSVDest.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuCSVDest_Opening);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.ajouterToolStripMenuItem.Text = "Ajouter...";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.modifierToolStripMenuItem.Text = "Modifier...";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.supprimerToolStripMenuItem.Text = "Supprimer...";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // buttonImportCSV
            // 
            this.buttonImportCSV.Location = new System.Drawing.Point(18, 622);
            this.buttonImportCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImportCSV.Name = "buttonImportCSV";
            this.buttonImportCSV.Size = new System.Drawing.Size(112, 35);
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
            this.lienCSV.Location = new System.Drawing.Point(140, 629);
            this.lienCSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lienCSV.Name = "lienCSV";
            this.lienCSV.Size = new System.Drawing.Size(0, 20);
            this.lienCSV.TabIndex = 6;
            // 
            // saveCSVDest
            // 
            this.saveCSVDest.Location = new System.Drawing.Point(1070, 622);
            this.saveCSVDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveCSVDest.Name = "saveCSVDest";
            this.saveCSVDest.Size = new System.Drawing.Size(112, 35);
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
            this.comboBox_functoid.Location = new System.Drawing.Point(510, 211);
            this.comboBox_functoid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_functoid.Name = "comboBox_functoid";
            this.comboBox_functoid.Size = new System.Drawing.Size(180, 109);
            this.comboBox_functoid.TabIndex = 8;
            this.comboBox_functoid.Visible = false;
            this.comboBox_functoid.SelectedIndexChanged += new System.EventHandler(this.comboBox_functoid_SelectedIndexChanged);
            // 
            // splitBox
            // 
            this.splitBox.Controls.Add(this.button_executer);
            this.splitBox.Controls.Add(this.carSep);
            this.splitBox.Controls.Add(this.label4);
            this.splitBox.Location = new System.Drawing.Point(456, 331);
            this.splitBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitBox.Name = "splitBox";
            this.splitBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitBox.Size = new System.Drawing.Size(300, 154);
            this.splitBox.TabIndex = 12;
            this.splitBox.TabStop = false;
            this.splitBox.Text = "Split";
            this.splitBox.Visible = false;
            // 
            // button_executer
            // 
            this.button_executer.Location = new System.Drawing.Point(99, 109);
            this.button_executer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_executer.Name = "button_executer";
            this.button_executer.Size = new System.Drawing.Size(112, 35);
            this.button_executer.TabIndex = 15;
            this.button_executer.Text = "Exécuter";
            this.button_executer.UseVisualStyleBackColor = true;
            this.button_executer.Click += new System.EventHandler(this.button_executer_Click);
            // 
            // carSep
            // 
            this.carSep.Location = new System.Drawing.Point(220, 20);
            this.carSep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carSep.Name = "carSep";
            this.carSep.Size = new System.Drawing.Size(40, 26);
            this.carSep.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Caractère Séparateur";
            // 
            // mergeBox
            // 
            this.mergeBox.Controls.Add(this.merge_button);
            this.mergeBox.Controls.Add(this.carMerge);
            this.mergeBox.Controls.Add(this.label6);
            this.mergeBox.Controls.Add(this.label5);
            this.mergeBox.Location = new System.Drawing.Point(456, 48);
            this.mergeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mergeBox.Name = "mergeBox";
            this.mergeBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mergeBox.Size = new System.Drawing.Size(300, 154);
            this.mergeBox.TabIndex = 13;
            this.mergeBox.TabStop = false;
            this.mergeBox.Text = "Merge";
            this.mergeBox.Visible = false;
            // 
            // merge_button
            // 
            this.merge_button.Location = new System.Drawing.Point(99, 117);
            this.merge_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.merge_button.Name = "merge_button";
            this.merge_button.Size = new System.Drawing.Size(112, 35);
            this.merge_button.TabIndex = 5;
            this.merge_button.Text = "Valider";
            this.merge_button.UseVisualStyleBackColor = true;
            this.merge_button.Click += new System.EventHandler(this.merge_button_Click);
            // 
            // carMerge
            // 
            this.carMerge.Location = new System.Drawing.Point(220, 40);
            this.carMerge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carMerge.Name = "carMerge";
            this.carMerge.Size = new System.Drawing.Size(40, 26);
            this.carMerge.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sélectionnez les cellules sources";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Caractère de merge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 709);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox carSep;
        private System.Windows.Forms.GroupBox mergeBox;
        private System.Windows.Forms.Button merge_button;
        private System.Windows.Forms.TextBox carMerge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

