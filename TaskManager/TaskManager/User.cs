namespace TaskManager
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string UserToString()
        {
            return $"{Name}, {Password}";
        }
    }
}
