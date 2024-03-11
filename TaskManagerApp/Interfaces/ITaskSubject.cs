using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Interfaces
{
    public interface ITaskSubject
    {
        void AddObserver(ITaskObserver observer);
        void RemoveObserver(ITaskObserver observer);
        void NotifyObservers();
    }
}
