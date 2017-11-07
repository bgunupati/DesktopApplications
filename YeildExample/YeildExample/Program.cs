using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeildExample
{
    class Program
    {
        static List<int> intList = new List<int>();


        static void AddValuesInList()
        {
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            intList.Add(6);
        }

        static void Main(string[] args)
        {
            AddValuesInList();
            foreach (int i in WtihYeild())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static IEnumerable<int> WtihYeild()
        {
            foreach (int i in intList)
            {
                if (i > 4) yield return i;
            }
        } 
    }
}
