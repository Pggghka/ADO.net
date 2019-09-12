using System;
namespace task2
{
    public class User
    {
        public string Name, Surname, LastName;
        public DateTime Birthsday;
        public int Age;

        public User(string N, string S, string L, DateTime B)
        {
            Name = N;
            Surname = S;
            LastName = L;
            Birthsday = B;
            Age = DateTime.Today.Subtract(Birthsday).Days/365;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Person Information: {0} {1} {2} (Birthsday: {3}, Age: {4} year(s))", Surname, Name, LastName, Birthsday.ToLongDateString(), Age);
        }
    }

    public class Employee : User
    {
        public string CompamyName, Position;
        public int Experience;
        public Employee(string N, string S, string L, DateTime B, string ComName, string Pos, int Exp) : base(N, S, L, B)
        {
            CompamyName = ComName;
            Position = Pos;
            Experience = Exp;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\nPerson Information: {0} {1} {2} (Birthsday: {3}, Age: {4} year(s))", Surname, Name, LastName, Birthsday.ToLongDateString(), Age);
            Console.WriteLine("Employee Information: works at {0} company as {1} for {2} months", CompamyName, Position, Experience);
        }
    }
}
