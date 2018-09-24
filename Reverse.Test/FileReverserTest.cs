using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverserFile;

namespace Reverse.Test
{
    [TestClass]
    public class FileReverserTest
    {
        [TestMethod]
        public void FileTestMethod()
        {
            var path = @"C:\Projects\ReverserFile\ReverserFile\TextFiles\limerick.txt";
            
            var fileMock = new ReverserFileContents();
      
            fileMock.ReverserFile(path);
        }
    }
}
