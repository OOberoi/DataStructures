﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class DynamicNew
    {
        private static void EvalDynamicValues()
        {
            dynamic myVal = 100;
            dynamic myStr = "Hello Obi";
            dynamic mySalary = "100000.00";
            dynamic myFlag = true;

            Console.WriteLine($"The type of {myVal} is: {myVal.GetType()}");
            Console.WriteLine($"The type of {myStr} is: {myStr.GetType()}");
            Console.WriteLine($"The type of {mySalary} is: {mySalary.GetType()}");
            Console.WriteLine($"The type of {myFlag} is: {myFlag.GetType()}");
        }

    }
}
