using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Operators.doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                if (i == 0)
                {
                    Console.WriteLine("Значение переменной i = " + i);
                    Console.WriteLine("Цикл на этом и завершился");
                }

                if (i > 0)
                {
                    Console.WriteLine("Значение переменной i = " + i);
                    Console.WriteLine("Цикл работает, пока i не больше 10");
                    if (i >= 10)
                    {
                        Console.WriteLine("Ну вот и все...");
                        break;
                    }
                    i++;
                }

            } while (i > 0);


            Console.ReadKey();
        }
    }
}