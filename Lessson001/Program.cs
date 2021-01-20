using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя:\n");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
        }
    }
}
