using System;

namespace _2._New_Year_Chaos
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };
            //var q = new int[] { 2,5,1,3,4 };
            MinimumBribes(q);
        }

        static void MinimumBribes(int[] q)
        {
            int realLength = q.Length - 1;
            int result = 0;
            for (int i = realLength; i >= 0; i--)
            {
                int expectedValue = i + 1;
                if (q[i] == expectedValue) continue;

                int requiredBribe = 0;

                for (int j = i - 1; j >= i - 2; j--)
                {
                    if (expectedValue == q[j])
                    {
                        result += MovePositions(ref q, i, j);
                        break;
                    }
                    else
                    {
                        requiredBribe++;
                    }
                }

                if (requiredBribe < 2) continue;

                Console.WriteLine("Too chaotic");
                return;
            }

            Console.WriteLine(result);
        }

        private static int MovePositions(ref int[] arr, int targetPosition, int positionToMove)
        {
            int movementsCount = targetPosition - positionToMove;

            for (int i = positionToMove; i < targetPosition; i++)
            {
                int auxValue = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = auxValue;
            }

            return movementsCount;
        }
    }
}
