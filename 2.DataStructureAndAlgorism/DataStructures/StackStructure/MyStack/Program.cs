using System.Text;

namespace StackMyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyStack myStack = new MyStack(5);

            Console.WriteLine("Mảng ban đầu là: ");

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            // stack bị tràn vì lúc đầu chỉ có 5 phần tử
            // myStack.Push(6);

            myStack.Print();

            Console.WriteLine("Trả về phần tử đầu: " + myStack.Peek());

            Console.WriteLine("Xóa và trả về phần tử đầu tiên là: " + myStack.Pop());

            Console.WriteLine("Mảng lúc sau là: ");
            myStack.Print();

            Console.WriteLine("Mảng sau khi được đảo ngược là: ");
            myStack.ReverseStack();
            myStack.Print();
        }
    }
}
