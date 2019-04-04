using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HometaskThree
{
    static class Extention
    {
        public static void OutputList(this List<int> list)
        {
            Console.WriteLine("Your list is :");
            foreach (var item in list)
                Console.Write(item + " ");
            Console.ReadLine();
        }

        public static void SortDescending(this List<int> list)

        {
            list.Sort();
            list.Reverse();
            list.OutputList();
        }
        public static void RemoveAllElementsExceptFirstAndLastOne(this List<int> list)
        {
            Console.WriteLine("1st and last elements of your list are :");
            
                do
                {
                    list.Remove(list[1]);
                }
                while (list.Count != 2);

            list.OutputList();

        }
    }
}
