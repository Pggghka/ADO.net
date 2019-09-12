using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User Tom = new User("Tom", "Ivanov", "Viktorovich", DateTime.Parse("2012.10.20"));
            Tom.ShowInfo();

            Employee Ivan = new Employee("Ivan", "Sidorov", "Petrovich", DateTime.Parse("1990.10.23"), "Google", "PHP Dev", 18);
            Ivan.ShowInfo();

            Ring ring = new Ring(3, 2, 4, 2);
            ring.ShowInfo();
            ring.GetS();
            ring.GetLength();
        }
    }
}
