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

            taskManager = new TaskManager();
            taskManager.AddObserver(this);

            AddInitialTasks();

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxTasks.Items.Clear();
            tasks = taskManager.GetTasks();
            foreach (Task task in tasks)
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
                    addTaskCommand = new AddTaskCommand(taskManager, newTask);
                    addTaskCommand.Execute();
                    UpdateListBox();
                    
                }
            }
            
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                Task taskToRemove = tasks[listBoxTasks.SelectedIndex];
                RemoveTaskCommand removeTaskCommand = new RemoveTaskCommand(taskToRemove, taskManager);
                removeTaskCommand.Execute();
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

        private void AddInitialTasks()
        {
            // Skapa en lista av uppgifter som ska läggas till
            List<Task> initialTasks = new List<Task>
    {
             new Task("Gör Läxor", DateTime.Now, TaskPriority.High),
             new Task("Städa köket", DateTime.Now, TaskPriority.Low),
             new Task("Börja koda", DateTime.Now, TaskPriority.Medium),
             new Task("Gå ut med hunden", DateTime.Now.AddDays(1), TaskPriority.Low),
             new Task("Träna", DateTime.Now.AddDays(1), TaskPriority.Medium),
             new Task("Handla mat", DateTime.Now.AddDays(2), TaskPriority.High),
             new Task("Läs en bok", DateTime.Now.AddDays(3), TaskPriority.Medium),
             new Task("Ring mamma", DateTime.Now.AddDays(4), TaskPriority.Low),
             new Task("Skriv rapport", DateTime.Now.AddDays(5), TaskPriority.High),
             new Task("Planera semester", DateTime.Now.AddDays(7), TaskPriority.Medium)
    };

            // Skapa en instans av AddTaskCommand för varje uppgift och lägg till den i TaskManager
            foreach (Task task in initialTasks)
            {
                AddTaskCommand addTaskCommand = new AddTaskCommand(taskManager, task);
                addTaskCommand.Execute();
            }
        }
    }

}
