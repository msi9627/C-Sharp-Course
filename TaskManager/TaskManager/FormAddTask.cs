using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class FormAddTask : Form
    {
        public FormAddTask()
        {
            InitializeComponent();
        }

        private void btAddTask_Click(object sender, EventArgs e)
        {
            if (cbStatuses.SelectedItem != null)
            {
                DateTime taskDate = dateTimePicker1.Value;
                object userName = cbUsers.SelectedItem;
                string statusName = cbStatuses.SelectedItem.ToString();
                string description = tbDescr.Text;

                if (userName == null)
                    TaskManager.addNewTask(new Task(description, taskDate, statusName));
                else TaskManager.addNewTask(new Task(description, taskDate, userName.ToString(), statusName));

                var formMain = System.Windows.Forms.Application.OpenForms["FormMain"];
                if (formMain != null)
                {
                    if ((formMain as FormMain).cbDisplayTasksText == 0)
                        (formMain as FormMain).RefreshListViewData(UserManager.currentUser);
                    else (formMain as FormMain).RefreshListViewData();
                }
                MessageBox.Show("Задача добавлена", "Успешно", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Пожалуйста, выберите статус задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FormAddTask_Load(object sender, EventArgs e)
        {
            cbUsers.Items.Clear();
            List<string[]> users = FileManager.ReadFile(UserManager.usersFilePath);
            foreach (string[] user in users)
                cbUsers.Items.Add(user[0]);
        }
    }
}
