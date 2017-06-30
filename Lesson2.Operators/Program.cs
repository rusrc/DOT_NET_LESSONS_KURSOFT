using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 5;

            int resultAdd;
            resultAdd = A + B;
            int resultSubtract;
            resultSubtract = A - B;

            float C = 22;
            float F = 1.8f * C + 32; //Перевод градусов Цельсия по шкале Фаренгейта 

            int D = 3;
            //++D; Инкремент в префиксной форме записи
            //--D; Декремент в префиксной форме записи
            //D++; Инкремент в постфиксной форме записи
            //D--; Декремент в постфиксной форме записи

            D = 2;

            D += 2;
            D = D + 2;

            Console.Write(resultAdd + "\n"); // "\n" - символ форматирования перехода каретки на новую строку
            Console.Write(resultSubtract + "\n");
            Console.Write(F++/2 + "\n");
            Console.Write(D);
            Console.ReadKey();
        }
    }
}
