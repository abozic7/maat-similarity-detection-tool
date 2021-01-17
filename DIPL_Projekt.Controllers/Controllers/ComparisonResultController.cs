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
    public class ComparisonResultController : IComparisonResultController
    {
        private readonly IComparisonResultRepository _comparisonResultRepository;

        public ComparisonResultController()
        {
            _comparisonResultRepository = new ComparisonResultRepository();
        }

        public void AddComparisonResult(ComparisonResult comparisonResult)
        {
            _comparisonResultRepository.AddComparisonResult(comparisonResult);
        }

        public void DeleteComparisonResult(int file1Id, int file2Id)
        {
            _comparisonResultRepository.DeleteComparisonResult(file1Id, file2Id);
        }

        public ComparisonResult GetComparisonResult(int file1Id, int file2Id)
        {
            return _comparisonResultRepository.GetComparisonResult(file1Id, file2Id);
        }

        public List<ComparisonResult> GetComparisonResults()
        {
            return _comparisonResultRepository.GetComparisonResults();
        }

        public List<ComparisonResult> GetComparisonResultsByTask(int taskID)
        {
            return _comparisonResultRepository.GetComparisonResultsByTask(taskID);
        }

        public void UpdateComparisonResult(ComparisonResult comparisonResult)
        {
            _comparisonResultRepository.UpdateComparisonResult(comparisonResult);
        }
    }
}
