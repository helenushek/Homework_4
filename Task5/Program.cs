using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {//Посчитать сумму элементов массива с нечетными индексами 
        static void Main(string[] args)
        {
            int[] array = new int[6];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }


            int sum = 0;
            for (int i = 1; i < array.Length; i+=2)
            { 
                sum += array[i];

            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
