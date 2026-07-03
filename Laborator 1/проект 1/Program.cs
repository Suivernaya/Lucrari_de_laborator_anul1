using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет моя любимая мама, введи любое число");
            int a = int.Parse(Console.ReadLine());
            int b = a * 3;
            Console.WriteLine($"твое число помноженное на три, будет равно {b}");
            Console.ReadKey();
        }
    }
}
