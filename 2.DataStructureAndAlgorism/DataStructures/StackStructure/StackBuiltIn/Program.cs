using System.Collections;
using System.Text;

namespace StackBuiltIn
{
    internal class Program
    {
        // Đảo ngược stack
        static void reverseStack(ref Stack<int> st)
        {
            // tạo stack phụ
            Stack<int> aux = new Stack<int>();

            while (st.Count > 0)
            {
                // Lấy phần tử đầu của mảng ban đầu thêm vào stack phụ
                aux.Push(st.Peek());
                st.Pop(); // sau đó lấy phần tử đầu xóa nó đi
            }

            st = aux;
        }

        public static void SortStack(Stack<int> st)
        {
            // ngắn xếp phụ
            Stack<int> temp = new Stack<int>();

            while(st.Count > 0)
            {   
                // Lưu phần tử ở trên cùng của stack ban đầu
                int x = st.Pop();

                while (temp.Count > 0 && temp.Peek() < x)
                {
                    st.Push(temp.Pop());
                }

                temp.Push(x);
            }    

            while (temp.Count > 0)
            {
                st.Push(temp.Pop());
            }    
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Lấy ra phần tử được thêm vào cuối cùng và chỉ xem thôi chứ không xóa
            // Console.WriteLine(myStack.Peek());

            // Lấy ra phần tử được thêm vào cuối cùng và đồng thời xóa phần tử đó
            Console.WriteLine(stack.Pop());

            Console.WriteLine();

            Console.WriteLine("Mảng ban đầu là: ");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            reverseStack(ref stack);

            Console.WriteLine("Mảng sau khi đảo ngược là: ");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Phần tử được sắp xếp từ thấp đến cao là: ");
            SortStack(stack);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
