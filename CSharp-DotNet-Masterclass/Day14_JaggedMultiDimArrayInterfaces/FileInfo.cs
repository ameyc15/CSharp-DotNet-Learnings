using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_JaggedMultiDimArrayInterfaces
{
    public class FileInfo : IFileInfo
    {
        public FileInfo()
        {
            Console.WriteLine("Constructor of FileInfo Class Invoked");
        }

        public void ReadFile()
        {
            Console.WriteLine("File Read Operation Successfully");
        }
        public void WriteFile(string text)
        {
            Console.WriteLine("File : " + text);
        }
    }
}
