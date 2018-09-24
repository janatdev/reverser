using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverserFile
{
    class Program
    {
       static void Main(string[] args)
        {

            Console.Write(@"Reading the limerick.txt File Contents and Reversing them into new file!!");

            DoSomeWork();

            Console.ReadLine();
        }

        public static void DoSomeWork()
        {
            ReverserFileContents file = new ReverserFileContents();

            var pathRead = @"C:\Projects\ReverserFile\ReverserFile\TextFiles\limerick.txt";

            if (pathRead != string.Empty)
            {
                file.ReverserFile(pathRead);
            }
        }
    }
}
