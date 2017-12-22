using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CSVReader
    {
        PetValues petvalues;
        List<PetValues> values = File.ReadAllLines("C:\Users\Cortana\Documents\Visual Studio 2015\Projects\HumaneSociety(Group)\HumaneSociety\HumaneSociety")
                                           .Select(v => PetValues.FromCsv(v))
                                           .ToList();
    }
}

