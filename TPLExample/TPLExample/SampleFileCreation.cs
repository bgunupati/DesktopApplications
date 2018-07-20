using System;
using System.IO;
using System.Linq;

namespace TPLExample
{
    public static class SampleFileCreation
    {
        static string sourceDirctory = "SourceDate";
        static string DestinationDirectory = "DestinationDirectory";
        static string FileName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
        public static void CreateTestFiles(int MaxFileCount)
        {
            string fileData = string.Empty;
            //source directory creation with data.
            if (!Directory.Exists(sourceDirctory))
            {
                Directory.CreateDirectory(sourceDirctory);
            }
            int i = 1;
            do
            {
                string filePath = sourceDirctory + "\\" + FileName + "_" + Convert.ToString(i) + ".txt";
                if (!File.Exists(filePath))
                {
                    if (fileData == string.Empty) { fileData = CreateSampleText(MaxFileCount); }
                    File.AppendAllText(filePath, fileData);
#if DEBUG
                    Console.WriteLine("Created - " + filePath);
#endif
                }
                i++;
            } while (Directory.GetFiles(sourceDirctory).Count() < MaxFileCount);

            //Destination directory creation
            if (!Directory.Exists(DestinationDirectory))
            {
                Directory.CreateDirectory(DestinationDirectory);
            }
        }

        private static string CreateSampleText(int MaxContent)
        {
            string s = string.Empty;
            for (int i = 0; i < MaxContent; i++)
            {
                s = s + Environment.NewLine + FileName + "_" + Convert.ToString(i) + ".txt";
            }
            return s;
        }
    }
}
