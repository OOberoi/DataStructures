using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    interface IFile
    {
        void ReadFile();
        void WriteFile(string fileName);
    }

    public class FileInfo : IFile
    {
        void IFile.ReadFile()
        {
            throw new NotImplementedException();
        }

        void IFile.WriteFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
