using System;
using System.Threading;

namespace TaskManager
{
    public class Task : Status
    {
        public string Description { get; }
        public string Date { get; }
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

        private string DateToString(DateTime date)
        {
            return $"{date.Day}.{date.Month}.{date.Year} {date.Hour}:{date.Minute}:{date.Second}";
        }

        public string TaskToString()
        {
            return $"{Description},{Date},{WorkerUserName},{Name}";
        }
    }
}
