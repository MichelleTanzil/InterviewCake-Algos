using System;

namespace linked_list_cycle
{
  class Program
  {
    public class LinkedListNode
    {
      public int Value { get; set; }

      public LinkedListNode Next { get; set; }

      public LinkedListNode(int value)
      {
        Value = value;
      }
    }

    public static bool ContainsCycle(LinkedListNode firstNode)
    {
      // Check if the linked list contains a cycle
      if (firstNode == null)
        return false;
      else
      {
        var slowRunner = firstNode;
        var fastRunner = firstNode;
        while (fastRunner != null && fastRunner.Next != null)
        {
          slowRunner = slowRunner.Next;
          fastRunner = fastRunner.Next.Next;
          if (slowRunner == fastRunner)
            return true;
        }
        return false;
      }

    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
