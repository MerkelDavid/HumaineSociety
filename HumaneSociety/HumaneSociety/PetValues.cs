using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class PetValues
    {
        string type;
        string name;
        string size;
        bool vaccinated;


        public static PetValues FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            PetValues dailyValues = new PetValues();
            dailyValues.type = Convert.ToString(values[0]);
            dailyValues.name = Convert.ToString(values[1]);
            dailyValues.size = Convert.ToString(values[2]);
            dailyValues.vaccinated = Convert.ToBoolean(values[3]);
            return dailyValues;
        }
    }
}
