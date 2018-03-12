using Gestion_de_projet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_projet.Forms
{
    public partial class EditTaskType : Form
    {

        #region Fields

        private taskType _Task;

        #endregion

        #region Constructors
        public EditTaskType(taskType Task)
        {

            InitializeComponent();

            this._Task = Task;

            if (!String.IsNullOrWhiteSpace(Task.label))
            {
                TBX_Lbl.Text = Task.label ;
                RTC_Desc.Text = Task.description;
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

            if (!String.IsNullOrWhiteSpace(TBX_Lbl.Text))
            {
                _Task.label = TBX_Lbl.Text;
                _Task.description = RTC_Desc.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Le type de tâche doit avoir un libellé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        
        /// <summary>
        /// ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
