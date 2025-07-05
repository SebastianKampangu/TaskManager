using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Task
    {
        //TODO: Add properties for task data
        //Task properties using appropriate data Tapes
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        //TODO: Add Constructor to create new tskd
        //TODO: Add methods for task operations
        //TODO: Override ToSpring() for display formatting
    }
}
