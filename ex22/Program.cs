using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
            int minRandomValue = 0;
            int maxRandomValue = 10;
            int repeatitionCount = 0;
            int repeatitions = 1;
            int repeatedNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write($"{array[i]}");
            }

            Console.WriteLine();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    repeatitions++;
                }
                else
                {
                    repeatitions = 1;
                }

                if (repeatitions > 1)
                {
                    repeatitionCount = repeatitions;
                    repeatedNumber = array[i];
                }
            }

            Console.WriteLine($"Повторений: {repeatitionCount}\nЧисло: {repeatedNumber}");
        }
    }
}
