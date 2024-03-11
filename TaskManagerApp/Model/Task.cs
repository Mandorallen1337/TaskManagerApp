using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
    public class Task
    {
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public TaskPriority Priority { get; set; }
        public bool Completed { get; set; }

        public Task(string name, DateTime deadline, TaskPriority priority)
        {
            Name = name;
            Deadline = deadline;
            Priority = priority;
            Completed = false;
        }

        public override string ToString()
        {
            return $"{Name} - Deadline: {Deadline.ToShortDateString()}, Priority: {Priority}, Completed: {Completed}";
        }
    }
    
}
