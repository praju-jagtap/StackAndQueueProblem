namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Push the Element In a Stack\n");
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

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
    }
}