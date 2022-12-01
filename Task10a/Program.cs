using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10a
{//Сортировка массива вставками
    internal class Program
    {
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


                for (int i = 1; i < array.Length; i++)
                {
                    int k = array[i];
                    int j = i - 1;

                    while (j >= 0 && array[j] > k)
                    {
                        array[j + 1] = array[j];
                        array[j] = k;
                        j--;
                    }
                }

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write (array[i] + " ");
                }

                Console.ReadLine();
            }
    }
}
