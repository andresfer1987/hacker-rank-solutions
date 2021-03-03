using System;

namespace _3._Left_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2, 3, 4, 5 };
            int d = 4;

            int[] result = RotLeft(a, d);
            Console.WriteLine("[{0}]",string.Join(", ", result));
        }

        private static int[] RotLeft(int[] a, int d)
        {
            var result = new int[a.Length];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                var targetPosition = i - d;
                if(targetPosition >= 0)
                {
                    result[targetPosition] = a[i];
                }
                else if (result.Length + targetPosition >= 0)
                {
                    result[result.Length + targetPosition] = a[i];
                }    
            }

            return result;
        }
    }
}
