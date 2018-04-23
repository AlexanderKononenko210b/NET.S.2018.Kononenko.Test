using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution;

namespace Task2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FileGenerator fileGenerator = new RandomCharsFileGenerator();

            fileGenerator.GenerateFiles(3, 20);

            fileGenerator = new RandomBytesFileGenerator();

            fileGenerator.GenerateFiles(3, 20);
        }
    }
}
