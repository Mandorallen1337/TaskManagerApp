namespace TaskManagerApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTasks.ForeColor = System.Drawing.Color.White;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 20;
            this.listBoxTasks.Location = new System.Drawing.Point(483, 12);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(646, 704);
            this.listBoxTasks.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(321, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 37);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add task";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(321, 72);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(145, 37);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove task";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeButton.Location = new System.Drawing.Point(321, 137);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(145, 37);
            this.completeButton.TabIndex = 1;
            this.completeButton.Text = "Complete Task";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.Location = new System.Drawing.Point(321, 206);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(145, 37);
            this.undoButton.TabIndex = 1;
            this.undoButton.Text = "Undo Remove";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // quickSortButton
            // 
            this.quickSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSortButton.Location = new System.Drawing.Point(321, 279);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(145, 37);
            this.quickSortButton.TabIndex = 1;
            this.quickSortButton.Text = "QuickSort";
            this.quickSortButton.UseVisualStyleBackColor = true;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleSortButton.Location = new System.Drawing.Point(321, 345);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(145, 37);
            this.bubbleSortButton.TabIndex = 1;
            this.bubbleSortButton.Text = "BubbleSort";
            this.bubbleSortButton.UseVisualStyleBackColor = true;
            this.bubbleSortButton.Click += new System.EventHandler(this.bubbleSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1407, 749);
            this.Controls.Add(this.bubbleSortButton);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Button bubbleSortButton;
    }
}

