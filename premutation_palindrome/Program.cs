using System;
using System.Collections.Generic;

namespace premutation_palindrome
{
    class Program
    {
      public static bool HasPalindromePermutation(string theString)
    {
        // My Solution
        Dictionary<char, int> hashTable = new Dictionary<char, int>();
        foreach(var character in theString){
          if(!hashTable.ContainsKey(character)){
            hashTable[character] = 0;
          }
          hashTable[character]++;
        }
        bool isMiddle = false;
        foreach (var character in hashTable){
          if(character.Value % 2 != 0 && !isMiddle) isMiddle = true;
          else if(character.Value % 2 != 0 && isMiddle) return false;
        }
        return true;

        // Other Solution
        // // Track characters we've seen an odd number of times
        // var unpairedCharacters = new HashSet<char>();

        // foreach (char c in theString)
        // {
        //     if (unpairedCharacters.Contains(c))
        //     {
        //         unpairedCharacters.Remove(c);
        //     }
        //     else
        //     {
        //         unpairedCharacters.Add(c);
        //     }
        // }

        // // The string has a palindrome permutation if it
        // // has one or zero characters without a pair
        // return unpairedCharacters.Count <= 1;
    }
        static void Main(string[] args)
        {
            Console.WriteLine(HasPalindromePermutation("civic"));
            Console.WriteLine(HasPalindromePermutation("ivicc"));
            Console.WriteLine(HasPalindromePermutation("civil"));
            Console.WriteLine(HasPalindromePermutation("livci"));
        }
    }
}
