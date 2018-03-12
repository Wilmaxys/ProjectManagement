using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_projet.Data
{
    [Serializable]
    public class task
    {

        #region Fields

        private int identifier;
        private string title;
        private DateTime dateDeb;
        private DateTime dateEnd;
        private int percentProg;
        private string desc;

        [NonSerialized]
        private project project;

        private int identifierProject;

        [NonSerialized]
        private taskType taskType;
        private int identifierTaskType;

        #endregion


        #region Properties
        /// <summary>
        /// Obtient ou modifit l'indentifier
        /// </summary>
        public int Identifier { get => identifier; set => identifier = value; }
        /// <summary>
        /// Obtient ou modifit le titre
        /// </summary>
        public string Title { get => title; set => title = value; }
        /// <summary>
        /// Obtient ou modifit la date de début
        /// </summary>
        public DateTime DateDeb { get => dateDeb; set => dateDeb = value; }
        /// <summary>
        /// Obtient ou modifit la date de fin
        /// </summary>
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }
        /// <summary>
        /// Obtient ou modifit le pourcentage de progression
        /// </summary>
        public int PercentProg { get => percentProg; set => percentProg = value; }
        /// <summary>
        /// Obtient ou modifit la description
        /// </summary>
        public string Desc { get => desc; set => desc = value; }
        /// <summary>
        /// Obtient ou modifit le projet
        /// </summary>
        public project Project { get => project; set => project = value; }
        /// <summary>
        /// Obtient ou modifit l'indifiant du projet
        /// </summary>
        public int IdentifierProject { get => identifierProject; set => identifierProject = value; }
        /// <summary>
        /// Obtient ou modifit le type de tâche
        /// </summary>
        public taskType TaskType { get => taskType; set => taskType = value; }
        /// <summary>
        /// Obtient ou modifit l'indifiant du type de la tâche
        /// </summary>
        public int IdentifierTaskType { get => identifierTaskType; set => identifierTaskType = value; }
        #endregion


        #region Methods
        /// <summary>
        /// Retourne la chaîne de caractère à afficher
        /// </summary>
        public override string ToString()
        {
            return Identifier + "," + Title + "," + DateDeb + "," + DateEnd + "," + PercentProg + "," + Desc + "," + Project + "," + TaskType;
        }

        #endregion


    }
}
