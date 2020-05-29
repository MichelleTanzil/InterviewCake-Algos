using System;

namespace kth_to_last_node_in_singly_linked_list
{
    class Program
    {

    public static LinkedListNode KthToLastNode(int k, LinkedListNode head)
    {
        // Return the kth to last node in the linked list
        if (k < 1)
        {
        throw new ArgumentOutOfRangeException(nameof(k),
            $"Impossible to find less than first to last node: {k}");
        }
        LinkedListNode leftNode = head;
        LinkedListNode rightNode = head;

        for(int i = 0; i < k - 1; i++)
        {
            if (rightNode.Next == null)
                throw new ArgumentOutOfRangeException(nameof(k),
                $"k is larger than the length of the linked list: {k}");

            rightNode = rightNode.Next;
        }

        while(rightNode.Next != null)
        {
            leftNode = leftNode.Next;
            rightNode = rightNode.Next;
        }

        return leftNode;
    }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
