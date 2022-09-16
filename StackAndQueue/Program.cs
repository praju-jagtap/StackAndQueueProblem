namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Push the Element In a Stack\n2.Peek Element In A Stack\n3.Pop Element In Stack\n4.Insert Element In Queue\n");
                Console.WriteLine("Select Your Choice: ");
                Console.WriteLine("----------------------------------\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("----------------------------------\n");
                        LinkedListStack listStack = new LinkedListStack();
                        listStack.Push(56);
                        listStack.Push(30);
                        listStack.Push(70);
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 2:
                        Console.WriteLine("----------------------------------\n");
                        LinkedListStack list = new LinkedListStack();
                        list.Push(56);
                        list.Push(30);
                        list.Push(40);
                        list.Push(70);
                        list.Peek();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 3:
                        Console.WriteLine("----------------------------------\n");
                        LinkedListStack stack = new LinkedListStack();
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(40);
                        stack.Push(70);
                        stack.Pop();
                        stack.Display();
                        Console.WriteLine("----------------------------------\n");
                        break;
                    case 4:
                        Console.WriteLine("----------------------------------\n");
                        LinkedListQueue listQueue = new LinkedListQueue();
                        listQueue.Enqueue(56);
                        listQueue.Enqueue(30);
                        listQueue.Enqueue(70);
                        Console.WriteLine("----------------------------------\n");
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
    }
}