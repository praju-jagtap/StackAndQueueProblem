namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Push the Element In a Stack\n2.Peek Element In A Stack\n");
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

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
    }
}