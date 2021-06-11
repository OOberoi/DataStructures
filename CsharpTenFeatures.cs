using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class CsharpTenFeatures
    {
        record Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void WritToFile(string filePath)
                => File.WriteAllText(filePath, ToString());
        }

    }
}
