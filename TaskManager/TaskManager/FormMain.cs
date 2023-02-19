using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListView = System.Windows.Forms.ListView;

namespace TaskManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btAddTask_Click(object sender, EventArgs e)
        {
            FormAddTask addTaskForm = new FormAddTask();
            addTaskForm.Show();
        }

        public void RefreshListViewData(User byUser = null)
        {
            listView_TODO.Items.Clear();
            listView_PR.Items.Clear();
            listView_DONE.Items.Clear();

            List<string[]> tasks = FileManager.ReadFile(TaskManager.tasksFilePath);
            if (byUser != null)
            {
                List<string[]> userTasks = new List<string[]>();
                foreach (string[] task in tasks)
                    if (task[2] == byUser.Name)
                        userTasks.Add(task);
                tasks = userTasks;
            }
            foreach (string[] task in tasks)
            {
                ListViewItem listViewItem = new ListViewItem(task);
                listViewItem.Tag = task;
                switch (task[3])
                {
                    case "Сделать":
                        listView_TODO.Items.Add(listViewItem);
                        break;
                    case "В процессе":
                        listView_PR.Items.Add(listViewItem);
                        break;
                    case "Готово":
                        listView_DONE.Items.Add(listViewItem);
                        break;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cbDisplayTasks.SelectedIndex = 0;
            RefreshListViewData(byUser: UserManager.currentUser);
        }

        private void itemDrag(ListView lv, object sender, ItemDragEventArgs e)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lv.DoDragDrop(items, DragDropEffects.Move);
        }

        private void dragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        // возникает при завершении операции перетаскивания
        private void dragDrop(ListView lv, object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    string[] oldData = { lvi.SubItems[0].Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text, lvi.SubItems[3].Text };
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    switch (lv.Tag)
                    {
                        case "TODO":
                            lvi.SubItems[3].Text = "Сделать";
                            break;
                        case "InProgress":
                            lvi.SubItems[3].Text = "В процессе";
                            break;
                        case "Done":
                            lvi.SubItems[3].Text = "Готово";
                            break;
                    }
                    string[] newData = { lvi.SubItems[0].Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text, lvi.SubItems[3].Text };
                    FileManager.ReplaceRowInFile(
                        TaskManager.tasksFilePath,
                        String.Join(",", oldData),
                        String.Join(",", newData)
                    );
                    lv.Items.Add(lvi);
                }
            }
        }

        private void btRemoveTask_Click(object sender, EventArgs e)
        {
            if (listView_DONE.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Удалить выбранные задачи?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem selItem in listView_DONE.SelectedItems)
                    {
                        string description = selItem.SubItems[0].Text;
                        string date = selItem.SubItems[1].Text;
                        string workerUserName = selItem.SubItems[2].Text;
                        string status = selItem.SubItems[3].Text;

                        string rowToRemove = $"{description},{date},{workerUserName},{status}";
                        FileManager.RemoveLine(TaskManager.tasksFilePath, rowToRemove);

                        listView_DONE.SelectedItems[0].Remove();
                    }
                }
            }
        }

        private void listView_DONE_ItemDrag(object sender, ItemDragEventArgs e)
        {
            itemDrag(listView_DONE, sender, e);
        }

        private void listView_DONE_DragOver(object sender, DragEventArgs e)
        {
            dragOver(sender, e);
        }

        private void listView_DONE_DragDrop(object sender, DragEventArgs e)
        {
            dragDrop(listView_DONE, sender, e);
        }

        private void listView_PR_DragDrop(object sender, DragEventArgs e)
        {
            dragDrop(listView_PR, sender, e);
        }

        private void listView_PR_DragOver(object sender, DragEventArgs e)
        {
            dragOver(sender, e);
        }

        private void listView_PR_ItemDrag(object sender, ItemDragEventArgs e)
        {
            itemDrag(listView_PR, sender, e);
        }

        private void listView_TODO_ItemDrag(object sender, ItemDragEventArgs e)
        {
            itemDrag(listView_TODO, sender, e);
        }

        private void listView_TODO_DragOver(object sender, DragEventArgs e)
        {
            dragOver(sender, e);
        }

        private void listView_TODO_DragDrop(object sender, DragEventArgs e)
        {
            dragDrop(listView_TODO, sender, e);
        }

        private void cbDisplayTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDisplayTasks.SelectedIndex == 0)
                RefreshListViewData(byUser: UserManager.currentUser);
            else RefreshListViewData();
        }

        public int cbDisplayTasksText
        {
            get { return cbDisplayTasks.SelectedIndex; }
        }
    }
}
