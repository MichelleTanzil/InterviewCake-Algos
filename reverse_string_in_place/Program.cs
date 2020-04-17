using System;

namespace reverse_string_in_place
{
    class Program
    {
        public static void Reverse(char[] arrayOfChars)
        {
            int leftIndex = 0;
            int rightIndex = arrayOfChars.Length - 1;

            while (leftIndex < rightIndex)
            {
                // Swap characters
                char temp = arrayOfChars[leftIndex];
                arrayOfChars[leftIndex] = arrayOfChars[rightIndex];
                arrayOfChars[rightIndex] = temp;

                // Move towards middle
                leftIndex++;
                rightIndex--;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
