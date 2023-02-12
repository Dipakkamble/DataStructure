using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data) 
        {
            Node newNode = new Node(data);//what ever data we are inserting, in the form of node that's why we created node class
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into Linkedlist",newNode.data);
            }
            else 
            {
                Node temp= head;
                while (temp.next!=null) 
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into Linkedlist", newNode.data);
            }

        }
    }
}
