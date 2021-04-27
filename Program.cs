using System;
using System.Collections.Generic;
using System.Linq;

namespace Edabit
{
    class Program
    {

  
        //public static double[] FindMinMax(double[] values)
        //{
        //    int n = values.Length;
        //    double max = values[0];
        //    for (double i = 1; i < n; i++)
        //    {
        //        double val = (double)values[i];
        //        if ( > max)
        //        {
        //            max = values[i];
        //        }
        //    }
        //}

        public static string MonthName(int num)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            if(num > 0 && num < 13)
            {
                return months[num - 1];
            }
            else
            {
                return "Inavalid number";
            }

        }

        public static double[] FindMinMax(double[] values)
        {
            double max = values.Max();
            double min = values.Min();

            double[] minMax = { min, max };
            return minMax;

        }

        //  2/23/2021
        // Get Absolute sums
        public static int GetAbsSum(int[] arr)
        {
           return arr.Sum(i=>Math.Abs(i));
        }

        public static long CalculateExponent(long number, long exponent)
        {
            //long powerOfResult = number;
            //for(int i = 0; i < exponent - 1 ; i++)
            //{
            //powerOfResult = number * powerOfResult;
            //}
            //return powerOfResult
            //or
 
            return (long) Math.Pow(number, exponent);
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            List<int> resultArray = new List<int>();
            int timesByLength = arr.Length;
            foreach(int x in arr)
            {
                resultArray.Add(x * timesByLength);
            }
            return resultArray.ToArray();
        }

        //Hamming Distance Algorithm
        // - hamming distance measures the min number of substitustions required to change one string into the other, 
        //   the Hmadding distance between the equal length netweem twp string of equal length is the number of postions corresponding symbols are
        //   different. 
        // public static int HammingDistance(string str1, string str2)
        // {
        //     int distance = str1.ToCharArray()
        //                    .Zip(str2.ToCharArray(), (c1, c2) => new(c1, c2))
        //                    .Count(m => m.c1 != m.c2);
        // 
        //     return distance;
        // }

        public static string High(string s)
        {
            var words = s.Split();

            var lengths = new List<int>();
            foreach (string word in words)
            {
                int wordScore = 0;
                foreach (char c in word)
                {
                    wordScore += (int)c - 'a' + 1; // implicit converting char to integer by substracting one from other
                                                   // a - a = 0      b - a = 1 etc
                }
                lengths.Add(wordScore);
            }

            return words[lengths.IndexOf(lengths.Max())];


        }


        //The word i18n is a common abbreviation of internationalization in the developer community, 
        //    used instead of typing the whole word and trying to spell it correctly.Similarly, a11y
        //    is an abbreviation of accessibility.

        //Write a function that takes a string and turns any and all "words" (see below) within that
        //string of length 4 or greater into an abbreviation, following these rules:


        //A "word" is a sequence of alphabetical characters.By this definition, any other character 
        //like a space or hyphen (eg. "elephant-ride") will split up a series of letters into two 
        //words(eg. "elephant" and "ride").
        //The abbreviated version of the word should have the first letter, then the number of removed 
        //characters, then the last letter(eg. "elephant ride" => "e6t r2e").

        public static string Abbreviate(string input)
        {
            List<string> abrList = new List<string>();
            var abbreviateArray = input.Split(' ');
            foreach(string x in abbreviateArray)
            {
                Console.WriteLine(x);
                int lengthOfWord = x.Length;
                 if(lengthOfWord >= 4)
                {
                    int intMid = lengthOfWord - 2;

                    string abrWord = x[0] + intMid.ToString() + x[x.Length - 1];
                   // Console.WriteLine(abrWord);
                    abrList.Add(abrWord);

                }
              
                abrList.Add(x);

            }
            string result = string.Join(' ', abrList);
            Console.WriteLine(result);
            return "";
        }

        static void Main(string[] args)
        {
            Abbreviate("my. dog, isn't feeling very well.");
            
        }
    }
}
