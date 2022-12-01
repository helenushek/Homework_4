using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        //Отсортировать массив по возрастанию (пузырьковый метод)
        static void Main(string[] args)
        {

            int[] array = new int[9];
            Random random = new Random();
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        temp = array[k];
                        array[k] = array[i];
                        array[i] = temp;

                    }

                }
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
            


