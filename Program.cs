using System;
using System.Collections.Generic;

namespace Z2
{
    public class Logic
    {
        public static Boolean IsMistake (int j)
        {
            if (j < 2 || j > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String Сounting(int quantityOfPupils)
        {
            int j = 0;
            Console.WriteLine("Введите по порядку оценки учеников:");
            int[] grade = new int[quantityOfPupils];
            for (int i = 0; i < quantityOfPupils; i++)
            {
                while (true)
                {
                    j = int.Parse(Console.ReadLine());
                    if (IsMistake(j))
                    {
                        Console.WriteLine("Оценка не может быть меньше 2 и больше 5");
                    }
                    else
                    {
                        grade[j - 2]++;
                        break;
                    }
                }
            }
            return ($"\nВсего в классе\n{grade[3]} пятерки\n{grade[2]} четверки\n{grade[1]} тройки \n{grade[0]} двойки");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учеников.");
            int quantityOfPupils = int.Parse(Console.ReadLine());
            Console.WriteLine(Logic.Сounting(quantityOfPupils));
        }
    }
}
