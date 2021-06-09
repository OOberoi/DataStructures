using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class TupleSample
    {
        public static (string, double, int, int, int, int) QueryCityDataForYears(string name, double area, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            //area = 0;

            if (name == "Toronto")
            {
                area = 468.48;
                if (year1 is 1960)
                {
                    population1 = 2781984;
                }
                if (year2 is 2010)
                {
                    population2 = 5175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }
    }
}
