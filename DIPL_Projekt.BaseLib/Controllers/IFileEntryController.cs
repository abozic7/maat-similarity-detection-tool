using DIPL_Projekt.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt.BaseLib.Controllers
{
    public interface IFileEntryController
    {
        /// <summary>
        /// Gets all files.
        /// </summary>
        /// <returns>List of files.</returns>
        List<FileEntry> GetFiles();

        /// <summary>
        /// Gets a file by id.
        /// </summary>
        /// <param name="id">Id of the file.</param>
        /// <returns>The file.</returns>
        FileEntry GetFile(int id);

        /// <summary>
        /// Gets files by task.
        /// </summary>
        /// <param name="taskID">Id of the task.</param>
        /// <returns>List of files of a task.</returns>
        List<FileEntry> GetFilesByTask(int taskID);

        /// <summary>
        /// Adds a new file.
        /// </summary>
        /// <param name="fileEntry">A file to be added.</param>
        void AddFile(FileEntry fileEntry);

        /// <summary>
        /// Updates an existing file.
        /// </summary>
        /// <param name="fileEntry">A file to be updated.</param>
        void UpdateFile(FileEntry fileEntry);

        /// <summary>
        /// Deletes a file.
        /// </summary>
        /// <param name="id">Id of a file to be deleted.</param>
        void DeleteFile(int id);
    }
}
