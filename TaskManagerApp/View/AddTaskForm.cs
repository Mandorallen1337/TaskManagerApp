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

namespace TaskManagerApp.View
{
    public partial class AddTaskForm : Form
    {
        private ISortStrategy sortStrategy;
        private TaskManager taskManager;
        public AddTaskForm()
        {
            InitializeComponent();
            
            comboBoxPriority.DataSource = Enum.GetValues(typeof(TaskPriority)); 
            sortStrategy = new QuickSortStrategy();
            taskManager = new TaskManager(sortStrategy);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            string taskName = nameTextBox.Text;
            DateTime dueDate = dateTimePicker.Value;
            TaskPriority priority = (TaskPriority)comboBoxPriority.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Task GetNewTask()
        {
            string taskName = nameTextBox.Text;
            DateTime dueDate = dateTimePicker.Value;
            TaskPriority priority = (TaskPriority)comboBoxPriority.SelectedItem;

            Task newTask = new Task(taskName, dueDate, priority);
            return newTask;
        }
    }
}
