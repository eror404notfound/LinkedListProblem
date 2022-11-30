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
            Console.WriteLine("1:- Linked List\n" + "2:- Custom Linked Listed\n" +"3:- Linked List U 3\n");
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
            }
            Console.ReadLine();
        }
    }
}