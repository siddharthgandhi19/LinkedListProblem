using System;
namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Linked List Operations");
                Console.WriteLine(" 1. Add LinkedList\n 2. Add data in reverse order\n 3. Insert data at particular position\n 4. Remove first element in linked list\n 5. Remove last element in linked list   ");
                Console.WriteLine("Enter above mention option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:                       
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;

                    case 2:
                       list.AddInReverseOrder(70);
                       list.AddInReverseOrder(30);
                       list.AddInReverseOrder(56);
                       list.Display();
                        break;
                    case 3:
                        list.Add(56);
                        list.Add(70);
                        list.InsertAtParticularPosition(1, 30);
                        list.Display();
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveFirstNode();
                        list.Display();
                        break;
                    case 5:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveLastNode();
                        list.Display();
                        break;
                    case 6:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }

            }
        }
    }
}
