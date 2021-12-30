using System;
using Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n<------------- Generic List Example ------------->\n\n");
            Collections.GenericClassExamples.listExample();
            Console.Write("\n\n<------------- Generic Dictionary Example ------------->\n\n");
            Collections.GenericClassExamples.dicitionaryExample();
            Console.Write("\n\n<------------- Non-Generic Stack Example ------------->\n\n");
            Collections.NonGenericExamples.stackExample();
            Console.Write("\n\n<------------- Non-Generic Queue Example ------------->\n\n");
            Collections.NonGenericExamples.queueExample();
            Console.ReadLine();
        }
    }
}
