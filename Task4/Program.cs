using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {//Найти индекс максимального элемента массива
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }

            int min = array[0];
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (min < array[i])
                {
                    min = array[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine(maxIndex);
            Console.ReadLine();
        }
    }
}
