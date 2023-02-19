namespace TaskManager
{
    public class User
    {
        // имя пользователя
        public string Name { get; set; }
        // пароль (по-хорошему его надо шифровать, а не хранить в открытом виде)
        public string Password { get; set; }

        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        /// <summary>
        /// Возвращает строковое представление текущего объекта класса User
        /// </summary>
        public string UserToString()
        {
            return $"{Name}, {Password}";
        }
    }
}
