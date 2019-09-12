using System;
using System.IO;

namespace task_1
{
    class WriteRead
    {
        public void ReadCircle(Circle circle)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    string[] str;
                    if ((str = sr.ReadLine().Split(' ')) != null)
                    {
                        int radius, X, Y;
                        if (!int.TryParse(str[0], out radius)) { Console.WriteLine("Radius isn't correct"); return; }
                        if (!int.TryParse(str[1], out X)) { Console.WriteLine("X isn't correct"); return; }
                        if (!int.TryParse(str[2], out Y)) { Console.WriteLine("Y isn't correct"); return; }
                        circle.Radius = radius;
                        circle.X = X;
                        circle.Y = Y;
                    }
                }
            }
            catch
            {
                Console.WriteLine("File not found!");
            }
        }

        public void WriteCircle(Circle circle)
        {
            string Filepath = "output.txt";
            using (StreamWriter sw = File.CreateText(Filepath))
            {
                sw.WriteLine("x = {0} , y = {1}, radius = {2}", circle.X, circle.Y, circle.Radius);
                sw.WriteLine("Square = {0}", circle.GetArea);
                sw.WriteLine("Length  = {0}", circle.Length);
            }
        }
    }
}
