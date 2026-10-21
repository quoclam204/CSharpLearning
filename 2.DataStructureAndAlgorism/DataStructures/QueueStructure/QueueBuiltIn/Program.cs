using System.Collections;
using System.Text;

namespace QueueBuiltIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Queue quenue = new Queue();

            quenue.Enqueue(1);
            quenue.Enqueue(2);
            quenue.Enqueue(3);
            quenue.Enqueue(4);
            quenue.Enqueue(5);

            Console.Write("Các phần tử trong hàng đợi:");

            foreach (var item in quenue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Phần tử đầu tiên trong hàng đợi là: " + quenue.Peek());

            Console.WriteLine("Lấy phần tử đầu tiên trong hàng đợi và xóa nó đi là: " + quenue.Dequeue());

            Console.Write("Các phần tử còn lại trong hàng đợi là:");

            foreach (var item in quenue)
            {
                Console.Write(item + " ");
            }

        }   
    }
}
