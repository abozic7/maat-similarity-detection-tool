using DIPL_Projekt.Model.Models;
using DIPL_Projekt.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt.DAL.Repositories
{
    public class FileEntryRepository : IFileEntryRepository
    {
        public void AddFile(FileEntry file)
        {
            using (var context = new MaatAppDBContext())
            {
                context.Add<FileEntry>(file);
                context.SaveChanges();
            }
        }

        public void DeleteFile(int id)
        {
            using (var context = new MaatAppDBContext())
            {
                List<ComparisonResult> comparisonResults = context.ComparisonResult
                    .Where(r => r.File1Id == id || r.File2Id == id)
                    .ToList();
                foreach (var res in comparisonResults)
                {
                    context.Remove<ComparisonResult>(res);
                }

                FileEntry fileToDelete = context.FileEntry.Where(r => r.Id == id).FirstOrDefault();
                context.Remove<FileEntry>(fileToDelete);
                context.SaveChanges();
            }
        }

        public FileEntry GetFile(int id)
        {
            using (var context = new MaatAppDBContext())
            {
                return context.FileEntry.Where(r => r.Id == id).FirstOrDefault();
            }
        }

        public List<FileEntry> GetFiles()
        {
            using (var context = new MaatAppDBContext())
            {
                return context.FileEntry.ToList();
            }
        }

        public List<FileEntry> GetFilesByTask(int taskID)
        {
            using (var context = new MaatAppDBContext())
            {
                return context.FileEntry.Where(r => r.TaskId == taskID).ToList();
            }
        }

        public void UpdateFile(FileEntry file)
        {
            using (var context = new MaatAppDBContext())
            {
                context.Update<FileEntry>(file);
                context.SaveChanges();
            }
        }
    }
}
