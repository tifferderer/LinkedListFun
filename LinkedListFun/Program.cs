using System;

namespace LinkedListFun
{
    class Program
    {
        static void Main(string[] args)
        {
            links.DoublyLinkedList example = new links.DoublyLinkedList();

            example.add("a");
            example.add("b");
            example.add("c");
            example.add("d");
            example.add("e");

            Console.WriteLine($"Doubly Linked List: {example.ToString}");

            Console.WriteLine("Lets remove a letter and see if we get a true value back...");
            Console.WriteLine(example.remove("a"));

            Console.WriteLine("Lets remove a nonexistent letter and see if we get a false value back...");
            Console.WriteLine(example.remove("a"));

            Console.WriteLine("Look at the Linked List now...");
            Console.WriteLine(example.ToString);
        }
    }
}
