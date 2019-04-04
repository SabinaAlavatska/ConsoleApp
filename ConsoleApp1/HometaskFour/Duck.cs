using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskFour
{
    class Duck : Animal
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        public Duck (double weight, int age) : base(weight, age) { }

    }
}
