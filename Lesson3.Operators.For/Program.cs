using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Operators.For
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (инициализация; условие; итерация) оператор;

            int count;

            for (count = 0; count < 10; count = count)
            {
                Console.WriteLine("подсчет count: " + ++count);
            }
                
            Console.WriteLine("Цикл for завершен…");
            
            int i, j;
            for (i = 0, j = 10; i < j; i++, j--)
            {
                Console.WriteLine("i и j: " + i + " " + j);
            }
            Console.WriteLine("Цикл for завершен…");
            
            Console.ReadKey();
        }
    }
}
