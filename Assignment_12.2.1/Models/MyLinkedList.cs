using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12._2._1.Models
{
    public class MyLinkedList
    {
        public Node Head { get; set; }

        public void AddLast(int data)
        {
            Node newNode = new()
            {
                Data = data
            };

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
