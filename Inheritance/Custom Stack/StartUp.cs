using System;
using System.Collections.Generic;

namespace Stack_of_Strings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Stack<string> input = new Stack<string>();
            input.Push("Radi");
            input.Push("Maya");
            input.Push("Paco");
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(input);
            Console.WriteLine(stack.IsEmpty());
            
        }
    }
}
