using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Interfaces;

namespace TaskManagerApp.Model
{
    public class TaskManager : ITaskSubject
    {
        private List<ITaskObserver> observers;
        private List<Task> tasks;

        public TaskManager()
        {
            observers = new List<ITaskObserver>();
            tasks = new List<Task>();
        }
        public void AddObserver(ITaskObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.UpdateTask(tasks);
            }
        }

        public void RemoveObserver(ITaskObserver observer)
        {
            observers.Remove(observer);
        }
        public void AddTask(Task task)
        {
            tasks.Add(task);
            NotifyObservers();
        }
    }
}
