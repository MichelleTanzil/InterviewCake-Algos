using System;

namespace reverse_linked_list
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

    public static LinkedListNode Reverse(LinkedListNode headOfList)
    {
        // Reverse the linked list in place
        if(headOfList == null){
            return null;
        }
        else if(headOfList.Next == null){
            return headOfList;
        }
        else{
            LinkedListNode currentNode = headOfList;
            LinkedListNode previousNode = null;
            LinkedListNode nextNode = null;
            while(currentNode != null){
                nextNode = currentNode.Next;
                currentNode.Next = previousNode;

                previousNode = currentNode;
                currentNode = nextNode;
            }
            return previousNode;
        }
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
