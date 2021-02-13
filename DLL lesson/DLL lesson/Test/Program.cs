using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_lesson;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            Console.Write("Введите первое число: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(DLLLessonClass.Addition(firstNum, secondNum));

            Console.ReadKey();
        }
    }
}
