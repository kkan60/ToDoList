using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskDetailsController : ApiController
    {
        private static readonly ITaskRepo repo = new TaskRepo();
    }
}
