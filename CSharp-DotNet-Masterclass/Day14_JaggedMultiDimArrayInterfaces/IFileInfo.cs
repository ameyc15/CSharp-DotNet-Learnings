using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_JaggedMultiDimArrayInterfaces
{
    public interface IFileInfo
    {
        public void ReadFile();
        public void WriteFile(string text);
    }
}
