using System;
using System.Collections.Generic;

namespace inflight_entertainment
{
    class Program
    {
        public static bool
        CanTwoMoviesFillFlight(int[] movieLengths, int flightLength)
        {
            // Determine if two movies add up to the flight length
            HashSet<int> moviesSeen = new HashSet<int>();

            foreach (var firstMovie in movieLengths)
            {
                int secondMovie = flightLength - firstMovie;
                if (moviesSeen.Contains(secondMovie))
                {
                    return true;
                }
                moviesSeen.Add(firstMovie);
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
