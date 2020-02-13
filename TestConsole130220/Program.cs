using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole130220
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x>");
            String x_str = Console.ReadLine();
            Console.Write("Введите y>");
            String y_str = Console.ReadLine();
            int x = int.Parse(x_str);
            int y = int.Parse(x_str);
            int z = x + y;
            Console.WriteLine($"{x} + {y} = {z}");
            Console.ReadLine();
        }
    }
}

