using System;

namespace find_rotation_point
{
    class Program
    {
    public static int FindRotationPoint(String[] words)
    {
        // Find the rotation point in the array
        string firstWord = words[0];
        int floorIndex = 0;
        int ceilingIndex = words.Length - 1;

        while(floorIndex < ceilingIndex){
          int guessIndex = floorIndex + ((ceilingIndex - floorIndex) / 2);
          if(String.Compare(words[guessIndex], firstWord, StringComparison.Ordinal) >= 0){
            floorIndex = guessIndex;
          }
          else
          {
              ceilingIndex = guessIndex;
          }
        if(floorIndex + 1 == ceilingIndex){
          break;
        }
        }
        return ceilingIndex;
    }
        static void Main(string[] args)
        {
            Console.WriteLine(FindRotationPoint(new string[]{"cape", "cake"}));
            Console.WriteLine(FindRotationPoint(new string[]{"grape", "orange", "plum", "radish",
            "apple"}));
            Console.WriteLine(FindRotationPoint(new string[]{"ptolemaic", "retrograde", "supplant", "undulate", "xenoepist", "asymptote", "babka", "banoffee", "engender", "karpatka", "othellolagkage"}));
        }
    }
}
