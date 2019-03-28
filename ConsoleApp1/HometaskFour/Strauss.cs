using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskFour
{
    class Strauss : Animal, IBaseAnimal
    {
        public void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public Strauss (double weight, int age) : base(weight, age) { }

    }
}
