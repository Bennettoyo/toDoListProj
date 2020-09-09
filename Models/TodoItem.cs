using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoListProj.Models
{
    public class TodoItem
    {
        public long ID { get; set; }
        public string Task { get; set; }
        public bool IsComplete { get; set; }
    }
}
