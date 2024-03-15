using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Interfaces;

namespace TaskManagerApp.Controller
{
    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(List<Task> tasks)
        {
            QuickSort(tasks, 0, tasks.Count - 1);
            
        }
        private void QuickSort(List<Task> tasks, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(tasks, low, high);
                QuickSort(tasks, low, partitionIndex - 1);
                QuickSort(tasks, partitionIndex + 1, high);
            }
        }
        private int Partition(List<Task> tasks, int low, int high)
        {
            Task pivot = tasks[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tasks[j].Deadline < pivot.Deadline)
                {
                    i++;
                    (tasks[j], tasks[i]) = (tasks[i], tasks[j]);
                }
            }
            Task temp1 = tasks[i + 1];
            tasks[i + 1] = tasks[high];
            tasks[high] = temp1;
            return i + 1;
            
        }
    }
}
