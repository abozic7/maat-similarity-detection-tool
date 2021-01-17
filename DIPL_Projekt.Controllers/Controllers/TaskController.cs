using DIPL_Projekt.BaseLib.Controllers;
using DIPL_Projekt.DAL;
using DIPL_Projekt.DAL.Repositories;
using DIPL_Projekt.Model.Models;
using DIPL_Projekt.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPL_Projekt.Controllers.Controllers
{
    public class TaskController : ITaskController
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController()
        {
            _taskRepository = new TaskRepository();
        }

        public void AddTask(Task task)
        {
            _taskRepository.AddTask(task);
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        public Task GetTask(int id)
        {
            return _taskRepository.GetTask(id);
        }

        public List<Task> GetTasks()
        {
            return _taskRepository.GetTasks();
        }

        public void UpdateTask(Task task)
        {
            _taskRepository.UpdateTask(task);
        }
    }
}
