using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Model
{
    public class TaskManagerMemento
    {
        public List<Task> Tasks { get;}

        public TaskManagerMemento(List<Task> tasks)
        {
            Tasks = new List<Task>(tasks);
        }
    }
}
