using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Interfaces;
using TaskManagerApp.Model;

namespace TaskManagerApp.Controller
{
    public class RemoveTaskCommand : ICommand
    {
        private TaskManager taskManager;
        private Task taskToRemove;

        public RemoveTaskCommand(Task task, TaskManager taskManager)
        {
            this.taskManager = taskManager;
            this.taskToRemove = task;            
        }
        public void Execute()
        {            
            taskManager.RemoveTask(taskToRemove);
        }
    }
}
