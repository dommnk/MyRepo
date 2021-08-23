using System;
using System.Collections;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            object ElementProvided;
            var stack = new Stack();

            Console.WriteLine(@"Type in an object to push on stack
(Q to quit, DSP to display elements in stack,
POP to pop an element, CLR to clear list.)");

            ElementProvided = Console.ReadLine();
            stack.ExecuteStack(ElementProvided);
            
        }
    }
}
