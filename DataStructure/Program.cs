using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> ll = new LinkedList<int>();
            //ll.AddLast(30);
            //ll.AddLast(20);
            //ll.AddFirst(10);
            CustomLinkedList linkedList= new CustomLinkedList();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            Console.ReadLine();

        }
    }
}
