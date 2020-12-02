using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11ExampleKE
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(100);
            myList.AddFirst(0);
            myList.AddLast(50);
            LinkedListNode<int> midNode = myList.First.Next;
            LinkedListNode<int> second = myList.First.Next.Next;
            myList.AddBefore(midNode, 65);
            myList.AddBefore(second, 165);

            int total = 0;
            //System.Collections.IEnumerator myEnumerator = myList.GetEnumerator();
            //while (myEnumerator.MoveNext() == true)
            //{
            //    total += (int)myEnumerator.Current;
            //}
            //int length = (int)myList.Count();
            //double avg = total / length;
            

            foreach(int x in myList)
            {
                total += x;
            }
            int length = (int)myList.Count();
            double avg = total / length;

            Console.WriteLine(avg);
            Console.ReadLine();
        }
    }
}
