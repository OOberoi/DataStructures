﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class DynamicNew
    {
        enum AzureCourses
        { 
            AZ900 = 1,
            AZDeveloper = 3 ,
            AZDataScientist = 7,
            AZDevOps = 10,
            AZDatabaseAdmin = 10,
            AZIOT = 11,
            AZDataDeveloper = 12
        }

        private static void EvalDynamicValues()
        {
            dynamic myVal = 100;
            dynamic myStr = "Hello Obi";
            dynamic mySalary = "100000.00";
            dynamic myFlag = true;
            dynamic currDate = DateTime.Now;
            dynamic myFloat = 10.7f;
            dynamic myChar = 's';

            Console.WriteLine($"The type of {myVal} is: {myVal.GetType()}");
            Console.WriteLine($"The type of {myStr} is: {myStr.GetType()}");
            Console.WriteLine($"The type of {mySalary} is: {mySalary.GetType()}");
            Console.WriteLine($"The type of {myFlag} is: {myFlag.GetType()}");
            Console.WriteLine($"The type of {currDate} is: {currDate.GetType()}");
            Console.WriteLine($"The type of {myFloat} is: {myFloat.GetType()}");
            Console.WriteLine($"The type of {myChar} is: {myChar.GetType()}");
        }

        private static void DynamicConversions()
        {
            dynamic myval = 100;
            int i = myval;
            dynamic myStr = "Obi Oberoi";
            string myName = myStr;
            Console.WriteLine($"The value is: {i} + {myStr}");
            Console.ReadLine();
        }

    }
}
