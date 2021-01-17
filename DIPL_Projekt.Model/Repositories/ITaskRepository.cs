using DIPL_Projekt.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPL_Projekt.Model.Repositories
{
    public interface ITaskRepository
    {
        /// <summary>
        /// Gets all tasks.
        /// </summary>
        /// <returns>List of tasks.</returns>
        List<Task> GetTasks();

        /// <summary>
        /// Gets a task by id.
        /// </summary>
        /// <param name="id">Id of the task.</param>
        /// <returns>The task.</returns>
        Task GetTask(int id);

        /// <summary>
        /// Adds a new task.
        /// </summary>
        /// <param name="task">A task to be added.</param>
        void AddTask(Task task);

        /// <summary>
        /// Updates an existing task.
        /// </summary>
        /// <param name="task">A task to be updated.</param>
        void UpdateTask(Task task);

        /// <summary>
        /// Deletes a task.
        /// </summary>
        /// <param name="id">Id of a task to be deleted.</param>
        void DeleteTask(int id);
    }
}
