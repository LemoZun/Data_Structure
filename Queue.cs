using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data_Structure
{
    internal class Queue
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i); // O(1) 데이터 넣기
            }

            Console.WriteLine(queue.Peek()); // O(1) 다음으로 나올 데이터 확인

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue()); //O(1) 데이터 꺼내기
            }
        }
    }
}
