using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Operators.While
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (условие) оператор;

            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine("Значение переменной i = " + i);
            }

            Console.ReadKey();
        }
    }
}
