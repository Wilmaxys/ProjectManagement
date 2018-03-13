using Gestion_de_projet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_de_projet.Forms
{
    public partial class EditTask : Form
    {
        #region Fields

        task _Task;

        #endregion

        #region Constructors
        public EditTask(BindingList<project> listProject, BindingList<taskType> listTaskType, task Task)
        {
            InitializeComponent();

            _Task = Task;

            setDataSource(listProject, listTaskType);

            if (!String.IsNullOrWhiteSpace(Task.Title))
            {
                TBX_Title.Text = Task.Title;
                TBX_Percent.Text = Convert.ToString(Task.PercentProg);
                DTP_DateStart.Value = Task.DateStart;
                DTP_DateEnd.Value = Task.DateEnd;
                RTB_Desc.Text = Task.Desc;
                CBX_Project.SelectedItem = Task.Project;
                CBX_TaskType.SelectedItem = Task.TaskType;
            }

        }

        #endregion

        #region Methods

        /// <summary>
        /// Modifit la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            DateTime datemin = new DateTime(1900, 1, 1);
            DateTime datemax = new DateTime(2100, 1, 1);


            if (!String.IsNullOrWhiteSpace(TBX_Title.Text))
            {
                if (DateTime.Compare(DTP_DateStart.Value, datemin) > 0 && DateTime.Compare(DTP_DateStart.Value, datemax) < 0 && DateTime.Compare(DTP_DateEnd.Value, datemin) > 0 && DateTime.Compare(DTP_DateEnd.Value, datemax) < 0)
                {
                    if (DateTime.Compare(DTP_DateStart.Value, DTP_DateEnd.Value) < 0 || (DTP_DateStart.Value.Day == DTP_DateEnd.Value.Day && DTP_DateStart.Value.Month == DTP_DateEnd.Value.Month && DTP_DateStart.Value.Year == DTP_DateStart.Value.Year))
                    {
                        _Task.Title = TBX_Title.Text;
                        _Task.DateStart = DTP_DateStart.Value;
                        _Task.DateEnd = DTP_DateEnd.Value;
                        _Task.Desc = RTB_Desc.Text;
                        if (!String.IsNullOrWhiteSpace(TBX_Percent.Text))
                            _Task.PercentProg = Convert.ToInt32(TBX_Percent.Text);
                        else
                            _Task.PercentProg = 0;
                        _Task.Project = CBX_Project.SelectedItem as project;
                        _Task.IdentifierProject = _Task.Project.identifier;
                        _Task.TaskType = CBX_TaskType.SelectedItem as taskType;
                        _Task.IdentifierTaskType = _Task.TaskType.identifier;

                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("La date de début doit être antérieur à celle de fin", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La date doit être comprise entre le 01/01/1900 et le 01/01/2100", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("La tâche doit avoir un titre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        /// <summary>
        /// Définit les datasources des combobox
        /// </summary>
        /// <param name="listProject"></param>
        /// <param name="listTaskType"></param>
        private void setDataSource(BindingList<project> listProject, BindingList<taskType> listTaskType)
        {
            CBX_Project.DataSource = listProject;
            CBX_Project.DisplayMember = "name";

            CBX_TaskType.DataSource = listTaskType;
            CBX_TaskType.DisplayMember = "label";
        }
        
        /// <summary>
        /// Modifit la valeur de la description du type de tâche en fonction du type de tâche de la combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBX_TaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskType selectedTaskType = CBX_TaskType.SelectedItem as taskType;

            RTB_DescTaskType.Text = selectedTaskType.description;
        }
        
        /// <summary>
        /// Modifit la valeur de la description du projet en fonction du projet de la combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBX_Project_SelectedIndexChanged(object sender, EventArgs e)
        {
            project selectedProject = CBX_Project.SelectedItem as project;

            RTB_DescProject.Text = selectedProject.description;
        }
        
        /// <summary>
        /// Ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Charge la barre et vérifie la valeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TBX_Percent_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TBX_Percent.Text))
            {
                int val;

                if (Int32.TryParse(TBX_Percent.Text, out val))
                {
                    if (Convert.ToInt32(TBX_Percent.Text) <= 100 && Convert.ToInt32(TBX_Percent.Text) >= 0)
                        PGB_Percent.Value = Convert.ToInt32(TBX_Percent.Text);
                    else
                    {

                        TBX_Percent.Text = "0";
                        MessageBox.Show("La valeur doit être compris entre 0 et 100!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    TBX_Percent.Text = "0";
                    MessageBox.Show("Vous devez entré des chiffres!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

    }
}
