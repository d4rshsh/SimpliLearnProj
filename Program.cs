using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplilearnProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string filepath = @"C:\MPHASIS LEARNING ACADEMY\sourceCode.txt";

          List<string> lines = new List<string>();

           lines =  File.ReadAllLines(filepath).ToList();

            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
