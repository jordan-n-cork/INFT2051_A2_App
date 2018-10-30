using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace A2_AppProject.Models
{
     public class TaskItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public bool Done { get; set; }
    }
}
