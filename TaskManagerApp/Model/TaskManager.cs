﻿using System;
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
        private ISortStrategy sortStrategy;

        public TaskManager(ISortStrategy sortStrategy)
        {
            observers = new List<ITaskObserver>();
            tasks = new List<Task>();
            this.sortStrategy = sortStrategy;

        }
        public void SetSortStrategy(ISortStrategy newStrategy)
        {
            sortStrategy = newStrategy;
        }
        public TaskManagerMemento CreateMemento()
        {
            return new TaskManagerMemento(tasks);
        }

        public void SetMemento(TaskManagerMemento memento)
        {
            tasks = memento.Tasks;
            NotifyObservers();
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
        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
            NotifyObservers();
        }
        public List<Task> GetTasks()
        {
            return tasks;
        }
        public void SortTasks()
        {
            sortStrategy.Sort(tasks);
            NotifyObservers();
        }
    }
}
