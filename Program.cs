using System;

namespace Циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo;

            while (true)
            {
                Console.WriteLine("Введите 1 число: ");
                numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2 число: ");
                numberTwo = Convert.ToInt32(Console.ReadLine());
                if (numberOne > 0 && numberTwo > 0)
                    break;
                else
                {
                    Console.WriteLine("Вы ввели отрицательное число");
                    continue;
                }
            
                





            }

            int sum = 0;

              if (numberOne > numberTwo)
                {
                    Console.WriteLine("Число 1 больше числа 2");

                }
                for (int i = numberOne; i <= numberTwo; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Сумма чисел от " + numberOne + " до " + numberTwo + ": " + sum);
            
                

            

            

        }
    }
}
