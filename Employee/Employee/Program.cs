using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            Manager m1 = new Manager("Василий", 10.0, 1, 1, 2020);
            Manager m2 = new Manager("Мария", 10.0, 1, 1, 2022, 50);
            Manager m3 = new Manager("Петр", 100.0, 27, 6, 2021);
            Console.WriteLine(m2.getBonus());
            m2.setBonus(100);
            Console.WriteLine(m2.getBonus());
            Console.WriteLine(m2.getSalary());
            Console.WriteLine(m2.ToString());

            Employee e1 = new Employee();
            Employee e2 = new Employee("Владислав", 200.0);
            Employee e3 = new Employee("Максим", 70.0, 13, 6, 2019);
            Console.WriteLine(e1.ToString());
        }
    }
}
