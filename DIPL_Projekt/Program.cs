using DIPL_Projekt.BaseLib.Controllers;
using DIPL_Projekt.Controllers.Controllers;
using DIPL_Projekt.DAL;
using DIPL_Projekt.DAL.Repositories;
using DIPL_Projekt.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPL_Projekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITaskRepository _taskRepository = new TaskRepository();
            IFileEntryRepository _fileEntryRepository = new FileEntryRepository();
            IComparisonResultRepository _comparisonResultRepository = new ComparisonResultRepository();
            ITaskController _taskController = new TaskController();
            IFileEntryController _fileEntryController = new FileEntryController();
            IComparisonResultController _comparisonResultController = new ComparisonResultController();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainWindow());

        }
    }
}
