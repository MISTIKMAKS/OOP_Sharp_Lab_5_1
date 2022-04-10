using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A_x: ");
            double x_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("A_y: ");
            double y_a = Convert.ToDouble(Console.ReadLine()); 
            Point a = new Point(x_a, y_a);
            String result_a = a.ToString();
            Console.WriteLine("A: ");
            Console.WriteLine("{0}", result_a);

            Console.Write("B_x: ");
            double x_b = Convert.ToDouble(Console.ReadLine());
            Console.Write("B_y: ");
            double y_b = Convert.ToDouble(Console.ReadLine());
            Point b = new Point(x_b, y_b);
            String result_b = b.ToString();
            Console.WriteLine("B: ");
            Console.WriteLine("{0}", result_b);

            Console.Write("n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" n: {0}", n);
            Console.WriteLine("---------------");

            a = a - n;
            result_a = a.ToString();
            Console.WriteLine("A +> n: ");
            Console.WriteLine("{0}", result_a);
            Console.WriteLine("---------------");

            a = a + n;
            result_a = a.ToString();
            Console.WriteLine("A +^ n: ");
            Console.WriteLine("{0}", result_a);
            Console.WriteLine("---------------");

            double result = a / b;
            Console.WriteLine("A -> B: ");
            Console.WriteLine("{0}", result);
            Console.WriteLine("---------------");

            bool boolean_is = a == b;
            Console.WriteLine("A == B: ");
            Console.WriteLine("{0}", boolean_is);
            Console.WriteLine("---------------");

            bool boolean_not = a != b;
            Console.WriteLine("A != B: ");
            Console.WriteLine("{0}", boolean_not);
            Console.WriteLine("---------------");

            a++;
            result_a = a.ToString();
            Console.WriteLine("A++: ");
            Console.WriteLine("{0}", result_a);
            Console.WriteLine("---------------");
            a--;
            result_a = a.ToString();
            Console.WriteLine("A--: ");
            Console.WriteLine("{0}", result_a);
            Console.WriteLine("---------------");
            ++b;
            result_b = b.ToString();
            Console.WriteLine("++B: ");
            Console.WriteLine("{0}", result_b);
            Console.WriteLine("---------------");
            --b;
            result_b = b.ToString();
            Console.WriteLine("--B: ");
            Console.WriteLine("{0}", result_b);

            Console.ReadKey();
        }
    }
}
