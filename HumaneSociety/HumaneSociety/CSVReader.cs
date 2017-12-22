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
        List<DailyValues> values = File.ReadAllLines("C:\Users\Cortana\Documents\Visual Studio 2015\Projects\HumaneSociety(Group)\HumaneSociety\HumaneSociety")
                                           .Skip(1)
                                           .Select(v => DailyValues.FromCsv(v))
                                           .ToList();
    }
}

class DailyValues
{    
    string type;
    string name;
    string size;
    bool vaccinated;
    

    public static DailyValues FromCsv(string csvLine)
    {
        string[] values = csvLine.Split(',');
        DailyValues dailyValues = new DailyValues();
        dailyValues.type = Convert.ToString(values[0]);
        dailyValues.name = Convert.ToString(values[1]);
        dailyValues.size = Convert.ToString(values[2]);
        dailyValues.vaccinated = Convert.ToBoolean(values[3]);
        return dailyValues;
    }
}
}
