using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMyStack
{
    public class MyStack
    {
        private int[] items;
        private int top; // lưu vị trí của phần tử trên cùng

        public MyStack(int capacity)
        {
            // chưa có phần tử
            top = -1;

            // tạo mảng số nguyên để lưu các phần tử của stack
            items = new int[capacity];
        }

        // Thêm phần tử
        public void Push(int value)
        {
            try
            {
                if (top == items.Length - 1)
                {
                    throw new InvalidOperationException();
                }

                top++;

                items[top] = value;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The stack is full");
            }  
        }

        // Xóa và trả về phần tử trên cùng
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }

            int value = items[top];

            // cập nhật vị trí đỉnh Stack sau khi xóa.
            top--;

            return value;
        }

        // Trả về phần tử trên cùng
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }

            int value = items[top];

            return value;
        }

        // Kiểm tra nếu stack rỗng thì trả về true
        public bool IsEmpty()
        {
            //if (top == -1)
            //    return true;
            //return false;
            return top == -1; // return true
        }

        // in ra LIFO
        public void Print()         
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }

        // Đảo ngược stack
        public void reverseStack(ref Stack<int> st)
        {
            // tạo stack phụ
            Stack<int> aux = new Stack<int>();

            while (st.Count > 0)
            {
                aux.Push(st.Peek());
                st.Pop();
            }
            st = aux;
        }

        public void ReverseStack()
        {
            int left = 0;
            int right = top;

            while (left < right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;

                left++;
                right--;
            }    
        }
    }
}
