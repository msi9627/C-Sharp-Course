using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class FormAuthorize : Form
    {
        public FormAuthorize()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbPass.Text != "")
            {
                List<string[]> users = FileManager.ReadFile(UserManager.usersFilePath);
                foreach (string[] user in users)
                    if (tbLogin.Text == user[0] && tbPass.Text == user[1])
                    {
                        UserManager.currentUser = new User(tbLogin.Text, tbPass.Text);
                        FormMain formMain = new FormMain();
                        formMain.Show();
                        return;
                    }
                MessageBox.Show("Нет такого пользователя. Пожалуйста, зарегистрируйтесь.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbPass.Text != "")
            {
                DialogResult result = MessageBox.Show("Зарегистрироваться с этим логином и паролем?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UserManager.addNewUser(new User(tbLogin.Text, tbPass.Text));
                    MessageBox.Show("Вы успешно зарегистрировались в системе. Пожалуйста, войдите в систему.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
