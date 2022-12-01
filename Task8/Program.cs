using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        //Поменять местами правую и левую часть массива
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

            if (array.Length % 2 == 0)
            {

                for (int i = array.Length / 2; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                for (int i = 0; i < array.Length / 2; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                for (int i = array.Length / 2 + 1; i < array.Length; i++)

                {
                    Console.Write(array[i] + " ");
                }

                Console.Write(array[(array.Length - 1) / 2] + " ");

                for (int i = 0; i < array.Length / 2; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}

            
