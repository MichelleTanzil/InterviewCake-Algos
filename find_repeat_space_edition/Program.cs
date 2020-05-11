using System;
using System.Linq;

namespace find_repeat_space_edition
{
    class Program
    {public static int FindRepeat(int[] numbers)
{
    int floor = 1;
    int ceiling = numbers.Length - 1;

    while (floor < ceiling)
    {
        // Divide our range 1..n into an upper range and lower range
        // (such that they don't overlap)
        // Lower range is floor..midpoint
        // Upper range is midpoint+1..ceiling
        int midpoint = floor + (ceiling - floor) / 2;
        int lowerRangeFloor = floor;
        int lowerRangeCeiling = midpoint;
        int upperRangeFloor = midpoint + 1;
        int upperRangeCeiling = ceiling;
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("floor before: " + floor);
        Console.WriteLine("ceiling before: " + ceiling);
        Console.WriteLine("midpoint: " + midpoint);
        Console.WriteLine("lowerRangeFloor: " + lowerRangeFloor);
        Console.WriteLine("lowerRangeCeiling: " + lowerRangeCeiling);
        Console.WriteLine("upperRangeFloor: " + upperRangeFloor);
        Console.WriteLine("upperRangeCeiling: " + upperRangeCeiling);

        // Count number of items in lower range
        int itemsInLowerRange = numbers.Count(item => item >= lowerRangeFloor && item <= lowerRangeCeiling);
        Console.WriteLine("items in lower range: " + itemsInLowerRange);

        int distinctPossibleIntegersInLowerRange = lowerRangeCeiling - lowerRangeFloor + 1;

        if (itemsInLowerRange > distinctPossibleIntegersInLowerRange)
        {
            // There must be a duplicate in the lower range
            // so use the same approach iteratively on that range
            floor = lowerRangeFloor;
            ceiling = lowerRangeCeiling;
            Console.WriteLine("floor after greater: " + floor);
            Console.WriteLine("ceiling after greater: " + ceiling);
        }
        else
        {
            // There must be a duplicate in the upper range
            // so use the same approach iteratively on that range
            floor = upperRangeFloor;
            ceiling = upperRangeCeiling;
            Console.WriteLine("floor after smaller: " + floor);
            Console.WriteLine("ceiling after smaller: " + ceiling);
        }
    }

    // Floor and ceiling have converged
    // We found a number that repeats!
    Console.WriteLine("floor final: " + floor);
    return floor;
}
        static void Main(string[] args)
        {
            // Console.WriteLine(FindRepeat(new int[] { 1, 1 }));
            Console.WriteLine(FindRepeat(new int[] { 1, 2, 3, 2 }));
            // Console.WriteLine(FindRepeat(new int[] { 1, 2, 5, 5, 5, 5 }));
            // Console.WriteLine(FindRepeat(new int[] { 4, 1, 4, 8, 3, 2, 7, 6, 5 }));
        }
    }
}
