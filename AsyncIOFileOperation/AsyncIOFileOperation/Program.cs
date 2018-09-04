using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncIOFileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIOOPerations.ReadAllFiles(@"C:\");
        }
    }

    public static class FileIOOPerations {
        public static void ReadAllFiles(string dir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(dir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine(f);
                    }
                    ReadAllFiles(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
