using System;

namespace Employee
{
    internal class Manager : Employee
    {
        // поля:
        private double bonus;

        //конструктор1:
        // инициализировать переменные суперкласса с помощью параметризированного конструктора
        // премии нет
        public Manager(string name, double salary, int d, int m, int y) : base(name, salary, d, m, y)
        {
            Console.WriteLine("Я создал экземпляр класса Manager!");
            Console.WriteLine(base.getInfo());
        }

        //конструктор2:
        // инициализировать переменные суперкласса с помощью параметризированного конструктора
        // установить премию
        public Manager(string name, double salary, int d, int m, int y, double bonus) : base(name, salary, d, m, y)
        {
            this.bonus = bonus;
        }

        // методы:
        // возвращает значение премии
        public double getBonus()
        {
            return this.bonus;
        }

        // устанавливает премию, размер премии передается в качестве параметра
        public void setBonus(double bonus)
        {
            this.bonus = bonus;
        }

        // переопределить метод getSalary(), для менеджера метод должен возвращать сумму зарплаты и бонуса
        public new double getSalary()
        {
            return base.getSalary() + getBonus();
        }

        // переопределить метод ToString(), что бы он возвращал строку вида: id менеджер ФИО зарплата(бонус)
        public override string ToString() {
            return $"ID: {base.getId()}\tМенеджер\tИмя: {base.getName()}\tЗарплата(бонус): {getSalary()}({getBonus()})";
        }

    }
}
