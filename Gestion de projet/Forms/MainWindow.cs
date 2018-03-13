using Gestion_de_projet.Data;
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

namespace Gestion_de_projet.Forms
{
    public partial class MainWindow : Form
    {
        #region Fields

        projectManagement _ProjectManagement;
        private bool exists;
        private taskType currentTaskType;
        private bool hasChanges = false;

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists(".\\Data.dat"))
            {

                try
                {
                    _ProjectManagement = projectManagement.Load(".\\Data.dat");
                }
                catch (Exception)
                {
                    MessageBox.Show("Il y a eu un problème dans le chargement des données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                _ProjectManagement = new projectManagement();
            }

          initializeDTG();

        }

        #endregion

        #region Methods

        
        /// <summary>
        /// Définit les datasources des listBoxs
        /// </summary>
        private void initializeDTG()
        {

            DTG_ListeTaskType.DataSource = _ProjectManagement.ListTaskType;
            DTG_ListTask.DataSource = _ProjectManagement.ListTask;
            DTG_Project.DataSource = _ProjectManagement.ListProject;

            DTG_Project.Columns[0].HeaderText = "Id";
            DTG_Project.Columns[1].HeaderText = "Name";
            DTG_Project.Columns[2].HeaderText = "Date de début";
            DTG_Project.Columns[3].HeaderText = "Date de fin";
            DTG_Project.Columns[4].HeaderText = "Description";

            DTG_ListeTaskType.Columns[0].HeaderText = "Id";
            DTG_ListeTaskType.Columns[1].HeaderText = "Libellé";
            DTG_ListeTaskType.Columns[2].HeaderText = "Description";

            DTG_ListTask.Columns[0].HeaderText = "Id";
            DTG_ListTask.Columns[1].HeaderText = "Titre";
            DTG_ListTask.Columns[2].HeaderText = "Date de début";
            DTG_ListTask.Columns[3].HeaderText = "Date de fin";
            DTG_ListTask.Columns[4].HeaderText = "Pourcentage de progression";
            DTG_ListTask.Columns[5].HeaderText = "Description";
            DTG_ListTask.Columns[6].HeaderText = "Projet";
            DTG_ListTask.Columns[8].HeaderText = "Type de tâche";

            DTG_ListTask.Columns[7].Visible = false;
            DTG_ListTask.Columns[9].Visible = false;

        }

        
        /// <summary>
        /// Supprimer un enrigstrement sélectionner dans une liste d'une onglet sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIT_Delete_Click(object sender, EventArgs e)
        {

            if (TBC_Project.SelectedTab == TBP_ListProject && DTG_Project.SelectedRows[0].DataBoundItem != null)
            {
                
                project selected = DTG_Project.SelectedRows[0].DataBoundItem as project;

                exists = false;

                foreach (task t in _ProjectManagement.ListTask)
                {
                    if (t.IdentifierProject == selected.identifier)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    _ProjectManagement.ListProject.Remove(selected);
                    hasChanges = true;
                }
                else
                {
                    MessageBox.Show("Une tâche est attaché à ce projet !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (TBC_Project.SelectedTab == TBP_ListTypeTask && DTG_ListeTaskType.SelectedRows[0].DataBoundItem != null)
            {
                currentTaskType = DTG_ListeTaskType.SelectedRows[0].DataBoundItem as taskType;

                exists = false;

                foreach (task t in _ProjectManagement.ListTask)
                {
                    if (t.IdentifierTaskType == currentTaskType.identifier)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    _ProjectManagement.ListTaskType.Remove(currentTaskType);
                    hasChanges = true;
                }
                else
                {
                    MessageBox.Show("Une tâche est attaché à ce type de tache !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else if (TBC_Project.SelectedTab == TBP_ListTask && DTG_ListTask.SelectedRows[0].DataBoundItem != null)
            {
                _ProjectManagement.ListTask.Remove(DTG_ListTask.SelectedRows[0].DataBoundItem as task);
                hasChanges = true;
            }

        }


        /// <summary>
        /// Ajoute un enregistrement dans une liste d'un onglet sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Add_Click(object sender, EventArgs e)
        {

            // ajouter un projet
            if (TBC_Project.SelectedTab == TBP_ListProject)
            {
                project addProject = new project()
                {
                    identifier = getIdentifierProject()
                };

                EditProject editProject = new EditProject(addProject);
                editProject.StartPosition = FormStartPosition.CenterParent;
                if (editProject.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrWhiteSpace(addProject.name))
                    {
                        _ProjectManagement.ListProject.Add(addProject);
                        hasChanges = true;

                    }
                }
            }

            // ajouter un type de tâche
            else if (TBC_Project.SelectedTab == TBP_ListTypeTask)
            {
                taskType addTaskType = new taskType()
                {
                    identifier = getIdentifierTaskType()
                };

                EditTaskType editTaskType = new EditTaskType(addTaskType);
                editTaskType.StartPosition = FormStartPosition.CenterParent;
                if (editTaskType.ShowDialog() == DialogResult.OK)
                {
                    //TODO verif
                    _ProjectManagement.ListTaskType.Add(addTaskType);
                    hasChanges = true;

                }
            }

            //ajouter une tache
            else if (TBC_Project.SelectedTab == TBP_ListTask)
            {
                task addTask = new task()
                {
                    Identifier = getIdentifierTask()
                };

                EditTask editTask = new EditTask(_ProjectManagement.ListProject, _ProjectManagement.ListTaskType, addTask);
                editTask.StartPosition = FormStartPosition.CenterParent;
                if (editTask.ShowDialog() == DialogResult.OK)
                {
                    //TODO verif
                    _ProjectManagement.ListTask.Add(addTask);
                    hasChanges = true;

                }
            }
        }


        /// <summary>
        /// Formate la DataGridView Liste tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DTG_ListTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6  || e.ColumnIndex == 8) // Check for the column you want
            {
                string test = e.Value.ToString();

                e.Value = test.Split(',')[0];
                e.FormattingApplied = true;
            }
            if (e.RowIndex %2 == 0)
            {
                DTG_ListTask.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
            }
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                DateTime date = Convert.ToDateTime(e.Value);
                e.Value = date.ToString("dd/MM/yyyy");
            }
        }


        /// <summary>
        /// Modifie un enregistrement sélectionner dans une liste d'un onglet sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIT_Open_Click(object sender, EventArgs e)
        {

            // ouvrir la liste des projets 
            if(TBC_Project.SelectedTab == TBP_ListProject && DTG_Project.SelectedRows[0].DataBoundItem != null)
            {
                project selectedProject = DTG_Project.SelectedRows[0].DataBoundItem as project;


                EditProject editProject = new EditProject(selectedProject);
                editProject.StartPosition = FormStartPosition.CenterParent;
                if (editProject.ShowDialog() == DialogResult.OK)
                {
                    _ProjectManagement.ListProject.Remove(selectedProject);
                    _ProjectManagement.ListProject.Add(selectedProject);
                    hasChanges = true;
                }
            }

            // ouvrir la liste des types de tâches
            else if(TBC_Project.SelectedTab == TBP_ListTypeTask && DTG_ListeTaskType.SelectedRows[0].DataBoundItem != null)
            {
                taskType selectedTaskType = DTG_ListeTaskType.SelectedRows[0].DataBoundItem as taskType;

                EditTaskType editTaskType = new EditTaskType(selectedTaskType);
                editTaskType.StartPosition = FormStartPosition.CenterParent;
                if (editTaskType.ShowDialog() == DialogResult.OK)
                {

                    _ProjectManagement.ListTaskType.Remove(selectedTaskType);
                    _ProjectManagement.ListTaskType.Add(selectedTaskType);
                    hasChanges = true;
                }

            }

            // ouvrir la liste des tâches
            else if (TBC_Project.SelectedTab == TBP_ListTask && DTG_ListTask.SelectedRows[0].DataBoundItem != null)
            {
                task selectedTask = DTG_ListTask.SelectedRows[0].DataBoundItem as task;

                EditTask editTask = new EditTask(_ProjectManagement.ListProject, _ProjectManagement.ListTaskType, selectedTask);
                editTask.StartPosition = FormStartPosition.CenterParent;
                if (editTask.ShowDialog() == DialogResult.OK)
                {
                    _ProjectManagement.ListTask.Remove(selectedTask);
                    _ProjectManagement.ListTask.Add(selectedTask);
                    hasChanges = true;
                }

            }
        }
        

        #region getNewIdentifers

        private int getIdentifierProject()
        {
            int maxIdentifier = 0;

            foreach (project p in _ProjectManagement.ListProject)
            {
                if (p.identifier > maxIdentifier)
                    maxIdentifier = p.identifier;
            }

            return maxIdentifier+1;
        }

        private int getIdentifierTaskType()
        {
            int maxIdentifier = 0;

            foreach (taskType tt in _ProjectManagement.ListTaskType)
            {
                if (tt.identifier > maxIdentifier)
                    maxIdentifier = tt.identifier;
            }

            return maxIdentifier + 1;
        }

        private int getIdentifierTask()
        {
            int maxIdentifier = 0;

            foreach (task tt in _ProjectManagement.ListTask)
            {
                if (tt.Identifier > maxIdentifier)
                    maxIdentifier = tt.Identifier;
            }

            return maxIdentifier + 1;
        }


        #endregion

        
        /// <summary>
        /// Appel la fonction de sauvegarde à l'appuie du bouton sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSM_Save_Click(object sender, EventArgs e)
        {
            hasChanges = false;
            Save();
        }



        /// <summary>
        /// Sauvegarde le projet en appellant la méthode du projectManagement
        /// </summary>
        private void Save()
        {
            _ProjectManagement.Save(".\\Data.dat");
        }



        /// <summary>
        /// Vérifie si il y a des modifications et propose une sauvegarde
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            if (hasChanges)
            {
                DialogResult result = MessageBox.Show("Des modifications n'ont pas été sauvégardées. Sauvegarder ?", "Sauvegarder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Save();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }

            base.OnClosing(e);
        }


        /// <summary>
        /// Formate la DataGridView Liste type de tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DTG_ListeTaskType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                DTG_ListeTaskType.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }


        /// <summary>
        /// Formate la DataGridView Liste Projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DTG_Project_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                DTG_Project.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
            }
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                DateTime date = Convert.ToDateTime(e.Value);
                e.Value = date.ToString("dd/MM/yyyy");
            }
        }

        
        
        #endregion


    }
}
