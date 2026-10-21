using QueueBuiltIn;
using System.Text;

namespace CircularQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyQueue myQueue = new MyQueue(5);

            myQueue.EnQueue(1);
            myQueue.EnQueue(2);
            myQueue.EnQueue(3);


            Console.WriteLine("Mảng ban đầu là: ");
            myQueue.Print();
        }
    }
}
