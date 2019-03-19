using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int userInput = GetUserNumber();
        static void Main(string[] args)
        {
            do
            {
            Console.WriteLine("Please enter 5 numbers");
            int[] array = new int[5];

           for (int i = 0; i < array.Length; i++)
            {
                array[i] = userInput;
            }
            
           for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] *= 10);
            }
            while (false)
                Console.WriteLine("Invalid input, try again!");
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
