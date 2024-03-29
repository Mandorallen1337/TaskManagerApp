﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Interfaces;
using TaskManagerApp.Model;

namespace TaskManagerApp.Controller
{
    public class AddTaskCommand : ICommand
    {
        private TaskManager taskManager;
        private Task taskToAdd;
        

        public AddTaskCommand(Task task, TaskManager taskManager)
        {            
            this.taskToAdd = task;
            this.taskManager = taskManager; 
        }

        public AddTaskCommand(TaskManager taskManager, Task task)
        {
            this.taskManager = taskManager;
            this.taskToAdd = task;
        }

        public void Execute()
        {
            taskManager.AddTask(taskToAdd);
        }
    }
}
