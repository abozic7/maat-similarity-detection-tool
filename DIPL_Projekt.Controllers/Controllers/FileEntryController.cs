using DIPL_Projekt.BaseLib.Controllers;
using DIPL_Projekt.DAL;
using DIPL_Projekt.DAL.Repositories;
using DIPL_Projekt.Model.Models;
using DIPL_Projekt.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt.Controllers.Controllers
{
    public class FileEntryController : IFileEntryController
    {
        private readonly IFileEntryRepository _fileEntryRepository;

        public FileEntryController()
        {
            _fileEntryRepository = new FileEntryRepository();
        }

        public void AddFile(FileEntry fileEntry)
        {
            _fileEntryRepository.AddFile(fileEntry);
        }

        public void DeleteFile(int id)
        {
            _fileEntryRepository.DeleteFile(id);
        }

        public FileEntry GetFile(int id)
        {
            return _fileEntryRepository.GetFile(id);
        }

        public List<FileEntry> GetFiles()
        {
            return _fileEntryRepository.GetFiles();
        }

        public List<FileEntry> GetFilesByTask(int taskID)
        {
            return _fileEntryRepository.GetFilesByTask(taskID);
        }

        public void UpdateFile(FileEntry fileEntry)
        {
            _fileEntryRepository.UpdateFile(fileEntry);
        }
    }
}
