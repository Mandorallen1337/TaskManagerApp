using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Interfaces;

namespace TaskManagerApp.Controller
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(List<Task> tasks)
        {
            int n = tasks.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tasks[j].Deadline > tasks[j + 1].Deadline)
                    {
                        Task temp = tasks[j];
                        tasks[j] = tasks[j + 1];
                        tasks[j + 1] = temp;
                    }
                }
            }
        }

    }
}
