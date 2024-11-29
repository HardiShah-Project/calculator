using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           double a = 0;
           double b = 0;
            Console.WriteLine("type a number and then press enter");
            a = Convert.ToDouble(Console.ReadLine());
            b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("CHOOSE AN OPTION");
            Console.WriteLine("\ta- add");
            Console.WriteLine("\tb- sub");
            Console.WriteLine("\tc- mul");
            Console.WriteLine("\td- div");
            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine(a + b);
                    break;
                case "b":
                    Console.WriteLine(a - b);
                    break;
                case "c":
                    Console.WriteLine(a * b);
                    break;
                case "d":
                    Console.WriteLine(a / b);
                    break;

            }
            Console.WriteLine("press any key to break");
            Console.ReadKey();
        }
    }
}
