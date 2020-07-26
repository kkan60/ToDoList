using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class TaskDetails
    {
        [Key]
        public int TaskID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string CreatedBy { get; set; }
        public int TaskStatusID { get; set; }
        public StatusDetails Status { get; set; }
        

    }
}