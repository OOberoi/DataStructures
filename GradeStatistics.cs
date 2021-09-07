using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class GradeStatistics
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }        
    }

    public class Car
    {
        public string Name { get; set; }
        public int Doors { get; set; }
        public override string ToString()
        {
            return Name + Doors;
        }
    }
}
