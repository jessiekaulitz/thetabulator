using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TheTabulator
{
    public partial class To_DoList : UserControl
    {
        public To_DoList()
        {
            InitializeComponent();
        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Adding new task to the To_DoList
            lstTasks.Items.Add(txtTaskDescription.Text);

            // Resetting text back to Task Description
            txtTaskDescription.Text = "Task Description";
        }

        private void TxtTaskDescription_Click(object sender, EventArgs e)
        {
            txtTaskDescription.SelectAll();
        }

        private void TxtToDoListName_Click(object sender, EventArgs e)
        {
            txtToDoListName.SelectAll();
        }

        private void TxtTaskDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checking if the enter key was pressed
            if(e.KeyChar == (char)Keys.Enter)
            {
                // Stops "Ding" sound from happening on enter press
                e.Handled = true;

                // Clicks the Add button and selects all of the 
                // text in the text box
                btnAdd.PerformClick();
                txtTaskDescription.SelectAll();

            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem task in lstTasks.Items)
            {
                // Checking if there is a task selected in the To_DoList
                if (task.Selected)
                {
                    // Inserts a new step under the selected task
                    lstTasks.Items.Insert(task.Index + 1, "New Step");
                    lstTasks.Items[task.Index + 1].IndentCount = task.IndentCount + 1;
                }
            }
        }
         
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem task in lstTasks.Items)
            {
                // Checking if there is a task selected in the To_DoList
                if (task.Selected)
                {
                    foreach(ListViewItem subtask in lstTasks.Items)
                    {
                        // Checks if the second task is more indented and has a higher index
                        // If it does it means it is one of the tasks sub tasks
                        if(subtask.IndentCount > task.IndentCount && subtask.Index > task.Index)
                        {
                            subtask.Remove();
                        }
                        // Checks if the second task has the same indentation and a higher index
                        // If it does it means that all of the sub tasks of the task have been removed
                        // there for it needs to break out of the loop
                        else if(subtask.IndentCount == task.IndentCount && subtask.Index > task.Index)
                        {
                            break;
                        }
                        
                    }
                    task.Remove();
                    break;
                }
            }
        }

        private void BtnMoveTaskUp_Click(object sender, EventArgs e)
        {
            int taskIndex = 0;
            int subtaskIndex = 0;

            ListViewItem subtask;

            foreach (ListViewItem task in lstTasks.Items)
            {
                // Checking if there is a task selected in the To_DoList
                if (task.Selected)
                {
                    taskIndex = task.Index;

                    // Checking that the task is not the first in the list
                    if(taskIndex > 0)
                    {
                        // Checking the task above to see if they have the same indentation
                        // if they do it means the task above does not have any subtasks
                        if (lstTasks.Items[taskIndex-1].IndentCount == task.IndentCount)
                        {
                            // Updating the values of the subtask and task indexes
                            subtaskIndex = taskIndex + 1;
                            taskIndex = taskIndex - 1;

                            // Removes the task and inserts it at its new index
                            task.Remove();
                            lstTasks.Items.Insert(taskIndex, task);

                            // Looping through all of the elements after the task to see if it
                            // has any subtasks
                            for (int i = subtaskIndex; i < lstTasks.Items.Count; i++)
                            {
                                subtask = lstTasks.Items[i];
                                taskIndex = taskIndex + 1;

                                // Checking if there is a subtask
                                if (subtask.IndentCount > task.IndentCount)
                                {
                                    // Removes the subtask and inserts it at its new index
                                    subtask.Remove();
                                    lstTasks.Items.Insert(taskIndex, subtask);
                                }
                                // If there is no subtasks left breaks out of the loop
                                else
                                {
                                    break;
                                }
                            }
                        }
                        // Checking if the task above has subtasks
                        else if (lstTasks.Items[taskIndex - 1].IndentCount > task.IndentCount)
                        {
                            subtaskIndex = taskIndex + 1;
                            // Loops until it finds where the start of the task above is
                            while (lstTasks.Items[taskIndex - 1].IndentCount > task.IndentCount)
                            {
                                if(taskIndex > 0)
                                {
                                    taskIndex = taskIndex - 1;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            // Decreases taskIndex so that it is positioned above the task that is above the current one
                            taskIndex = taskIndex - 1;

                            // Removes the task and inserts it at its new index
                            task.Remove();
                            lstTasks.Items.Insert(taskIndex, task);

                            // Looping through all of the elements after the task to see if it
                            // has any subtasks
                            for (int i = subtaskIndex; i < lstTasks.Items.Count; i ++)
                            {
                                subtask = lstTasks.Items[i];
                                taskIndex = taskIndex + 1;

                                // Checking if there is a subtask
                                if (subtask.IndentCount > task.IndentCount)
                                {
                                    // Removes the subtask and inserts it at its new index
                                    subtask.Remove();
                                    lstTasks.Items.Insert(taskIndex, subtask);
                                }
                                else if (taskIndex > subtaskIndex)
                                {
                                    // If there is no subtasks left breaks out of the loop
                                    break;
                                }
                            }

                        }
                    }
                    break;
                }
            }
        }

        private void BtnMoveTaskDown_Click(object sender, EventArgs e)
        {
            int taskIndex = 0;
            int subtaskIndex = 0;

            ListViewItem subtask;

            foreach (ListViewItem task in lstTasks.Items)
            {
                // Checking if there is a task selected in the To_DoList
                if (task.Selected)
                {
                    taskIndex = task.Index;
                    // Checking the task is not the last task in the list
                    if (taskIndex < lstTasks.Items.Count)
                    {
                        // Checking there is no subtask below the selected task
                        if (lstTasks.Items[taskIndex + 1].IndentCount == task.IndentCount)
                        {
                            taskIndex = taskIndex + 1;
                            subtaskIndex = taskIndex;
                            // Removes the task and inserts it at its new index
                            task.Remove();
                            lstTasks.Items.Insert(taskIndex, task);
                        }
                        // Checking if there is a subtask below the task
                        else if (lstTasks.Items[taskIndex + 1].IndentCount > task.IndentCount)
                        {
                            subtaskIndex = taskIndex;

                            // Loops until it finds where the end of the selected task is
                            while (lstTasks.Items[taskIndex + 1].IndentCount > task.IndentCount)
                            {
                                if (taskIndex != lstTasks.Items.Count - 2)
                                {
                                    taskIndex = taskIndex + 1;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            
                            taskIndex = taskIndex + 1;

                            // Checking that the new index is not the last position in the list
                            if (taskIndex != lstTasks.Items.Count - 1)
                            {
                                // Checking if the task that was in the taskIndex had any subtask
                                if (lstTasks.Items[taskIndex + 1].IndentCount > task.IndentCount)
                                {
                                    // // Loops until it finds where the end of the second task is
                                    while (lstTasks.Items[taskIndex + 1].IndentCount > task.IndentCount)
                                    {
                                        if (taskIndex != lstTasks.Items.Count - 2)
                                        {
                                            taskIndex = taskIndex + 1;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }

                            // Removes the task and inserts it at its new index
                            task.Remove();
                            lstTasks.Items.Insert(taskIndex, task);

                            subtask = lstTasks.Items[subtaskIndex];

                            // Finding all of the subtasks of the selected task
                            while (subtask.IndentCount > task.IndentCount)
                            {
                                if (subtask.IndentCount > task.IndentCount)
                                {
                                    // Removes the task and inserts it at its new index
                                    subtask.Remove();
                                    lstTasks.Items.Insert(taskIndex, subtask);
                                    // Updates subtask
                                    subtask = lstTasks.Items[subtaskIndex];
                                }
                                else if (taskIndex > subtaskIndex)
                                {
                                    break;
                                }

                            }

                        }
                    }
                    break;
                }
            }
        }
    }
}
