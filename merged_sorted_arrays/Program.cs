using System;

namespace merged_sorted_arrays
{
    class Program
    {
        public static int[] MergeArrays(int[] myArray, int[] alicesArray)
        {
            // Combine the sorted arrays into one large sorted array
            int[] finalArray = new int[myArray.Length + alicesArray.Length];
            int
                a = 0,
                b = 0,
                i = 0;

            while (i < finalArray.Length)
            {
                bool isMyArrayExhausted = a >= myArray.Length;
                bool isAlicesArrayExhausted = b >= alicesArray.Length;

                if (
                    !isMyArrayExhausted &&
                    (isAlicesArrayExhausted || (myArray[a] < alicesArray[b]))
                )
                {
                    finalArray[i] = myArray[a];
                    a++;
                }
                else
                {
                    // Case: next comes from Alice's array
                    finalArray[i] = alicesArray[b];
                    b++;
                }
                i++;
            }

            return finalArray;
        }

        static void Main(string[] args)
        {
            Console
                .WriteLine(MergeArrays(new int[] { 3, 4, 6, 10, 11, 15 },
                new int[] { 1, 5, 8, 12, 14, 19 }));
        }
    }
}
