using System;
using System.Linq;
namespace PlayGround.Katas
{
    public class SquaredSum
    {
        public static int SquareSum(int[] numbers)
        {
            // loop 

            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += (numbers[i] * numbers[i]);
            //}

            //return sum;

            int sum = numbers.Aggregate(0, (total, next) => total += (next * next));
            return sum;
            // reduce

            // recursive 
        }
    }
}
