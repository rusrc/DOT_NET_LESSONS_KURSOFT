using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Operators.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            int i;
            for (i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("i равно нулю");
                        break;
                    case 1:
                        Console.WriteLine("i равно единице");
                        break;
                    case 2:
                        Console.WriteLine("i равно двум");
                        break;
                    case 3:
                        Console.WriteLine("i равно трем");
                        break;
                    default:
                        Console.WriteLine("i равно или больше пяти");
                        break;
                }
            }*/
            
            int resultMult;
            int i = 5;
            int j = 3;
            switch (i)
            {
                case 5:
                    Console.WriteLine("Хмм... это число равно " + i);

                    switch (j)
                    {
                        case 3:
                            Console.WriteLine("Оуу... а второе число равно трем... а давайте умножим их друг на друга...");
                            resultMult = i * j;
                            Console.WriteLine("Результат умножения i * j = " + resultMult);
                            break;

                        case 2:
                            Console.WriteLine("Ну уж нет... это уже меньше трех... я не буду умножать...");
                            break;
                    } // окончание вложенного оператора switch

                    break;

                case 4:
                    Console.WriteLine("Я даже не возьмусь за это... ");
                    break;
                    //И так далее
            }

            Console.ReadKey();
        }
    }
}









/*
//Вложенные операторы switch
            int j = 3;
            int resultMult;

            switch (i)
            {
                case 5:
                    Console.WriteLine("Хмм... это число равно " + i);

                    switch (j)
                    {
                        case 3:
                            Console.WriteLine("Оуу... а второе число равно трем... а давайте умножим их друг на друга...");
                            resultMult = i * j;
                            Console.WriteLine("Результат умножения i * j = " + resultMult);
                            break;

                        case 2:
                            Console.WriteLine("Ну уж нет... это уже меньше трех... я не буду умножать...");
                            break;
                    } // окончание вложенного оператора switch

                    break;

                case 4:
                    Console.WriteLine("Я даже не возьмусь за это... ");
                    break;
                    //И так далее
            }
*/
