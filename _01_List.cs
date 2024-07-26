using System.Collections.Generic;
namespace Data_Structure

{
    internal class _01_List
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
                Console.WriteLine($"리스트의 count = {list.Count}, 리스트의 capacity = {list.Capacity}");
            }





            //List<string> list = new List<string>();
            //list.Add("0번 데이터");
            //list.Add("1번 데이터");
            //list.Add("2번 데이터"); // 맨 뒤에 바로 붙여넣어서 속도가 빠름 O(1)
            //list.Add("3번 데이터");
            //list.Add("4번 데이터");
            /////크기를 동적 할당 가능
            //list.Insert(2, "Insert로 추가"); //n번째 자리에 추가하고 나머지 자료들을 뒤로 미룸 O(n)

            //list.Remove("1번 데이터"); // O(n) 지우고 데이터 인덱스를 당겨옴
            //list.Remove("없는 데이터"); // 없는 데이터를 지우려고 하면 false를 반환함 
            //list.RemoveAt(1); // 인덱스를 지정해서 지우기도 가능 O(n)

            //list[0] = "바꾼 0번 데이터"; // 인덱스로 접근 가능, 인덱스를 써서 바로 접근 할 수 있기 때문에 O(n)

            //int index = list.IndexOf("3번 데이터");
            //Console.WriteLine(index);
            //bool contain = list.Contains("3번 데이터");



        }
    }
}
