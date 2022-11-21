using System;
namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Linked List Operations");
                Console.WriteLine(" 1. Add LinkedList\n 2. Add data in reverse order");
                Console.WriteLine("Enter above mention option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        LinkedList list = new LinkedList();
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;

                    case 2:
                        LinkedList linkedList = new LinkedList();
                        linkedList.AddInReverseOrder(70);
                        linkedList.AddInReverseOrder(30);
                        linkedList.AddInReverseOrder(56);
                        linkedList.Display();
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }

            }
        }
    }
}
