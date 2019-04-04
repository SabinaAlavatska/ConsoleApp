using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        const int ArrayLenght = 5;
        public int[] FillArray()
        {
            Console.WriteLine("Please enter 5 numbers");
            int[] array = new int[ArrayLenght];

           for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetUserNumber();
                Console.WriteLine(array[i] *= 10);
            }
        }

        public int GetUserNumber()
        {
            int result = 0;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Wrong input");
            }
            return result;
        }
    }
}
