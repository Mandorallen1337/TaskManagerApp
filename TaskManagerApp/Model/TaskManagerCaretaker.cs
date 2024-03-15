using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Model
{
    public class TaskManagerCaretaker
    {
        public Stack<TaskManagerMemento> mementosStack = new Stack<TaskManagerMemento>();

        public void SaveMemento(TaskManagerMemento memento)
        {
            mementosStack.Push(memento);
        }
        public void Undo(TaskManager taskManager)
        {
            if (mementosStack.Count > 0)
            {
                TaskManagerMemento previousState = mementosStack.Pop();
                taskManager.SetMemento(previousState);
            }
        }



    }
}
