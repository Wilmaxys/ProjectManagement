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
    public partial class EditProject : Form
    {

        #region Fields

        private project _Project;

        #endregion

        #region Constructors

        public EditProject(project Project)
        {
            InitializeComponent();

            this._Project = Project;

            if(!String.IsNullOrWhiteSpace(Project.nom))
            {
                RTC_Desc.Text = Project.description;
                DTP_DateDeb.Value = Project.dateDeb;
                DTP_DateFin.Value = Project.dateFin;
                TBX_Nom.Text = Project.nom;
            }

        }

        #endregion

        #region Methods
        /// <summary>
        /// Ferme l'écran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Enregistre les modifications sur le projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            DateTime datemin = new DateTime(1900, 1, 1);
            DateTime datemax = new DateTime(2100, 1, 1);

            if (!String.IsNullOrWhiteSpace(TBX_Nom.Text))
            {
                if (DateTime.Compare(DTP_DateDeb.Value, datemin) > 0 && DateTime.Compare(DTP_DateDeb.Value, datemax) < 0 && DateTime.Compare(DTP_DateFin.Value, datemin) > 0 && DateTime.Compare(DTP_DateFin.Value, datemax) < 0)
                {
                    if (DateTime.Compare(DTP_DateDeb.Value, DTP_DateFin.Value) <0)
                    {
                    _Project.nom = TBX_Nom.Text;
                    _Project.dateDeb = DTP_DateDeb.Value;
                    _Project.dateFin = DTP_DateFin.Value;
                    _Project.description = RTC_Desc.Text;
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
                MessageBox.Show("La projet doit avoir un nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        #endregion

    }
}
