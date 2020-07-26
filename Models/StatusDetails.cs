using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace ToDoList.Models
{
    public class StatusDetails
    {
        [Key]
        public int StatusID { get; set; }
        public string  StatusTitle { get; set; }
        public ICollection<TaskDetails> TaskDetails { get; set; }
    }
}