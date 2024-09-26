using PracticeProblems.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Data_Structures
{
    internal class SingleLinkedList
    {
        private Node head;

        public SingleLinkedList()
        {
            head = null;
        }

        //Adding element in rare end
        public void add(int data)
        {
            Node newnode = new Node(data);

            if(head == null)
            {
                head = newnode;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;

                }

                current.Next = newnode;

            }
            
        }

        public void remove(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Linked list empty");
                return;
            }
            Node current = head;


        }

        //display list
        public void display()
        {
            if (head == null) { Console.WriteLine("List is empty"); }
            Node current = head;
            while (current.Next != null)
            {
                Console.Write(current.Data + "->");
            }
            Console.Write("Null");
        }
    }
}
