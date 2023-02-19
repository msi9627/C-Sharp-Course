using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public static class UserManager
    {
        // путь к txt-файлу с данными о внесенных в систему пользователях
        public static string usersFilePath = Environment.CurrentDirectory + "\\..\\..\\data\\users.txt";
        // статическая переменная, хранящая текущего залогиненного пользователя
        public static User currentUser;

        /// <summary>
        /// Вызывает метод добавления пользователя в файл с данными
        /// </summary>
        public static void addNewUser(User user)
        {
            FileManager.AppendToFile(usersFilePath, user.UserToString());
        }
    }
}
