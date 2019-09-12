using System;
namespace task2
{
    public class Ring
    {
        public double x, y, Radius, radius, S, Length;
        public Ring(double x, double y, double Radius, double radius)
        {
            this.x = x;
            this.y = y;
            this.Radius = Radius;
            this.radius = radius;
        }

        public void ShowInfo()
        {
            Console.WriteLine("/nRing information : x={0}, y={1}, inRadius={2}, outRadius={3}", x, y, Radius, radius);
        }

        public void GetS()
        {
            S = Math.PI * (Math.Pow(Radius, 2) - Math.Pow(radius, 2));
            Console.WriteLine("Square is: {0}", S);
        }

        public void GetLength()
        {
            Length = 2 * Math.PI * radius + 2 * Math.PI * Radius;
            Console.WriteLine("Length is: {0}", Length);
        }
    }
}
