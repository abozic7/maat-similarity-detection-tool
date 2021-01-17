using DIPL_Projekt.Model.Models;
using DIPL_Projekt.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt.DAL.Repositories
{
    public class ComparisonResultRepository : IComparisonResultRepository
    {
        public void AddComparisonResult(ComparisonResult comparisonResult)
        {
            using (var context = new MaatAppDBContext())
            {
                context.Add<ComparisonResult>(comparisonResult);
                context.SaveChanges();
            }
        }

        public void DeleteComparisonResult(int file1Id, int file2Id)
        {
            using (var context = new MaatAppDBContext())
            {
                ComparisonResult comparisonResultToDelete = context.ComparisonResult
                    .Where(r => r.File1Id == file1Id && r.File2Id == file2Id)
                    .FirstOrDefault();

                context.Remove<ComparisonResult>(comparisonResultToDelete);
                context.SaveChanges();
            }
        }

        public ComparisonResult GetComparisonResult(int file1Id, int file2Id)
        {
            using (var context = new MaatAppDBContext())
            {
                return context.ComparisonResult
                    .Where(r => r.File1Id == file1Id && r.File2Id == file2Id)
                    .FirstOrDefault();
            }
        }

        public List<ComparisonResult> GetComparisonResults()
        {
            using (var context = new MaatAppDBContext())
            {
                return context.ComparisonResult.ToList();
            }
        }

        public List<ComparisonResult> GetComparisonResultsByTask(int taskID)
        {
            using (var context = new MaatAppDBContext())
            {
                return context.ComparisonResult.Where(r => r.TaskId == taskID).ToList();
            }
        }

        public void UpdateComparisonResult(ComparisonResult comparisonResult)
        {
            using (var context = new MaatAppDBContext())
            {
                context.Update<ComparisonResult>(comparisonResult);
                context.SaveChanges();
            }
        }
    }
}
