using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskFour
{
    class Dog : Animal
    {
        public void Bark ()
        {
            Console.WriteLine("I can bark");
        }

        public Dog(double weight, int age) : base(weight, age) { }

    }
}
