using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace LL4
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        Node head = null;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + ":Inserted SuccessFully");
        }
        internal void insertbetween(int value,int data)
        {
            Node node = head;
            while(node.data!=value)
            {
                node= node.next;
            }
            Node newnode= new Node(data);
            Node temp;
            temp = node.next;
            node.next = newnode;
            newnode.next = temp;

        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Values In LinkedList Are:");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
    internal class LL4
    {
        static void Main(string[] args)
        {
            LinkedList l= new LinkedList();
            l.Add(56);
            l.Add(70);
            l.Display();
            Console.WriteLine("After Adding 30 Value InBetween 56 And 70:");
            l.insertbetween(56,30);
            l.Display();
        }
    }
}
