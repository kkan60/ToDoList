using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Controllers;

namespace ToDoList.Models
{
    public class TaskRepo : ITaskRepo
    {
        private List<TaskDetails> AllTaskRepo = new List<TaskDetails>();
        public TaskDetails Add(TaskDetails task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("task");
            }
            AllTaskRepo.Add(task);
            return task;
        }

        public TaskDetails Get(int id)
        {
            return AllTaskRepo.Find(p => p.TaskID == id);
        }

        public IEnumerable<TaskDetails> GetAll()
        {
            return AllTaskRepo;
        }

        public void Remove(int id)
        {
            AllTaskRepo.RemoveAll(p => p.TaskID == id);
        }

        public bool Update(TaskDetails task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("task");
            }
            int index = AllTaskRepo.FindIndex(p => p.TaskID == task.TaskID);
            if (index == -1)
            {
                return false;
            }
            AllTaskRepo.RemoveAt(index);
            AllTaskRepo.Add(task);
            return true;
        }
    }
}