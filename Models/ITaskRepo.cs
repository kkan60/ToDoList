using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    interface ITaskRepo
    {
        IEnumerable<TaskDetails> GetAll();
        TaskDetails Get(int id);
        TaskDetails Add(TaskDetails task);
        void Remove(int id);
        bool Update(TaskDetails task);
    }
}
