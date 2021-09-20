using System;

namespace find_smallest_number
{
    // https://medium.com/dexters-lab/eli5-find-the-smallest-positive-integer-value-that-cannot-be-represented-as-sum-of-any-subset-of-f8ea2488184b
    // https://www.geeksforgeeks.org/find-smallest-value-represented-sum-subset-given-array/
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 1, 3, 5, 8, 21 };
            Console.WriteLine(FindMinMissing(arr));
        }

        static int FindMinMissing(int[] arr)
        {
            int max = 0;

            if (arr.Length == 1 || arr[0] != 1) return max + 1;

            max = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max + 1) break;
                max += arr[i];
            }

            return max + 1;
        }
    }
}
