using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverserFile
{
    public class ReverserFileContents : IFile
    {
        public void ReverserFile(string pathRead) 
        {
            List<string> lines = new List<string>();

            var pathWrite = @"C:\Projects\ReverserFile\ReverserFile\TextFiles\reversed.txt";

            using (var sr = File.OpenText(pathRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            lines.Reverse();

            //Open the File
            StreamWriter sw = new StreamWriter(pathWrite, false, Encoding.ASCII);

            foreach (var line in lines)
            {
                sw.Write(line + "\n");
            }
            
            //close the file
            sw.Close();
        }
    }
}
