using System;

namespace in_place_shuffle
{
  class Program
  {
    private static Random _rand = new Random();
    private static int GetRandom(int floor, int ceiling)
    {
      return _rand.Next(floor, ceiling + 1);
    }

    public static void Shuffle(int[] array)
    {
      // Shuffle the input in place

      // If it's 1 or 0 items, just return
      if (array.Length <= 1)
      {
        return;
      }
      for (int i = 0; i < array.Length - 1; i++)
      {
        int randomIndex = GetRandom(i, array.Length - 1);
        if (randomIndex != i)
        {
          int valueAtIndex = array[i];
          array[i] = array[randomIndex];
          array[randomIndex] = valueAtIndex;
        }
      }
    }
    static void Main(string[] args)
    {
      var initial = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      var shuffled = (int[])initial.Clone();
      Shuffle(shuffled);
      Console.WriteLine($"Initial array: [{string.Join(", ", initial)}]");
      Console.WriteLine($"Shuffled array: [{string.Join(", ", shuffled)}]");
    }
  }
}
