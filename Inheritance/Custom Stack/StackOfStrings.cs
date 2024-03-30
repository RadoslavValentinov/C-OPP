using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack_of_Strings
{
    public class StackOfStrings : Stack
    {
        private Stack<string> stack = new Stack<string>();
        public bool IsEmpty()
        {
            if (stack.Count==0)
            {
                return true;
            }

            return false;
        }

        public Stack<string> AddRange(Stack<string> stacks)
        {
            foreach (var item in stacks)
            {
                this.stack.Push(item);
            }
            return stack;
        }
    }
}
