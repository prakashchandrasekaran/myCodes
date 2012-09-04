using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            LL ll = new LL();
            ll.insertFirst(1);
            ll.insertFirst(2);
            ll.insertFirst(3);
            ll.insertLast(10);
            ll.insertLast(11);
            ll.print();
            Console.Read();
        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node arbitrary;
        public Node(int d)
        {
            this.data = d;
            next = null;
            arbitrary = null;
        }
    }

    class LL
    {
        Node head;

        public LL()
        {
            head = null;
        }

        public void insertLast(int newItem)
        {
            if (head == null)
            {
                head = new Node(newItem);
            }
            else
            {
                // traverse to the last and insert
                Node t = head;
                while (t.next != null)
                {
                    t = t.next;
                }
                t.next = new Node(newItem);
            }
        }

        public void insertFirst(int newItem)
        {
            if (head == null)
            {
                head = new Node(newItem);
            }
            else
            {
                Node t = new Node(newItem);
                t.next = head;
                head = t;
            }
        }

        public void print()
        {
            if (head != null)
            {
                Node t = head;
                while (t != null)
                {
                    Console.WriteLine(t.data + " ");
                    t = t.next;
                }
            }
        }

    }
}
