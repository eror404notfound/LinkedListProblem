using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListUCs
{
    public class LinkedList
    {
        internal Node head;
        internal void Addlast(int data)
        {
            Node newNode = new Node(data); // creating the new node Passing the data

            if (this.head == null) // if this is null than it will start the new node.
            {
                this.head = newNode;

            }
            else
            {
                Node temp = head;
                while (temp.next != null) // if this note is not equal to null that it will print the data.
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted in to Linked list", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Display of Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write("" + temp.data + " ");
                    temp = temp.next;

                }
            }
        }
    }
}