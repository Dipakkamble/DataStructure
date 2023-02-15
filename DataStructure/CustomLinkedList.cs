﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
        public void AddFirst(int data) 
        {
            Node newNode = new Node(data);
            newNode.next=head;
            head = newNode;
            Console.WriteLine("{0} node inserted into linkedlist",newNode.data);
        }
        public void Append(int data) 
        {
            AddLast(data);
        }
        public void RemoveFirst() 
        {
            if (head == null)
            {
                Console.WriteLine("It's empty please add nodes");
            }
            else 
            {
                Console.WriteLine("{0} is removed", head.data);
                head = head.next;
            }
        }
        public void RemoveLast() 
        {
            Node temp=head;
            if (temp==null)
                Console.WriteLine("Linked list is empty please add nodes");
            else if (temp.next == null)
            {
                int data = temp.data;
                temp = null;
                //return data
                Console.WriteLine("{0} node is deleted", data);
            }
            else 
            {
                //second node not equal to null
                while (temp.next.next != null) 
                {
                    temp = temp.next;
                }
                int lastDeleteNode=temp.next.data;
                temp.next = null;
                Console.WriteLine("{0} node is deleted",lastDeleteNode);
            }
        }
        public void Search(int data) 
        {
            bool isFound = false;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else 
            {
                while (temp != null) 
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine("{0} node is present", temp.data);
                        isFound = true;
                        break;
                    }
                    temp=temp.next;
                }
                if(!isFound)
                Console.WriteLine("{0} node is not present",data);
            }          
        }
        public void Display() 
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else 
            {
                Console.WriteLine("Displaying nodes");
                Node temp=head;
                while (temp!=null)
                {
                    Console.Write(temp.data + " ");
                    temp= temp.next;
                }
            }

        }
    }
}
