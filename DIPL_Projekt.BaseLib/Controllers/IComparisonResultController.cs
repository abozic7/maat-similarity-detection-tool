using DIPL_Projekt.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt.BaseLib.Controllers
{
    public interface IComparisonResultController
    {
        /// <summary>
        /// Gets all comparison results.
        /// </summary>
        /// <returns>List of comparison results.</returns>
        List<ComparisonResult> GetComparisonResults();

        /// <summary>
        /// Gets a comparison result of two files.
        /// </summary>
        /// <param name="file1Id">Id of the first file.</param>
        /// <param name="file2Id">Id of the second file.</param>
        /// <returns>Comparison result of two files.</returns>
        ComparisonResult GetComparisonResult(int file1Id, int file2Id);

        /// <summary>
        /// Gets comparison results by task.
        /// </summary>
        /// <param name="taskID">Id of the task.</param>
        /// <returns>List of comparison results of a task.</returns>
        List<ComparisonResult> GetComparisonResultsByTask(int taskID);

        /// <summary>
        /// Adds a new comparison result.
        /// </summary>
        /// <param name="comparisonResult">Comparison result to be added.</param>
        void AddComparisonResult(ComparisonResult comparisonResult);

        /// <summary>
        /// Updates an existing comparison result.
        /// </summary>
        /// <param name="comparisonResult">Comparison result to be updated.</param>
        void UpdateComparisonResult(ComparisonResult comparisonResult);

        /// <summary>
        /// Deletes a comparison result of two files.
        /// </summary>
        /// <param name="file1Id">Id of the first file.</param>
        /// <param name="file2Id">Id of the second file.</param>
        void DeleteComparisonResult(int file1Id, int file2Id);
    }
}
