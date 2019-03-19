using System;


namespace ConsoleApp1
{
    class Program
    {
        bool number;

        public static void Main(string[] args)
        { }

            public void GetArray ()
            {
            do
            {
                Console.WriteLine("Please enter 5 numbers");
                int[] array = new int[5];

                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = GetUserInput();
                }

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] *= 10);
                }
            }
            while (false);
            Console.WriteLine("");
            }
        

        public int GetUserInput()
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
