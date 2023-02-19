namespace TaskManager
{
    public class Status
    {
        //текстовое название статуса
        public string Name { get; set; }

        public Status(string statusName)
        {
            Name = statusName;
        }
    }
}
