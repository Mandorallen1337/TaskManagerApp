using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagerApp.Controller;
using TaskManagerApp.Interfaces;
using TaskManagerApp.Model;
using TaskManagerApp.View;

namespace TaskManagerApp
{
    public partial class Form1 : Form, ITaskObserver
    {
        private List<Task> tasks;
        TaskManager taskManager;
        private AddTaskCommand addTaskCommand;
        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
            taskManager = new TaskManager();
            taskManager.AddObserver(this);

            tasks.Add(new Task("Gör läxor", DateTime.Today, TaskPriority.High));
            tasks.Add(new Task("Träna", DateTime.Today.AddDays(1), TaskPriority.Medium));
            tasks.Add(new Task("Köp mjölk", DateTime.Today.AddDays(2), TaskPriority.Low));

            addTaskCommand = new AddTaskCommand(taskManager, new Task("Gör läxor", DateTime.Today, TaskPriority.High));

            UpdateListBox();

        }

        private void UpdateListBox()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddTaskForm addTaskForm = new AddTaskForm())
            {
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    Task newTask = addTaskForm.GetNewTask();
                    tasks.Add(newTask);
                    addTaskCommand.Execute(newTask);
                    UpdateListBox();
                }
                
                
            }
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
                {
                tasks.RemoveAt(listBoxTasks.SelectedIndex);
                UpdateListBox();

            }
        }

        public void UpdateTask(List<Task> tasks)
        {
            UpdateListBox();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                tasks[listBoxTasks.SelectedIndex].Completed = true;
                UpdateListBox();
            }
            
        }
    }
}
