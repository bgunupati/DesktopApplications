using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var monitor = new Monitor(@"C:\Users\bgunu\Desktop\SampleFolder");
            Console.ReadLine();
        }
    }
}
