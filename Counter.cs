using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Counter
    {
        //notice the privte constructor. A private constructor is a special instance constructor. 
        //It is generally used in classes that contain static members only. 
        //If a class has one or more private constructors and no public constructors, other classes (except nested classes) cannot create instances of this class.
        private Counter()
        {
        }

        public static int currentCount;
        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }

    public class TestCounter
    {
        //static void Main()
        //{
        //    //Counter ctr = new Counter();
        //    Counter.currentCount = 10;
        //    Counter.IncrementCount();
        //    Console.WriteLine("New count: {0}", Counter.currentCount);


        //}
    }

    public class Student
    {
        static Student()
        {
            // initialize static members only.
        }
        // other methods here.
    }
    // Example2
    public class MyStaticClass
    {
        static int count;
        static MyStaticClass()
        {
            count = 0;
            Console.WriteLine("Static class is initialized");
        }
        public static void MyMethod(string name)
        {
            Console.WriteLine("Static class is initialized " + name);
            Console.ReadLine();
        }
    }
    //MyStaticClass.MyMethod("Obi") ; //method call
    //constructor will be called automatically
}
