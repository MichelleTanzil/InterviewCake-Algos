using System;

namespace product_of_all_other_numbers
{
  class Program
  {
    public static int[] GetProductsOfAllIntsExceptAtIndex(int[] intArray)
    {
      // Make an array with the products
      if (intArray.Length < 2)
        throw new ArgumentException("Getting the product of numbers at other indices requires at least 2 numbers", nameof(intArray));

      int[] productsOfAllIntsExceptAtIndex = new int[intArray.Length];
      int productSoFar = 1;
      for (int i = 0; i < intArray.Length; i++)
      {
        productsOfAllIntsExceptAtIndex[i] = productSoFar;
        productSoFar *= intArray[i];
      }
      productSoFar = 1;
      for (int j = intArray.Length - 1; j >= 0; j--)
      {
        productsOfAllIntsExceptAtIndex[j] *= productSoFar;
        productSoFar *= intArray[j];
      }

      return productsOfAllIntsExceptAtIndex;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { 1, 2, 3 }));
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { 8, 2, 4, 3, 1, 5 }));
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { 6, 2, 0, 3 }));
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { 4, 0, 9, 1, 0 }));
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { -3, 8, 4 }));
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { -7, -1, -4, -2 }));
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { }));
      Console.WriteLine(GetProductsOfAllIntsExceptAtIndex(new int[] { 1 }));
    }
  }
}
