using System;
using System.Collections;

namespace Stack
{

    public class Stack
    {
        private ArrayList list = new();
        private int ElementCount = 0;
        public  void ExecuteStack(object ElementProvided)
        {
            while ((string)ElementProvided != "Q")
            {
                switch (ElementProvided)
                {
                    case "DSP":
                        DisplayAllElements();
                        break;
                    case "POP":
                        Pop();
                        break;
                    case "CLR":
                        Clear();
                        break;
                    default:
                        Push(ElementProvided);
                        break;
                }

                ElementProvided = Console.ReadLine();
            }

            Console.WriteLine("Closing an application.");
        }
        public void Push(object element)
        {
            if (!String.IsNullOrEmpty((string)element)) 
            {
                list.Add(element);
                Console.WriteLine("{0} has been added to the list.", element);
                ElementCount++;
            }
            else
            {
                Console.WriteLine("Cannot add an empty object to stack.");
            }
        }
        
        public void Pop()
        {
            object toPop;

            if(ElementCount > 0)
            {
                toPop = list[ElementCount - 1];
                list.Remove(toPop);
                Console.WriteLine("{0} has been popped from the list.", toPop);
                ElementCount--;
            }
            else
            {
                Console.WriteLine("There are no elements in stack.");
            }
        }

        public void Clear()
        {
            list.Clear();
            Console.WriteLine("Stack has been cleared.");
            ElementCount = 0;
        }
        public void DisplayAllElements()
        {
            if(ElementCount != 0)
                Console.WriteLine("All elements in stack are listed below: ");
            else
                Console.WriteLine("There is nothing in the stack.");

            int index = 1;

            foreach (object element in list)
            {
                Console.WriteLine("{0}. {1}", index, element);
                index++;
            }
        }

    }
}
