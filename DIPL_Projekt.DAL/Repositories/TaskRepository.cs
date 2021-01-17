using DIPL_Projekt.Model.Models;
using DIPL_Projekt.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPL_Projekt.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void AddTask(Task task)
        {
            using (var context = new MaatAppDBContext())
            {
                context.Add<Task>(task);
                context.SaveChanges();
            }
        }

        public void DeleteTask(int id)
        {
            using (var context = new MaatAppDBContext())
            {
                Task taskToDelete = context.Task.Where(r => r.Id == id).FirstOrDefault();

                context.Remove<Task>(taskToDelete);
                context.SaveChanges();
            }
        }

        public Task GetTask(int id)
        {
            using (var context = new MaatAppDBContext())
            {
                return context.Task.Where(r => r.Id == id).FirstOrDefault();
            }
        }

        public List<Task> GetTasks()
        {
            using (var context = new MaatAppDBContext())
            {
                return context.Task.ToList();
            }
        }

        public void UpdateTask(Task task)
        {
            using (var context = new MaatAppDBContext())
            {
                context.Update<Task>(task);
                context.SaveChanges();
            }
        }
    }
}
