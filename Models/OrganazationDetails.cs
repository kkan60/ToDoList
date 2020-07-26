using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class OrganazationDetails
    {
        [Key]
        public int OrganazationID { get; set; }
        public string OrganazationName { get; set; }
        
    }
}