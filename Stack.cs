using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data_Structure
{
    internal class Stack
    {
        static void Main1()
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                stack.Push(i); // O(1) 집어넣기
            }

            Console.WriteLine(stack.Peek()); // O(1) 다음으로 나올 

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); // O(1) 꺼내기
            }
        }
    }
}
