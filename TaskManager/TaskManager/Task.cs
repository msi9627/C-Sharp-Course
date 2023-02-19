using System;
using System.Threading;

namespace TaskManager
{
    public class Task : Status
    {
        // текстовое описание задачи
        public string Description { get; }
        // строковое представление даты в формате dd.MM.yyyy HH:mm:ss
        public string Date { get; }
        // имя исполнителя
        public string WorkerUserName { get; }

        public Task(string description, DateTime date, string workerUserName, string statusName) : base(statusName)
        {
            this.Description = description;
            this.Date = DateToString(date);
            this.WorkerUserName = workerUserName;
            base.Name = statusName;

        }

        public Task(string description, DateTime date, string statusName) : base(statusName)
        {
            this.Description = description;
            this.Date = DateToString(date);
            base.Name = statusName;
        }

        /// <summary>
        /// Метод <c>DateToString</c> вовзращает строковое представление даты в формате dd.MM.yyyy HH:mm:ss
        /// </summary>
        private string DateToString(DateTime date)
        {
            return $"{date.Day}.{date.Month}.{date.Year} {date.Hour}:{date.Minute}:{date.Second}";
        }

        /// <summary>
        /// Метод <c>TaskToString</c> возвращает строковое представление объекта Task
        /// </summary>
        public string TaskToString()
        {
            return $"{Description},{Date},{WorkerUserName},{Name}";
        }
    }
}
