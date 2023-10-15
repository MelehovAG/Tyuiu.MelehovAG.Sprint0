using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MelehovAG.Sprint0.Task5.V0.Lib;

namespace Tyuiu.MelehovAG.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Addition
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            //Вызов метода сложения Substruction
            Console.WriteLine("A - B = " + DataService.Substruction(15, 5));
            //Вызов метода сложения Multiplication
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            //Пример разветвляющейся структуры находится в библиотеке классов в методе Division
            Console.WriteLine("A / B = " + DataService.Division(9, 3));

            Console.ReadKey();
        }
    }
}
