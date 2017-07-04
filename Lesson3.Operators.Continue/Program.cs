using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Operators.Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 25; i++)
            {
                if ((i % 2) != 0) continue; // перейти к следующему шагу итерации
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
