using Arrays;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestions
{
    class Program
    {        
        //will start using it more frequently!!!
        //this is pretty cool stuff. Just pulled the files from git on my surface
        static void Main(string[] args)
        //top-level feature can be added by removing static void Main method completely!
        {
            // Tuple example
            var (_, _, _, pop1, _, pop2) = TupleSample.QueryCityDataForYears("New York City", 1960, 2010);
            Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
            Console.ReadLine();


            // Relational pattern matching using >, <, >=, <= in the coming days...
            Console.WriteLine($"The weather is: {GetWeatherSummary(0)}");
            Console.ReadLine();

            //call the Add program to check the inline parameters value as part of the new features in the latest release
            Console.WriteLine(Add(3,4));

            //Record type
            List<Person> list = new List<Person>();
            var p1 = new Person(7,"Obi", "Oberoi", 44, 'M');
            p1.FirstName = "John";
            list.Add(p1);

            //This is a new feature of C# 9.0 where you don't need to repeat an object twice when newing up!
            Person p2 = new(7, "Sunita", "Oberoi", 40, 'F');
            p2.FirstName = "Gucci";
            list.Add(p2);

            Person p3 = new(  27,  "Arya",  "Oberoi", 14, 'M');
            p3.FirstName = "Ari";
            list.Add(p3);

            Person p4 = new(23,"Sia", "Oberoi", 17, 'F');
            list.Add(p4);

            //Don't do this
            Person p5;
            p5 = new(25, "Krishan", "Oberoi", 80, 'M');
            list.Add(p5);

            foreach (var item in list)
            {
                Console.WriteLine($"The Id is: {item.Id}");
                Console.WriteLine($"The First Name is: {item.FirstName}");
                Console.WriteLine($"The Last Name is: {item.LastName}");
                Console.WriteLine($"The First Name is: {item.Age}");
                Console.WriteLine($"The Gender is: {GetGender(item.Gender)}");
                Console.WriteLine("----------------------------------");
            }

            Console.ReadLine();

            string GetGender(char gender)
            {
                return (gender == 'M' ? "Male" : "Female");
            }

            // Relation pattern matching i.e. <, >, <=, >=
            // Logical pattern matching i.e. and, or & not
            static string GetWeatherSummary(float temp)
            {
                string retval = temp switch
                {
                    < 0 => "Well below freezing",
                    0 => "Exactly Freezing",
                    >= 0 and < 20 => "Cool",
                    >= 20 and < 30 => "Pleasant",
                    >= 30 and < 35 => "Warm",
                    >= 35 and < 42  => "Balmy" ,
                    >42 => "Hot",                                        
                    _ => "This better be Mars!!!"
                };
                return retval;
            }


            static double Add (double x, double y)
            {
                return x + y;
            }


            //Asynchronous Operation
            string myStrVal = Asynchronous.GetHttpClient();
            Console.WriteLine(myStrVal);
            Console.ReadLine();
            //Ends here

            //Anonymous Types 
            IList<Students> studentList = new List<Students>()
            {
                new Students() { StudentID = 1, StudentName = "John Oliver", Age = 18 },
                new Students() { StudentID = 2, StudentName = "Steve Bassett",  Age = 21 },
                new Students() { StudentID = 3, StudentName = "Bill Gates",  Age = 23 },
                new Students() { StudentID = 4, StudentName = "Ram Vilas" , Age = 25  },
                new Students() { StudentID = 5, StudentName = "Ron Kramer" , Age = 27 },
                new Students() { StudentID = 6, StudentName = "Obi Oberoi" , Age = 45 },
                new Students() { StudentID = 7, StudentName= "Arya Oberoi", Age = 14},
                new Students() { StudentID = 8, StudentName = "Gerard Webster", Age = 51 }
            };

            var stud = (from s in studentList
                        select s).ToArray();
            //OR
            var stud1 = studentList.Select(s => new { s.StudentID, s.StudentName, s.Age }).ToArray();

            foreach (var item in stud1)
            {
                Console.WriteLine($"Student ID: {item.StudentID}");
                Console.WriteLine($"Student Name: {item.StudentName}");
                Console.WriteLine($"Age: {item.Age}");
            }
            Console.ReadLine();


            var students = studentList.Select(s => new { id = s.StudentID, name = s.StudentName, s.Age });
            Console.WriteLine(students.GetType().ToString());

            foreach (var item in students)
            {
                Console.WriteLine(item.id + "-" + item.name + "-" + item.Age);
            }
            Console.ReadLine();

            //Linq Class
            //to write the stram to a csv file
            var fileName = $"{Guid.NewGuid()}.csv";

            //FindNumber Starts here
            int inputVal = 15;
            bool isTrue = Linq.FindNumber(inputVal);
            Console.WriteLine(isTrue == true ? $"The input value of {inputVal} matches with the number in the list. " + $"The newly generated filename:{fileName}" :
                                                $"The input value of {inputVal} does not match with the number in the list!" + $"The newly generated filename:{fileName}");


            Console.ReadLine();
            // Ends here

            // Starts here 
            var myList = Linq.GetUserNames();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            // Ends here ///

            // Linq Class - GetNumbers()
            var myNumList = Linq.GetNumbers();

            foreach (var item in myNumList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //--------------------New Method-------------------
            string myName = Linq.GetUserName();
            Console.WriteLine($"My name is: {myName}");
            Console.ReadLine();
            //-----------------Ends here-----------------------

            //Reference Type
            Pupil std1 = new Pupil();
            std1.Name = "Obi Oberoi";

            ChangeRefType(std1);
            Console.WriteLine(std1.Name);


            //Hare and Tortoise
            HareAndTortoise();





            //Collections
            Collections.AddGrades();

            //Test1
            int[] arr1 = new int[] { -1, 1, -2, 2, -5, 5 };
            int num = Codility.TestCase1Modified(arr1);
            Console.WriteLine(num);
            Console.ReadLine();


            //Demo Task
            int[] arr = new int[] { 1, 3, 6, 4, 1, 2 };
            int missingNum = Codility.MySolution(arr);
            Console.WriteLine(missingNum);
            Console.ReadLine();

            //Missing Number(s) in the sequence of integers
            Codility.MissingNumbers();


            //Frog Jump
            int retVal = Codility.FrogJump(10, 85, 30);
            Console.WriteLine(retVal);
            Console.ReadLine();

            //Unpaired number
            int[] pairsArr = new int[] { 9, 3, 9, 3, 5, 7, 9 }; //orfff
            int retVal1 = Codility.FindUpaired(pairsArr);
            int retVal2 = Codility.FindUpairedLINQ(pairsArr);
            Console.WriteLine(retVal);
            Console.ReadLine();

            //Stack info
            Collections.GetStackInfo();
            Console.ReadLine();

            //Cyclic Rotation
            int[] a = new int[] { 3, 8, 9, 7, 6 };
            int k = 3;

            int[] array1 = CyclicRotation.GetCyclicRotation(a, k);
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //Get Binary Gap
            int retval = BinaryGap.FindBinaryGap(9);
            Console.WriteLine(retval);
            Console.ReadLine();

            //gryptech********************************
            MathUtil.GetLargestNumber(989);

            Dog d1 = new Dog();
            Chihuahua d2 = new Chihuahua();
            Dog d3 = d2;

            d1.Bark();
            d2.Bark();
            d3.Bark();
            Console.ReadLine();
            //****************************************


            //***********************Math class *****************************
            //double avgVal = MathUtil.Average(2, 1);

            //Console.WriteLine(avgVal.ToString());
            //Console.ReadLine();
            //***********************Ends Here ***************************** 

            //string retVal = Algorithms.ReverseString("How are you Obi!");

            //char[] ValidChars = { 'k', 'a', 'y', 'a', 'k' };
            //char[] InValidChars = { 'h', 'e', 'l', 'l', 'o' };
            //bool IsTrue = MAndMFoods.IsStringValid(ValidChars);
            //Console.WriteLine(IsTrue ? "The string is valid" : "The string is invalid");
            //Console.ReadLine();

            //string[] arrayA = { "How", "are", "you" };
            //string[] arrayB = { "How", "are", "you" };
            //string[] arrayC = { "How", "are", "you", "Obi" };

            //bool IsTrue = MAndMFoods.CompareArrays(arrayA, arrayC);
            //Console.WriteLine(IsTrue);
            //Console.ReadLine();

            //bool IsTrue = MAndMFoods.CheckProjectDedpendency();
            //Console.WriteLine(IsTrue? "The project has No Depedencies" : "The project has depedencies");
            //Console.ReadLine();

            //UseObjectArray();
            //UseArrayList();
            //GetItemsInArrayList();
            //PrintNamesForArya();
            //ListOfObjects();

            //LinkdedList linkList = new LinkdedList();
            //linkList.PrintAllNodes();

            //ReverseString();
            //Intersect();
            //Algorithms.TryIt();

            //Algorithms.Factorial();

            //Stack objS = new Stack();
            //List<string> myList = new List<string>
            //{
            //    "Obi Oberoi",
            //    "Ken Cenerelli",
            //    "Ehsan Eskandari",
            //    "Arlan Nugara",
            //    "Luca Gobi"
            //};

            //objS.Push(myList);
            //Rain objRain = new Rain("It is raining");
            //Console.WriteLine("Message: {0}",objRain.Temp);

            //Rain oRain = new Rain();

            //AskTell();

            //GradeBook book = new GradeBook();
            //book.AddGrades(97);
            //book.AddGrades(89.5f);
            //book.AddGrades(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.ReadLine();

            //Color c = Color.Red;
            //TestPrint.PrintColor(c);

            //A obj = new A();
            //obj.Show();

            //obj = new B();
            //obj.Show();
            //Console.ReadLine();

            //GetArrays();I caII
            //GetNames();
            //GetInput();
            //ReadMyArray();
            //SingleDimensionalArray();

            //**************************************************************
            //Question 1

            //**************************************************************
            //String s = Algorithms.FilterBrackets("(a+{b+c}-[d-e])[][]");
            //String s = Algorithms.FilterBrackets("[ ( ] )");
            //String s = Algorithms.FilterErroneousChars("{ [ () {} ] }");
            //while ((s.Length != 0) && (s.Contains("[]") || s.Contains("()") || s.Contains("{}")))
            //{
            //    s = s.Replace("[]", "");
            //    s = s.Replace("()", "");
            //    s = s.Replace("{}", "");
            //}

            //if (s.Length == 0)
            //{
            //    Console.WriteLine("Well Formed");
            //}
            //else
            //{
            //    Console.WriteLine("Not Well Formed");
            //}

            //******************************************************
            //question 2 part A
            //int[] arr1 = { 4, 3, 21, 6, 7 };
            //int target = 14;
            //bool IsTrue = QuestionTwo(arr1, target);
            //********************************************************

            //******************************************************
            //question 2 part B
            //int[] arr2 = { 1, 2, 3, 4, 5, 6 };
            //int target1 = 11;
            //bool IsTrue1 = Algorithms.QuestionTwo(arr2, target1);
            //*******************************************************

            //**********************************************************************
            //Algorithms.QuestionsThree();
            //List<int> list1 = new List<int>();
            //List<int> list2 = new List<int>();
            //List<int> finalList = new List<int>();

            //int[] arr = { 7, 2, 1, 3 };

            //Thread func1 = new Thread(delegate () { Algorithms.FirstHalfList(arr); }); //todo: Obi to review this
            //Thread func2 = new Thread(delegate () { Algorithms.SecondHalfList(arr); });



            //list1 = Algorithms.FirstHalfList(arr);
            //func1.Start();

            //list2 = Algorithms.SecondHalfList(arr);
            //func2.Start();

            //finalList = Algorithms.FinalList(list1, list2);
            //*****************************************************************************

            //test utility functions
            //int[] arr = { 4, 3, 21, 6, 7 };
            //int[] arr = { 1, 7, 2, 3, 4, 5, 6 };
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //bool isTrue = Algorithms.QuestionTwo(arr, 14, 7);
            //int cnt = Algorithms.NumberOccurances(arr, 7);

            //Constructor obj = new Constructor();
            //int myId = obj.ID;
            //string myName = obj.Name;
            //Console.WriteLine(myId + ", " +  myName);
            //Console.ReadLine();

            //Algorithms.GetTemperatureCloseToZero();
            //Algorithms.GetTempCloseToZeroSort(); //Obi to review this
            //Console.WriteLine(Algorithms.IsPalindrome("Deleveled"));
            //Console.ReadLine();

            //NumericInput input = new NumericInput();
            //input.Add('1');
            //input.Add('a');
            //input.Add('0');
            //Console.WriteLine(input.GetValue());
            //Console.ReadLine();

            //Client clt = new Client();
            //clt.ClientName = "Obi Oberoi";
            //clt.ClientAddress = "1 Microsoft Way, Redmond";
            ////this is to demonstrate string interpolation feature in C3 6.0
            //Console.WriteLine($"{clt.ClientName}, {clt.ClientAddress} is the information!");
            //Console.ReadLine();
            //MathUtils.Average(11, 1);

            //string xml =
            //"<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            //"<folder name=\"c\">" +
            //    "<folder name=\"program files\">" +
            //        "<folder name=\"uninstall information\" />" +
            //    "</folder>" +
            //    "<folder name=\"users\" />" +
            //"</folder>";
            //foreach (string name in XmlTest.FolderNames(xml, 'u'))
            //    Console.WriteLine(name);

            //MyStaticClass.MyMethod("Obi")

            //McKeenson.PrintNumAndAnimals();
            //TomCat.MaxNoOfEvenNumbers();

        }

        public static void ChangeRefType(Pupil std2)
        {
            std2.Name = "Sunita";
        }


        public class OTPP
        {
            public static void QuestionOne()
            {
                int x = 5;
                object o = x;
            }

            public static void SomeMethod(int x)
            {
                x = 6;
                Console.WriteLine(x.ToString());
            }

        }


        public class Solution
        {
            public static void Reuters(String[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                for (int t = 0; t < n; t++)
                {
                    String str = Console.ReadLine();
                    String[] strArr = str.Split();

                    int a = Convert.ToInt32(strArr[0]);
                    int b = Convert.ToInt32(strArr[1]);
                    Console.WriteLine(a + b);
                }
            }
        }



        private static void AskTell()
        {
            Console.WriteLine("What is your name ?:");
            string name = Console.ReadLine();

            Console.WriteLine("How much sleep do you get?:");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep > 8)
            {
                Console.WriteLine(name + ", you are well rested!");
            }
            else
            {
                Console.WriteLine(name + ", you need more sleep!");
            }
            Console.ReadLine();
        }

        public static void GetArrays()
        {
            int[] arr1 = { 1, 5, 15, 20, 30, 37 };
            int[] arr2 = { 2, 5, 13, 30, 32, 37, 42 };
            string[] arr = { "Obi", "Sunita", "Sia", "Arya" }; //not doing anything with it at the moment

            for (int i = 1; i < arr1.Length; i++)
            {
                for (int j = 1; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr1[i])
                    {
                        Console.WriteLine("The common element is: {0}", arr2[j]);
                    }
                }
            }
        }

        public static void ReadMyArray()
        {
            int[] arr = { 100, 200, 300, 400, 500 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Target = 14
        /// </summary>
        /// 

        //Palindrome solution for M


        public static void SingleDimensionalArray()
        {
            // Create a single-dimensional array.
            int[] arr = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Enter array element : ", x);
                arr[x] = Int32.Parse(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void GetNames()
        {
            string[] arrNames = { "Obi", "Sunita", "Sia", "Arya" };
            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.WriteLine(arrNames[i].ToString());
            }
            Console.ReadLine();
        }

        public static void GetInput()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        }


        public static void ReverseString()
        {
            var inputString = "aa bb cc";
            var result = string.Join(" ", inputString.Split(' ').Reverse());
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        private static void Intersect()
        {
            var inputString1 = "aa bb cc";
            var inputString2 = "xxbbzazz";
            var result = string.Join(String.Empty, inputString1.Intersect(inputString2));
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void UseObjectArray()
        {
            //Question: Can you store different types in an array in c#?
            //Ans: Yes, if you can create an object array. Since all types inherit from object type. Therefore, we can add any type
            //to the object array, including complex types like Customer, Employee etc. 
            //You need to override the ToString() method if ou want meaningful output when ToString() method is invoked
            object[] objectArray = new object[3];

            objectArray[0] = 101; //integer
            objectArray[1] = "C#"; //string

            Customer objCust = new Customer()
            {
                ID = 107,
                Name = "Obi Oberoi"
            };

            objectArray[2] = objCust; // Customer - Complex Type


            foreach (object item in objectArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void UseArrayList()
        {
            Customer cust = new Customer
            {
                ID = 100,
                Name = "John Dexter"
            };
            //ArrayList has an add method
            ArrayList arrList = new ArrayList
            {
                102,
                "Practicing coding skills",
                cust
            };

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }


        private static void GetItemsInArrayList()
        {
            ArrayList arrList = new ArrayList
            { 101,
               "Obi Oberoi",
                2009
            };

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }


        private static void PrintNamesForArya()
        {
            string[] arrNames = { "Arya", "Sia", "Mommy", "Papa" };

            foreach (var item in arrNames)
            {
                Console.WriteLine(item.ToString());
            }
            //        *******  OR (use the code below) ******
            //for (int i = 0; i < arrNames.Length; i++)
            //{
            //    Console.WriteLine(arrNames[i].ToString());
            //}
            Console.ReadLine();
        }

        /// <summary>
        /// Q. Is it possible to store a number of lists of different types in a single generic list?
        /// Ans. Yes, by creating a list of list of objects
        /// </summary>
        private static void ListOfObjects()
        {
            List<List<Object>> list = new List<List<Object>>();

            List<Object> list1 = new List<object>
            {
                1001,
                1002,
                1003,
                1004,
                1005
            };

            List<Object> list2 = new List<object>
            {
                "Obi Oberoi",
                "Ken Cenerelli",
                "Ehsan Eskandari",
                "Arlan Nugara",
                "Luca Gobi"
            };

            list.Add(list1);
            list.Add(list2);

            foreach (List<Object> objectList in list)
            {
                foreach (object obj in objectList)
                {
                    Console.WriteLine(obj);
                }
                Console.ReadLine();
            }
        }

        private static int HareAndTortoise()
        {
            int hare = 5;
            int tortoise = 11;
            int j = 0;

            for (j = 0; j < 20; j++)
            {
                if (hare < tortoise)
                    hare *= 2;
                else if (hare == tortoise)
                    break;
                else
                    tortoise += 1;
            }
            return hare + tortoise;
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //override the string method to get a value from the customer object
        public override string ToString()
        {
            return this.Name;
        }
    }

    #region Private Constructor
    /// <summary>
    /// A class with a private constructor cannot be instantiated. It has to be public like so
    /// </summary>
    public class ClassTest1
    {
        private ClassTest1()
        {

        }
    }

    #endregion

    #region Linked List
    public class Node
    {
        public Node next;
        public object data;
    }

    public class LinkdedList
    {
        private Node head;

        internal void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public void PrintMyStuff()
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.PrintAllNodes();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.PrintAllNodes();

            Console.ReadLine();
        }
    }

    public class VStack
    {
        private List<string> _vStack = new List<string>
        {
                "Obi Oberoi",
                "Ken Cenerelli",
                "Ehsan Eskandari",
                "Arlan Nugara",
                "Luca Gobi"
        };
        /// <summary>
        /// Added this to GIT
        /// </summary>
        public VStack()
        {
            _vStack = new List<string>();

        }
        public int Size { get { return (_vStack == null) ? 0 : _vStack.Count; } }
        public void Push(string input)
        {
            _vStack.Insert(0, input);
        }
        public string Pop()
        {
            string result = (_vStack == null || _vStack.Count == 0) ? String.Empty : _vStack[0];
            _vStack.RemoveAt(0);
            return result;
        }
        public bool IsEmpty { get { return (_vStack == null || _vStack.Count == 0) ? true : false; } }
    }
    #endregion


    public class Rain
    {
        public Rain()
        {
            Console.WriteLine("It is raining");
        }
        public Rain(string name)
        {
            Console.WriteLine("Parameterized constructor invoked by {0}", name);
        }
    }

    public class Snow : Rain
    {
        private static readonly string name;

        public Snow() : base(name)
        {
            Console.WriteLine("Zero Arg. Sub class constructor is invoked.");
        }

    }

    public abstract class QuantumLearning
    {
        abstract public int Add(int num1, int num2);
        abstract public int Subtract(int num1, int num2);

    }

    public class Addition : QuantumLearning
    {
        public override int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public override int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public static class TestPrint
    {
        public static void PrintColor(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    Console.WriteLine("Red");
                    break;
                case Color.Green:
                    Console.WriteLine("Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("Blue");
                    break;
                default:
                    Console.WriteLine("Unknown color");
                    break;
            }
        }
    }

    public class A
    {
        public virtual void Show()
        {
            Console.WriteLine("overriding in base class");
        }
    }

    public class B : A
    {
        public override void Show()
        {
            Console.WriteLine("overriding in derived class");
        }
    }

    public class Pupil
    {
        public string Name { get; set; }
    }
}    
