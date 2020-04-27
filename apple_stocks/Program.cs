using System;

namespace apple_stocks
{
    class Program
    {    public static int GetMaxProfit(int[] stockPrices)
    {
        // Calculate the max profit
        if(stockPrices.Length < 2){
            throw new ArgumentException("Getting a profit requires at least 2 prices",
            nameof(stockPrices));
        }

      int minPrice = stockPrices[0];
      int maxProfit = stockPrices[1] - stockPrices[0];
      for (int i = 1; i < stockPrices.Length; i++)
      {
        int currentPrice = stockPrices[i];
        int potentialProfit = currentPrice - minPrice;

        maxProfit = Math.Max(maxProfit, potentialProfit);
        minPrice = Math.Min(minPrice, currentPrice);
      }
      return maxProfit;

    }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
