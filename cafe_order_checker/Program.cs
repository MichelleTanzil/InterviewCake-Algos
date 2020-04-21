using System;

namespace cafe_order_checker
{
    class Program
    {
        public static bool
        IsFirstComeFirstServed(
            int[] takeOutOrders,
            int[] dineInOrders,
            int[] servedOrders
        )
        {
            //My Solution
            if (
                servedOrders.Length !=
                (takeOutOrders.Length + dineInOrders.Length)
            )
            {
                return false;
            }
            else
            {
                int
                    takeOutIndex = 0,
                    dineInIndex = 0,
                    servedOrderIndex = 0;
                while (servedOrderIndex < servedOrders.Length)
                {
                    // Console.WriteLine("-------------------------------");
                    // Console.WriteLine("servedOrderIndex " + servedOrderIndex);
                    // Console.WriteLine("takeOutIndex " + takeOutIndex);
                    // Console.WriteLine("dineInIndex " + dineInIndex);
                    if (
                        takeOutIndex < takeOutOrders.Length &&
                        servedOrders[servedOrderIndex] ==
                        takeOutOrders[takeOutIndex]
                    )
                        takeOutIndex++;
                    else if (
                        dineInIndex < dineInOrders.Length &&
                        servedOrders[servedOrderIndex] ==
                        dineInOrders[dineInIndex]
                    )
                        dineInIndex++;
                    else
                        return false;

                    servedOrderIndex++;
                }
                if (
                    dineInIndex != dineInOrders.Length ||
                    takeOutIndex != takeOutOrders.Length
                ) return false;
                return true;
            }
        }

        static void Main(string[] args)
        {
            var takeOutOrders = new int[] { 1, 4, 5 };
            var dineInOrders = new int[] { 2, 3, 6 };
            var servedOrders = new int[] { 1, 2, 3, 4, 5, 6 };
            Console
                .WriteLine(IsFirstComeFirstServed(takeOutOrders,
                dineInOrders,
                servedOrders));
        }
    }
}
