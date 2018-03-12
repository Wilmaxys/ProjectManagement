using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_projet.Data
{
    [Serializable]
    public class taskType
    {
        #region Fields

        private int Identifier;
        private string Label;
        private string Description;

        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou définit l'indentifier
        /// </summary>
        public int identifier { get => Identifier; set => Identifier = value; }

        /// <summary>
        /// Obtient ou définit le label
        /// </summary>
        public string label { get => Label; set => Label = value; }

        /// <summary>
        /// Obtient ou définit la description
        /// </summary>
        public string description { get => Description; set => Description = value; }

        #endregion

        #region Methods
        /// <summary>
        /// Retourne la chaîne de caractère à afficher
        /// </summary>
        public override string ToString()
        {
            return label + "," + identifier + "," + description;
        }

        #endregion
    }
}
