using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            return Sum;
        }
    }

    public class Average
    {
        public static double AverageNums(double[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }


/*
        
        Примерен код !
        
        public static double AverageNums(int[] arr)
        {
            double sum = 0;

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }


                double avgSum = Math.Round(sum / arr.Length, 2);

                return avgSum;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide with 0!", e);
                throw;
            }
        }
*/


    }
}

