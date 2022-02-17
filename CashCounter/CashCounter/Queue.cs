﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    internal class Queue
    {
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
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
            Console.WriteLine(node.data);

        }
        public void Display()
        {          
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty!");
                return;

            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                while (head != null)
                {
                    head.next.next = null;
                }
                head.next = head;
            }

        }
    }
}
