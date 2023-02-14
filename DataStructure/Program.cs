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
            Console.WriteLine("Enter the option below:");
            Console.WriteLine("\n1:create linkedlist using addlast\n2:create linkedlist using addfirst\n3:create linkedlist using append\n5:Delete first element in linkedlist\n6:Delete last element in linkedlist");
            int option = Convert.ToInt32(Console.ReadLine());
            //LinkedList<int> ll = new LinkedList<int>();
            //ll.AddLast(30);
            //ll.AddLast(20);
            //ll.AddFirst(10);
            CustomLinkedList linkedList = new CustomLinkedList();
            switch (option)
            {
                case 1:
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 2:
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                case 3:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    break;
                case 5:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.RemoveFirst();
                    linkedList.Display();
                    break;
                case 6:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.RemoveLast();
                    linkedList.Display();
                    break;
            }
            Console.ReadLine();
        }
    }
}
