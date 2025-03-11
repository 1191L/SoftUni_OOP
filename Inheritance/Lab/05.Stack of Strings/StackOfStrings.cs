using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    class StackOfStrings:Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count() == 0)
                return true;
            else
                return false;
        }
        public void AddRange(Stack<string> StackToAdd)
        {
            int count = StackToAdd.Count();
            for (int i = 0; i < count; i++)
            {
                this.Push(StackToAdd.Pop());
            }
        }
    }
}
