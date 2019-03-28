using ConsoleApp1.HometaskFour;
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
            Dog dog = new Dog(1.5, 2);
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat(1.1, 5);
            cat.Eat();
            cat.Meow();
            Strauss strauss = new Strauss(5.5, 3);
            strauss.Eat();
            Duck duck = new Duck(2.5, 6);
            duck.Eat();
            duck.Fly();
            Console.ReadLine();

        }
    }
}

