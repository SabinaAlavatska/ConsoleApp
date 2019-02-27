using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers");
            int[] array = new int[5];

           for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetNumber();
            }
            
           for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] *= 10);
            }
        }
        public static int GetNumber()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
