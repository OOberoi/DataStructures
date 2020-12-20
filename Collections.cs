using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public static class Collections
    {
        public static void AddGrades()
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
            Console.ReadLine();
        }


        public static void GetStackInfo()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello Obi");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            foreach (var item in myStack)
            {
                Console.Write(item);
            }
        }
    }
}
