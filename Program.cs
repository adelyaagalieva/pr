using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 s = new Class1();
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            int Greater = s.Greater(x, y);
            Console.WriteLine("Greater number from {0} and {1} is {2}", x, y, Greater);
            Console.ReadKey();
        }
    }
}
