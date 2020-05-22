using System;
using System.Runtime.InteropServices;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Solution.Reverse(-2147483648);

            //int[] arr =new int[] { 0, -1, -2, 2, 1 };


            //int[,] res = new int[arr.Length,2];

            //res= PairwithSpecificDiff.FindPairsWithGivenDifference(arr, 1);
            //for (int i = 0; i <= res.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= res.GetUpperBound(1); j++)
            //    {
            //        Console.Write(res[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //Max Sixe Sqauare
            //int[,] M = new int[6, 5]
            //        {
            //        {0, 1, 1, 0, 1},
            //        {1, 1, 0, 1, 0},
            //        {0, 1, 1, 1, 0},
            //        {1, 1, 1, 1, 0},
            //        {1, 1, 1, 1, 1},
            //        {0, 0, 0, 0, 0}};
            //int[,] M = new int[4, 5]
            //        {
            //        {1, 0, 1, 0, 0},
            //        {1, 0, 1, 1, 1},
            //        {1, 1, 1, 1, 1},
            //        {1, 0, 0, 1, 0}
            //        };
            //char[][] M = new char[4][] {
            //    new char[5]{'1', '0', '1', '0', '0' },
            //   new char[5] { '1', '0', '1', '1', '1' },
            //   new char[5] {'1', '1', '1', '1', '1' },
            //   new char[5] {'1', '0', '0', '1', '0' }
            //    };
            //MaximumSizeSquareMatrix.printMaxSubSquare(M);


            //int[] arr = { 1,1,1};
            //int sum = 2;
            //int n = arr.Length;
            //Console.Write(MaxArraySum.SubarraySum(arr, sum));

            int[][] arr1 = new int[3][]
            {
                new int[3]{1,3,1},
                new int[3]{ 1,5,1},  
                new int[3]{ 4, 2, 1 }
            };

            Console.WriteLine(Solution1.MinPathSum(arr1));

          

        }
    }

    public class Solution
    {
        public static int Reverse(int x)
        {
            //int remainder = 0;
            int revNum = 0;
            while (x != 0)
            {
                revNum = x % 10 + (10 * revNum);
                x = x / 10;
            }

            return revNum;
        }
    }
}
