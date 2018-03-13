using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_projet.Data
{
    [Serializable]
    public class project
    {
        #region Fields

        private int Identifier;
        private string Name;
        private DateTime DateStart;
        private DateTime DateEnd;
        private string Description;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou définit l'identifer
        /// </summary>
        public int identifier { get => Identifier; set => Identifier = value; }

        /// <summary>
        /// Obtient ou définit le name
        /// </summary>
        public string name { get => Name; set => Name = value; }

        /// <summary>
        /// Obtient ou définit la data de début
        /// </summary>
        public DateTime dateDeb { get => DateStart; set => DateStart = value; }

        /// <summary>
        /// Obtient ou définit la date de fin
        /// </summary>
        public DateTime dateFin { get => DateEnd; set => DateEnd = value; }

        /// <summary>
        /// Obtient ou définit la valeur de la description
        /// </summary>
        public string description { get => Description; set => Description = value; }


        #endregion

        #region Methods

        /// <summary>
        /// Retourne la chaîne de caractère à afficher
        /// </summary>
        public override string ToString()
        {
            return  name + "," + identifier + "," + description + "," + dateDeb.ToString("dd/MM/yyyy") + "," + dateFin.ToString("dd/MM/yyyy");
        }

        #endregion

    }
}
