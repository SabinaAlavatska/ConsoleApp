using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskFour
{
    class Dog : Animal, IBaseAnimal
    {
        public void Bark ()
        {
            Console.WriteLine("I can bark");
        }

        public void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public Dog(double weight, int age) : base(weight, age) { }

    }
}
