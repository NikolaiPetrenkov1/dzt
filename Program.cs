//N1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string s = "3  4  5";
                Console.Write(s);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}


/*N2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 21;
            do
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}


N3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.WriteLine("Введите расстояние в сантиметрах:");
            do
            {

                a = double.Parse(Console.ReadLine());
                b = a / 100;
                Console.WriteLine(b);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}

N4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 234;
            int b;

            do
            {
                b = a / 7;

                Console.WriteLine("за 234 дня прошло:");
                Console.WriteLine(b);
                Console.WriteLine("недель");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}*/
