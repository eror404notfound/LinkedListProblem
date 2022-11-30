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
            Node newNode = new Node(data);//creating new node and passsing data

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
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
        public void AddAtfirst(int data)
        {
            Node newNode1 = new Node(data);//creating new node and passsing data
            newNode1.next = head;
            head = newNode1;
            Console.WriteLine("{0} is added at first position ", newNode1.data);
        }
    }
}