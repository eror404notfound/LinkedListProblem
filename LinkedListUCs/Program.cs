using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUCs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Linked List");
            Console.WriteLine("Enter a program number given below");
            Console.WriteLine("1:- Linked List\n" + "2:- Custom Linked Listed\n" +"3:- Linked List U 3\n" + "4:- Insert Node\n" + "5:- Deletion of Node\n" + "6:- Deletion in Last Node\n" + "7:- Searching nodes\n" + "8:- Searching and Add Nodes\n" + "9:- Search and Delete Node\n");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    LinkedList num = new LinkedList();
                    num.Addlast(56);
                    num.Addlast(30);
                    num.Addlast(70);
                    num.Display();
                    break;

                case 2:
                    LinkedList num1 = new LinkedList();
                    num1.Addlast(70);
                    num1.Addlast(30);
                    num1.Addlast(56);
                    num1.Display();
                    break ;

                case 3:
                    LinkedList num2 = new LinkedList();
                    num2.AddAtfirst(56);
                    num2.Addlast(30);
                    num2.Addlast(70);
                    num2.Display();
                    break;

                 case 4:
                    LinkedList num3 = new LinkedList();
                    num3.Addlast(70);
                    num3.AddAtfirst(56);
                    num3.Display();
                    num3.InsertBetween(56, 30, 70);
                    num3.Display();
                    break;

                case 5:
                    LinkedList num4 = new LinkedList();
                    num4.Addlast(56);
                    num4.Addlast(30);
                    num4.Addlast(70);
                    num4.Display();
                    num4.DeleteFirstNode(56);
                    num4.Display();
                    break;

                case 6:
                    LinkedList num5 = new LinkedList();
                    num5.Addlast(56);
                    num5.Addlast(30);
                    num5.Addlast(70);
                    num5.Display();
                    num5.DeleteLastNode(56);
                    num5.Display();
                    break;

                case 7:
                    LinkedList num6 = new LinkedList();
                    num6.Addlast(56);
                    num6.Addlast(30);
                    num6.Addlast(70);
                    Console.WriteLine("Searching node with data {0} in Linked list", 30);
                    num6.Search(30);
                    break;

                case 8:
                    LinkedList num7 = new LinkedList();
                    num7.Addlast(56);
                    num7.Addlast(30);
                    num7.Addlast(70);
                    num7.SearchNodeAddNode(30, 40);//insert 40 to 30;
                    num7.Display();
                    break;

                case 9:
                    LinkedList num8 = new LinkedList();
                    num8.Addlast(56);
                    num8.Addlast(30);
                    num8.Addlast(40);
                    num8.Addlast(70);
                    Console.WriteLine("Before deletion:");
                    num8.Display();
                    Console.WriteLine("After deletion:");
                    num8.SearchNodeDeleteNode(40);//search and delete 40 ;
                    num8.Display();
                    break;

            }
            Console.ReadLine();
        }
    }
}