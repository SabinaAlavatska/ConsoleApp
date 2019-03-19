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
            while (guessableNumber != usersNumber)

        }

        public int GetUserNumber()
        {
            int enteredNumber = int.Parse(Console.ReadLine());
            return enteredNumber;
        }
        Console.WriteLine("You've guessed the number. You win!");

    }
}


