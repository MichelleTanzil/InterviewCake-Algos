﻿using System;

namespace sort_scores
{
    class Program
    {
        public static int[]
        SortScores(int[] unorderedScores, int highestPossibleScore)
        {
            // Array of 0s at indices 0..highestPossibleScore
            int[] scoreCounts = new int[highestPossibleScore + 1];

            // Populate scoreCounts
            foreach (var score in unorderedScores)
            {
                scoreCounts[score]++;
            }

            // Populate the final sorted array
            int[] sortedScores = new int[unorderedScores.Length];
            int currentSortedIndex = 0;

            // For each item in scoreCounts
            for (int score = highestPossibleScore; score >= 0; score--)
            {
                int count = scoreCounts[score];

                // For the number of times the item occurs
                for (int occurrence = 0; occurrence < count; occurrence++)
                {
                    // Add it to the sorted array
                    sortedScores[currentSortedIndex] = score;
                    currentSortedIndex++;
                }
            }

            return sortedScores;
        }

        static void Main(string[] args)
        {
            int[] unsortedScores = new [] { 37, 89, 41, 65, 91, 53 };
            const int HighestPossibleScore = 100;
            Console.WriteLine(SortScores(unsortedScores, HighestPossibleScore));
        }
    }
}
