namespace Gestion_de_projet.Forms
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MIT_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MIT_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TBC_Project = new System.Windows.Forms.TabControl();
            this.TBP_ListProject = new System.Windows.Forms.TabPage();
            this.DTG_Project = new System.Windows.Forms.DataGridView();
            this.TBP_ListTask = new System.Windows.Forms.TabPage();
            this.DTG_ListTask = new System.Windows.Forms.DataGridView();
            this.TBP_ListTypeTask = new System.Windows.Forms.TabPage();
            this.DTG_ListeTaskType = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.TBC_Project.SuspendLayout();
            this.TBP_ListProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Project)).BeginInit();
            this.TBP_ListTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_ListTask)).BeginInit();
            this.TBP_ListTypeTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_ListeTaskType)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Save,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // TSM_Save
            // 
            this.TSM_Save.Name = "TSM_Save";
            this.TSM_Save.Size = new System.Drawing.Size(143, 22);
            this.TSM_Save.Text = "Sauvergarder";
            this.TSM_Save.Click += new System.EventHandler(this.TSM_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Add,
            this.toolStripSeparator2,
            this.MIT_Open,
            this.toolStripSeparator3,
            this.MIT_Delete});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(129, 22);
            this.BTN_Add.Text = "Ajouter";
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // MIT_Open
            // 
            this.MIT_Open.Name = "MIT_Open";
            this.MIT_Open.Size = new System.Drawing.Size(129, 22);
            this.MIT_Open.Text = "Ouvrir";
            this.MIT_Open.Click += new System.EventHandler(this.MIT_Open_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(126, 6);
            // 
            // MIT_Delete
            // 
            this.MIT_Delete.Name = "MIT_Delete";
            this.MIT_Delete.Size = new System.Drawing.Size(129, 22);
            this.MIT_Delete.Text = "Supprimer";
            this.MIT_Delete.Click += new System.EventHandler(this.MIT_Delete_Click);
            // 
            // TBC_Project
            // 
            this.TBC_Project.Controls.Add(this.TBP_ListProject);
            this.TBC_Project.Controls.Add(this.TBP_ListTask);
            this.TBC_Project.Controls.Add(this.TBP_ListTypeTask);
            this.TBC_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBC_Project.Location = new System.Drawing.Point(0, 24);
            this.TBC_Project.Name = "TBC_Project";
            this.TBC_Project.SelectedIndex = 0;
            this.TBC_Project.Size = new System.Drawing.Size(794, 507);
            this.TBC_Project.TabIndex = 1;
            // 
            // TBP_ListProject
            // 
            this.TBP_ListProject.Controls.Add(this.DTG_Project);
            this.TBP_ListProject.Location = new System.Drawing.Point(4, 22);
            this.TBP_ListProject.Name = "TBP_ListProject";
            this.TBP_ListProject.Padding = new System.Windows.Forms.Padding(3);
            this.TBP_ListProject.Size = new System.Drawing.Size(786, 481);
            this.TBP_ListProject.TabIndex = 0;
            this.TBP_ListProject.Text = "Liste des projets";
            this.TBP_ListProject.UseVisualStyleBackColor = true;
            // 
            // DTG_Project
            // 
            this.DTG_Project.AllowUserToAddRows = false;
            this.DTG_Project.AllowUserToOrderColumns = true;
            this.DTG_Project.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTG_Project.BackgroundColor = System.Drawing.Color.White;
            this.DTG_Project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTG_Project.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DTG_Project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTG_Project.Location = new System.Drawing.Point(3, 3);
            this.DTG_Project.MultiSelect = false;
            this.DTG_Project.Name = "DTG_Project";
            this.DTG_Project.RowHeadersVisible = false;
            this.DTG_Project.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_Project.Size = new System.Drawing.Size(780, 475);
            this.DTG_Project.TabIndex = 1;
            this.DTG_Project.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DTG_Project_CellFormatting);
            // 
            // TBP_ListTask
            // 
            this.TBP_ListTask.Controls.Add(this.DTG_ListTask);
            this.TBP_ListTask.Location = new System.Drawing.Point(4, 22);
            this.TBP_ListTask.Name = "TBP_ListTask";
            this.TBP_ListTask.Padding = new System.Windows.Forms.Padding(3);
            this.TBP_ListTask.Size = new System.Drawing.Size(786, 481);
            this.TBP_ListTask.TabIndex = 1;
            this.TBP_ListTask.Text = "Liste des tâches";
            this.TBP_ListTask.UseVisualStyleBackColor = true;
            // 
            // DTG_ListTask
            // 
            this.DTG_ListTask.AllowUserToAddRows = false;
            this.DTG_ListTask.AllowUserToOrderColumns = true;
            this.DTG_ListTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTG_ListTask.BackgroundColor = System.Drawing.Color.White;
            this.DTG_ListTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTG_ListTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_ListTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTG_ListTask.Location = new System.Drawing.Point(3, 3);
            this.DTG_ListTask.MultiSelect = false;
            this.DTG_ListTask.Name = "DTG_ListTask";
            this.DTG_ListTask.RowHeadersVisible = false;
            this.DTG_ListTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_ListTask.Size = new System.Drawing.Size(780, 475);
            this.DTG_ListTask.TabIndex = 2;
            this.DTG_ListTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DTG_ListTask_CellFormatting);
            // 
            // TBP_ListTypeTask
            // 
            this.TBP_ListTypeTask.Controls.Add(this.DTG_ListeTaskType);
            this.TBP_ListTypeTask.Location = new System.Drawing.Point(4, 22);
            this.TBP_ListTypeTask.Name = "TBP_ListTypeTask";
            this.TBP_ListTypeTask.Padding = new System.Windows.Forms.Padding(3);
            this.TBP_ListTypeTask.Size = new System.Drawing.Size(786, 481);
            this.TBP_ListTypeTask.TabIndex = 2;
            this.TBP_ListTypeTask.Text = "Liste des types de tâches";
            this.TBP_ListTypeTask.UseVisualStyleBackColor = true;
            // 
            // DTG_ListeTaskType
            // 
            this.DTG_ListeTaskType.AllowUserToAddRows = false;
            this.DTG_ListeTaskType.AllowUserToOrderColumns = true;
            this.DTG_ListeTaskType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTG_ListeTaskType.BackgroundColor = System.Drawing.Color.White;
            this.DTG_ListeTaskType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTG_ListeTaskType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_ListeTaskType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTG_ListeTaskType.Location = new System.Drawing.Point(3, 3);
            this.DTG_ListeTaskType.MultiSelect = false;
            this.DTG_ListeTaskType.Name = "DTG_ListeTaskType";
            this.DTG_ListeTaskType.RowHeadersVisible = false;
            this.DTG_ListeTaskType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_ListeTaskType.Size = new System.Drawing.Size(780, 475);
            this.DTG_ListeTaskType.TabIndex = 2;
            this.DTG_ListeTaskType.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DTG_ListeTaskType_CellFormatting);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 531);
            this.Controls.Add(this.TBC_Project);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Gestion de projet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TBC_Project.ResumeLayout(false);
            this.TBP_ListProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Project)).EndInit();
            this.TBP_ListTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_ListTask)).EndInit();
            this.TBP_ListTypeTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_ListeTaskType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.TabControl TBC_Project;
        private System.Windows.Forms.TabPage TBP_ListProject;
        private System.Windows.Forms.TabPage TBP_ListTask;
        private System.Windows.Forms.TabPage TBP_ListTypeTask;
        private System.Windows.Forms.ToolStripMenuItem TSM_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BTN_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MIT_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MIT_Delete;
        private System.Windows.Forms.DataGridView DTG_Project;
        private System.Windows.Forms.DataGridView DTG_ListeTaskType;
        private System.Windows.Forms.DataGridView DTG_ListTask;
    }
}

