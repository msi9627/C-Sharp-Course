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
        public static string usersFilePath = Environment.CurrentDirectory + "\\..\\..\\data\\users.txt";

        public static void addNewUser(User user)
        {
            FileManager.AppendToFile(usersFilePath, user.UserToString());
        }
    }
}
