using System;
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

        static void Main(string[] args)
        {
           

        }
    }
}
