
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class GradeBooks
    {
        public List<float> grades;
        public GradeBooks()
        {
            grades = new List<float>();

        }
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new ();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }

        //public void Test1(int? a = null, params int[] values);
        //public void Test2(int a = 1, int b);
        //public void Test3(ref DateTime dt = DateTime.Now);
        //public void Test4<T>(int a = 1, T b = default(T));
    }

    public class Dog
    {
        public virtual void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Chihuahua : Dog
    {
        public new void Bark()
        {
            Console.WriteLine("Yap!");
        }
    }
}
