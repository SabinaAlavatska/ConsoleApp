using ConsoleApp1.HometaskThree;
using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp1
{
    class GuessNumberGame
    {

        public static Random rnd = new Random();
        int guessableNumber = rnd.Next();

        public void GuessNumber()
        {
            Console.WriteLine("Please enter a number");
            int usersNumber;

            do
            {
                usersNumber = GetUserNumber();
                if (guessableNumber > usersNumber)
                {
                    Console.WriteLine("Youre number is less than guessable. Try a bigger one!");
                }
                else if (guessableNumber < usersNumber)
                {
                    Console.WriteLine("Youre number is more than guessable. Try a smaller one!");
                }
            }
            while (guessableNumber != usersNumber);
            Console.WriteLine("You've guessed the number. You win!");
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

        public static void Main(string [] args)
        {
            HometaskThreeGenerics hometaskThree = new HometaskThreeGenerics();
            hometaskThree.GetInputList();
            hometaskThree.UseExtMethods();
        }
    }
}

