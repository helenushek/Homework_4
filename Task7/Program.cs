using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {//Посчитать количество нечетных элементов массива
        static void Main(string[] args)
        {
            int[] array = new int[6];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 1)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
