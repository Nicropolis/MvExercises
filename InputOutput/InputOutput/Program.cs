﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}  Зарплата: {salary}$");
            Console.ReadKey();
        }
    }
}
