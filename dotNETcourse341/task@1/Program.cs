using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            WriteRead wr = new WriteRead();
            wr.ReadCircle(circle);
            wr.WriteCircle(circle);
        }
    }
}
