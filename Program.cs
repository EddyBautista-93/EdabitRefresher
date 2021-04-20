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
        public static int HammingDistance(string str1, string str2)
        {
            int distance = str1.ToCharArray()
                           .Zip(str2.ToCharArray(), (c1, c2) => new(c1, c2))
                           .Count(m => m.c1 != m.c2);

            return distance;
        }


        static void Main(string[] args)
        {
            
        }
    }
}
