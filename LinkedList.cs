using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Data_Structure
{
    internal class LinkedList
    {

        static void Main1(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            LinkedListNode<int> node1 = linkedList.AddFirst(1); //첫자리에 삽입
            LinkedListNode<int> node2 = linkedList.AddFirst(2);
            LinkedListNode<int> node3 = linkedList.AddLast(3); // 맨 끝에 삽입
            LinkedListNode<int> node4 = linkedList.AddLast(4);

            //인덱스가 없어 노드를 기준으로
            //node2     node1       node3       node4
            //(2)  <->   (1)   <->  (3)    <->   (4)

            //특정 노드를 기준으로 삽입
            LinkedListNode<int> node5 = linkedList.AddBefore(node1, 5);
            LinkedListNode<int> node6 = linkedList.AddAfter(node1, 6);
            //node2      node5       node1       node6       node3       node4
            //(2)   <->   (5)   <->   (1)   <->   (6)   <->   (3)   <->   (4)

            //삭제
            // linkedList.RemoveAt(2); 인덱스가 없기 때문에 RemoveAt은 없다

            linkedList.Remove(3); //O(n) 탐색 후 지우기
            linkedList.Remove(node6); // O(n) 노드 지우기
            //node2      node5       node1        node4
            //(2)   <->   (5)   <->   (1)   <->    (4)

            linkedList.RemoveFirst(); // O(1)
            linkedList.RemoveLast(); // O(1)
            //   node5       node1       
            //    (5)   <->   (1)     

            // 접근 
            LinkedListNode<int> firstNode = linkedList.First; // O(1)
            LinkedListNode<int> lastNode = linkedList.Last;   // O(1)
            LinkedListNode<int> prevNode = node1.Previous;   //  O(1)   노드를 기준으로 접근 가능
            LinkedListNode<int> nextNode = node1.Next;       // O(1)

            // 탐색
            LinkedListNode<int> findNode = linkedList.Find(1); // O(n) 

            //반복
            foreach (int element in linkedList)
            {
                Console.WriteLine(element);
            }

        }
    }
}
