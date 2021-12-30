using System;
using System.Collections;

namespace Collections
{
    public static class NonGenericExamples
    {

        public static void stackExample()
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push("two");
            myStack.Push(3);
            myStack.Push("four");

            foreach (var item in myStack)
                Console.Write(item + ",");

            Console.WriteLine($"\n\nPeek element of stack is {myStack.Peek()}\n\n");

            Console.Write("Number of elements in Stack: {0}\n\n", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.Write("Number of elements in Stack: {0}\n\n", myStack.Count);
        }

        public static void queueExample()
        {
            Queue callerIds = new Queue();
            callerIds.Enqueue("One");
            callerIds.Enqueue(2);
            callerIds.Enqueue("Three");
            callerIds.Enqueue(4);

            Console.Write("\n\nTotal elements: {0}, And they are as follows...\n\n", callerIds.Count);

            foreach (var id in callerIds)
                Console.Write($"{id}, ");

            Console.Write("\n\nPeek of the queue is...{0}\n\n", callerIds.Peek());

            Console.WriteLine("\nDequeing the elements...");

            while (callerIds.Count > 0)
                Console.WriteLine(callerIds.Dequeue());

            Console.Write("\n\nTotal elements: {0}", callerIds.Count);

            Console.WriteLine();

        }

    }
}