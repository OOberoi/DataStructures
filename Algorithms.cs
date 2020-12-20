using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Arrays
{
    public class Algorithms
    {
        public Algorithms()
        {

        }
        public static bool ContainsDuplicates(params int[] x)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (int i in x)
            {
                if (dictionary.ContainsKey(i))
                {
                    return true;
                }
                else
                {
                    dictionary.Add(i, 1);
                }
            }
            return false;
        }

        public static void QuestionOne()
        {
        }

        public static String FilterBrackets(String str)
        {
            int len = str.Length;
            char[] arr = str.ToCharArray();
            String filter = "";
            for (int i = 0; i < len; i++)
            {
                if ((arr[i] == '(') || (arr[i] == ')') || (arr[i] == '[') || (arr[i] == ']') || (arr[i] == '{') || (arr[i] == '}'))
                {
                    filter += arr[i];
                }
            }
            return filter;
        }

        /// <summary>
        /// filter out any erroneous characters from the input string which are essentially space characters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static String FilterErroneousChars(String input)
        {
            int len = input.Length;
            char[] arr = input.ToCharArray();
            String filter = "";
            for (int i = 0; i < len; i++)
            {
                if (arr[i].Equals('(') || arr[i].Equals(')') || arr[i].Equals('[') || arr[i].Equals(']') || arr[i].Equals('{') || arr[i].Equals('}'))
                {
                    filter += arr[i];
                }
            }
            return filter;
        }


        private delegate List<int> myList(int[] arr);

        public static bool QuestionTwo(int[] arr, int target, int num)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int x = 0; x < arr.Length; x++)
                    {
                        if ((i != j) && (j != x))
                        {
                            //verify if the number is present as part of the additional constraint!
                            int cnt = NumberOfOccurances(arr, num);
                            if (cnt > 0)
                            {
                                //checking the required number i.e. 7 is present as output
                                if ((arr[i] == num) || (arr[j] == num) || (arr[x] == num))
                                {
                                    sum = arr[i] + arr[j] + arr[x];
                                }

                                if (sum == target)
                                {
                                    Console.WriteLine("The numbers are: {0},{1},{2}", arr[i], arr[j], arr[x]);
                                    Console.ReadKey();
                                    return true;
                                }
                            }
                            else
                            {
                                sum = arr[i] + arr[j];
                                if (sum == target)
                                {
                                    Console.WriteLine("The numbers are: {0},{1}", arr[i], arr[j]);
                                    Console.ReadKey();
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static int NumberOfOccurances(int[] arr, int isNumPresent)
        {
            int cnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //check to see if the 'isNumPresent' is present; well, in this case the #7
                if (arr[i] == isNumPresent)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public static void QuestionTwo()
        {
            int target = 14;
            int sum = 0;
            int[] arr = { 4, 3, 21, 6, 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int x = 0; x < arr.Length; x++)
                    {
                        if ((i != j) && (j != x))
                        {
                            sum = arr[i] + arr[j] + arr[x];
                            if (sum == target)
                            {
                                Console.WriteLine("Nailed it!!!");
                                Console.WriteLine("The numbers are: {0},{1},{2}", arr[i], arr[j], arr[x]);
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        /// <summary>
        /// this will get the alternate number(s) in the array and add it to the list objects
        /// to print alternate numbers, change i++ to i+=
        /// </summary>
        public static void QuestionsThree()
        {
            int[] arr = { 7, 2, 1, 3 };

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> listFinal = new List<int>();

            for (int x = 0; x < arr.Length; x += 2)
            {
                list1.Add(arr[x]);
            }

            //this block of code will add those elements to the list that have an index that is even
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    list2.Add(arr[i]);
                }
            }

            int totCnt = (list1.Count + list2.Count) / 2;

            for (int c = 0; c < totCnt; c++)
            {
                listFinal.Add(list1[c]);
                listFinal.Add(list2[c]);
            }

            Console.WriteLine(listFinal.ToList());
            Console.ReadKey();
        }

        internal static void FinalList(Func<int[], List<int>> firstHalfList, Func<int[], List<int>> secondHalfList)
        {
            throw new NotImplementedException();
        }

        // get every alternate item
        public static List<int> FirstHalfList(int[] array)
        {
            List<int> list = new List<int>();

            for (int x = 0; x < array.Length; x += 2)
            {
                list.Add(array[x]);
            }
            return list;
        }

        public static List<int> SecondHalfList(int[] array)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    list.Add(array[i]);
                }
            }
            return list;
        }

        public static List<int> FinalList(List<int> list1, List<int> list2)
        {
            List<int> finalList = new List<int>();

            int totCnt = (list1.Count + list2.Count) / 2;

            for (int c = 0; c < totCnt; c++)
            {
                finalList.Add(list1[c]);
                finalList.Add(list2[c]);
            }
            return finalList;
        }

        public static void QuestionsThreeOriginal()
        {
            int[] arr = { 7, 2, 1, 3 };

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> listFinal = new List<int>();

            for (int x = 0; x < arr.Length; x += 2)
            {
                list1.Add(arr[x]);
            }

            //this block of code will add those elements to the list that have an index that is even
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    list2.Add(arr[i]);
                }
            }

            int totCnt = (list1.Count + list1.Count) / 2;

            for (int c = 0; c < totCnt; c++)
            {
                listFinal.Add(list1[c]);
                listFinal.Add(list2[c]);
            }

            Console.WriteLine(listFinal.ToList());
            Console.ReadKey();
        }

        public static void Factorial()
        {
            int i, number, fact;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            fact = number;

            for (i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }
            Console.WriteLine("\nFactorial of given number is: " + fact);
            Console.ReadLine();
        }

        public static void TryIt()
        {
            var x = 1;
            for (int i = 0; i < 3; i++)
            {
                x += 5 * i;
                Console.WriteLine(x);
            }
            Console.ReadLine();

        }

        public static void GetTemperatureCloseToZero()
        {
            double temp = 50.0; //some arbitrary value
            double diff;
            int target = 0;

            double[] arr = { 7, 7.9, 10.5, -4, 3, -6, -2, 1, -15, 11.3, 9, -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                diff = Math.Abs(Convert.ToDouble(arr[i])) - Convert.ToDouble(target);
                if (diff <= temp)
                {
                    temp = diff;
                }
            }
            Console.WriteLine("The closest value to 0 is: {0}", temp);
            Console.ReadLine();
        }

        public static void GetTempCloseToZeroSort()
        {
            double[] arr = { 7, 7.9, 10.5, -4, 3, -6, -2, 1, -15, 11.3, 9, -1 };
            List<double> list = new List<double>();

            foreach (var item in arr)
            {
                list.Add(Math.Abs(item));
            }
            list.Sort();

            Console.WriteLine("The closest value to 0 is: {0}", list[0]);
            Console.ReadLine();
        }

        public static void TEstMe()
        {
            var sample = new List<String>();
            sample.InsertRange(collection: new List<String>(), index: 0);
            sample.InsertRange(index: 0, collection: new List<string>());

        }
        //A palindrome is a word that reads the same backward or forward.
        public static bool IsPalindrome(string word)
        {
            string original = word.ToLower();
            string result = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += original[i];
            }
            if (original == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Exists(int[] ints, int k)
        {
            for (int i = 0; i < ints.Length; i++)

            {
                if (ints[i] == k)
                {
                    return true;
                }
            }
            return false;
        }

        public static string ReverseString(string s)
        {
            string result = string.Empty;
            string[] temp = s.Split(' ');
            Array.Reverse(temp);

            for (int i = 0; i <= temp.Length - 1; i++)
            {
                result += temp[i] + ' ';
                //Console.WriteLine(temp[i] + "" + ' ');
            }
            return result;
        }

    }
    public abstract class TextInput
    {
        public abstract void Add(char c);
        public abstract string GetValue();
    }

    public class NumericInput : TextInput
    {
        private string finalResult;
        public override void Add(char c)
        {
            if (Char.IsDigit(c))
            {
                finalResult += Convert.ToString(c);
            }
            GetValue();
        }

        public override string GetValue()
        {
            return finalResult;
        }
    }

    public class MathUtils
    {
        public static double Average(int a, int b)
        {
            return (a + b) / 2;
        }
    }

    public class XmlTest
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            XDocument xmlDoc = XDocument.Parse(xml);

            var val = xmlDoc.Descendants("folder").ToList();
            var result = val.Where(p => p.FirstAttribute.Value.StartsWith(startingLetter.ToString())).Select(p => p.FirstAttribute.Value).ToList();
            return result;
        }

    }

    public class McKeenson
    {
        public static void PrintNumAndAnimals()
        {
            for (int i = 1; i < 100; i++)
            {
                // a number 15 will print Elephant
                if (i == 15)
                {
                    Console.WriteLine("Elephant");
                }
                // multiples of 3 will print Cat
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Cat");
                }
                // multiples of 5 will print Dog
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Dog");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
            Console.ReadLine();
        }
    }

    public class TomCat
    {
        //Find the maximum number of even numbers
        public static void MaxNoOfEvenNumbers()
        {
            List<int> myList = new List<int>();
            int cnt = 0;

            int[] arr = { 9, 8, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    myList.Add(cnt);
                    cnt++;
                }
            }
            Console.WriteLine($"Total number of even numbers are: {cnt}");
            Console.ReadLine();
        }
    }
}
