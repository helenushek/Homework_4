using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {// Отсортировать массив по убыванию (метод выбора)
        static void Main(string[] args)
        {
            int[] array = new int[9];
            Random random = new Random();
           

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                int max = i;
                for (int j = i +1 ; j < array.Length; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                    }
                }

                int temp = array[max];
                array[max] = array[i];
                array[i] = temp;
                Console.Write (array[i] + " ");
            }

        }
    }
}
