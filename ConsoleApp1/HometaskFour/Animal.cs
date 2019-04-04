using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskFour
{
    abstract class Animal : IBaseAnimal
    {
        private double weight;
        private int age;

        public int Age
        {
            get => age;
            set => age = value;
        }

        public double Weight {
            get => weight;
            set => weight = value;
        }


        public Animal(double weight, int age)
        {
            this.weight = weight;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine ("I can eat");
        }
    }
}
