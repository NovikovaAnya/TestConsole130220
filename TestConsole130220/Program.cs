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
            double x = double.Parse(x_str);
            double y = double.Parse(x_str);
            double z = x / y;
            Console.WriteLine($"{x} / {y} = {z:F3}"); //или {2: 0.00##}
            Console.ReadLine();
        }
    }
}

