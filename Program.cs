using System;
using PlayGround.Math;
using PlayGround.Katas;


namespace PlayGround
{

    class Program
    {
        static void Main(string[] args)
        {
            var input1 = new int[3] { 1, 2, 2 };
            var answer1 = SquaredSum.SquareSum(input1);
            Console.WriteLine(answer1);

            var input2 = new int[2] { 1, 2 };
            var answer2 = SquaredSum.SquareSum(input2);
            Console.WriteLine(answer1);

            var input3 = new int[] { 5, 3, 4 };
            var answer3 = SquaredSum.SquareSum(input3);
            Console.WriteLine(answer3);

        }
    }
}
