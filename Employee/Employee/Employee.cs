using System;

namespace Employee
{
    internal class Employee
    {
        private int id;
        private static int nextId;
        private string name;
        private double salary;
        private DateTime date_of_emp;

        public Employee()
        {
            setId();
            Console.WriteLine("Я создал объект класса Employee");
        }

        public Employee(string name, double salary, int d, int m, int y)
        {
            setId();
            this.name = name;
            this.salary = salary;
            try
            {
                this.date_of_emp = DateTime.Parse($"{d}.{m}.{y}");
                Console.WriteLine(getInfo());
            }
            catch
            {
                Console.WriteLine("Произошла ошибка в процессе парсинга даты");
            }
        }

        public Employee(string name, double salary)
        {
            setId();
            this.name = name;
            this.salary = salary;
            Console.WriteLine(getInfo());
        }

        public void setId()
        {
            this.id = nextId++;
        }
        public int getId()
        {
            return this.id;
        }
        
        public static int getNextId()
        {
            return nextId;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return this.salary;
        }

        public void setDateOfEmp(int d, int m, int y)
        {
            try
            {
                this.date_of_emp = DateTime.Parse($"{d}.{m}.{y}");
            }
            catch
            {
                Console.WriteLine("Произошла ошибка в процессе парсинга даты");
            }
        }

        public DateTime getDateOfEmp()
        {
            return this.date_of_emp;
        }

        public double increaseSalary(int procent)
        {
            double newSalary = this.salary + (this.salary * procent / 100);
            setSalary(newSalary);
            return newSalary;
        }

        public double getWorkExperience()
        {
            return Math.Round(((DateTime.Now - this.date_of_emp).TotalDays)/365, 2);
        }

        public string getInfo() // печатает информацию об экземпляре класса
        {
            return $"Имя: {this.name}\tЗар. плата: {this.salary}\tДата приема: {this.date_of_emp.ToShortDateString()}"; // интерполяция строк
        }

        //  переопределить метод toString() в классе Employee, что бы он возвращал строку вида: id сотрудник ФИО зарплата
        public override string ToString()
        {
            return $"ID: {getId()}\tСотрудник\tФИО: {getName()}\tЗар. плата: {getSalary()}\tДата приема: {getDateOfEmp().ToShortDateString()}";
        }
    }
}
