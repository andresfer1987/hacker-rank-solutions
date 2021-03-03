using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int [] {-1,-1,0,-9,-2,-2},
                new int [] {-2,-1,-6,-8,-2,-5},
                new int [] {-1,-1,-1,-2,-3,-4},
                new int [] {-1,-9,-2,-4,-4,-5},
                new int [] {-7,-3,-3,-2,-9,-9},
                new int [] {-1,-3,-1,-2,-4,-5}

            };

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }

        private static int hourglassSum(int[][] arr)
        {
            int result = -9999;
            for (int z = 0; z <= 3; z++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    var glassSum = 0;
                    for (int i = 0; i <= 2; i++)
                    {
                        glassSum += arr[z][i + j];
                        glassSum += i == 1 ? arr[z + 1][i + j] : 0;
                        glassSum += arr[z + 2][i + j];
                    }
                    result = glassSum > result ? glassSum : result;
                }
            }
            return result;
        }
    }
}
