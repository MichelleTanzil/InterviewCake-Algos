using System;

namespace delete_node
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

    public static void DeleteNode(LinkedListNode nodeToDelete)
    {
      // Delete the input node from the linked list
      var nextNode = nodeToDelete.Next;

      if (nextNode != null)
      {
        nodeToDelete.Value = nextNode.Value;
        nodeToDelete.Next = nextNode.Next;
      }
      else
      {
        throw new InvalidOperationException("Can't delete the last node with this technique!");
      }


    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
