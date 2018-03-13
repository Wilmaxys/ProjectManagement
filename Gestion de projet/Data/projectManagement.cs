using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_projet.Data
{
    [Serializable]
    public class projectManagement
    {

        #region Fields

        private BindingList<project> listProject;
        private BindingList<taskType> listTaskType;
        private BindingList<task> listTask;

        #region Constructors

        public projectManagement()
        {

            listProject = new BindingList<project>();
            listTaskType = new BindingList<taskType>();
            listTask = new BindingList<task>();


        }

        #endregion

        #endregion

        #region Properties
        /// <summary>
        /// Obtient la liste des projets
        /// </summary>
        public BindingList<project> ListProject { get => listProject; }
        /// <summary>
        /// Obtient la liste des types des tâches
        /// </summary>
        public BindingList<taskType> ListTaskType { get => listTaskType; }
        /// <summary>
        /// Obtient la liste des tâches
        /// </summary>
        public BindingList<task> ListTask { get => listTask; }

        #endregion


        #region Methods

        public void Save(string filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using(FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                bf.Serialize(fileStream, this);
            }
        }

        public static projectManagement Load(string filePath)
        {
            projectManagement result = new projectManagement();

            if (File.Exists(filePath))
            {
                BinaryFormatter bf = new BinaryFormatter();

                using(FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    result = bf.Deserialize(fileStream) as projectManagement;
                }

                foreach (task p in result.ListTask)
                {
                    p.Project = result.listProject.FirstOrDefault(pt => pt.identifier == p.IdentifierProject);
                    p.TaskType = result.listTaskType.FirstOrDefault(pt => pt.identifier == p.IdentifierTaskType);
                }

            }
            return result;
        }

        #endregion
    }
}
