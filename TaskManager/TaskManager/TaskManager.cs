using System;

namespace TaskManager
{
    public static class TaskManager
    {
        public static string tasksFilePath = Environment.CurrentDirectory + "\\..\\..\\data\\tasks.txt";

        public static void addNewTask(Task task)
        {
            FileManager.AppendToFile(task.TaskToString(), tasksFilePath);
        }
    }
}
