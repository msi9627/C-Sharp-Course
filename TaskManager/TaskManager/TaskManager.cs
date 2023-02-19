using System;

namespace TaskManager
{
    public static class TaskManager
    {
        // путь к txt-файлу с данными о созданных задачах
        public static string tasksFilePath = Environment.CurrentDirectory + "\\..\\..\\data\\tasks.txt";

        /// <summary>
        /// Вызывает метод добавления задачи в файл с данными
        /// </summary>
        public static void addNewTask(Task task)
        {
            FileManager.AppendToFile(task.TaskToString(), tasksFilePath);
        }
    }
}
