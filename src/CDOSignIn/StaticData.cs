using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CDOSignIn
{
    public class StaticData
    {
        static StaticData()
        {
            Names = File.ReadAllLines("Data/names.txt");
        }

        public static IEnumerable<string> Names { get; set; }
    }
}
