using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskThree
{
    class HometaskThreeGenerics
    {
        List<int> intList = new List<int>(5);

        public List<int> GetInputList ()
        {
            Console.WriteLine("Please enter 5 numbers");
                for (int i = 0; i < intList.Capacity; i++)
                {
                    intList.Add (GetUserNumber());
            }
            Console.WriteLine("Stop!");
            Console.ReadLine();
            return intList;
        }

        public int GetUserNumber()
        {
            int result = 0;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Wrong input, please enter any number!");
            }
            return result;
        }
        public void UseExtMethods ()
        {
            intList.OutputList();
            intList.SortDescending();
            intList.RemoveAllElementsExceptFirstAndLastOne();
        }
    }
}
