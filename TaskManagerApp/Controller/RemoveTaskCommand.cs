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
        private TaskManagerMemento previousState;
        private TaskManagerCaretaker caretaker;

        public RemoveTaskCommand(Task task, TaskManager taskManager, TaskManagerCaretaker taskManagerCaretaker)
        {
            this.taskManager = taskManager;
            this.taskToRemove = task;            
            caretaker = taskManagerCaretaker;
        }
        public void Execute()
        {
            previousState = taskManager.CreateMemento();
            taskManager.RemoveTask(taskToRemove);
            caretaker.SaveMemento(taskManager.CreateMemento());
        }
        public void Undo()
        {
            taskManager.SetMemento(previousState);
        }
    }
}
