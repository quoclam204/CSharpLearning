using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueBuiltIn
{
    public class MyQueue
    {
        private int[] arr;

        // Vị trí đầu
        private int front;

        // Số phần tử
        private int size;

        // Sức chứa tối đa 
        private int capacity;

        public MyQueue(int cap)
        {
            capacity = cap;
            arr = new int[capacity];
            front = 0;
            size = 0;
        }

        // Thêm 1 phần tử vào cuối hàng đợi
        public void EnQueue(int x)
        {
            if (size == capacity)
            {
                Console.WriteLine("Queue is full");
                return;
            }

            int rear = (front + size) % capacity;
            arr[rear] = x;
            size++;
        }

        // Xem và xóa phần tử đầu
        public int DeQueue()
        {               
            if (size == 0)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }

            int res = arr[front];
            front = (front + 1) % capacity; // Không xóa phần tử mà di chuyển front qua vị trí tiếp theo( vt 0 sang vt 1)
            size--;
            return res;
        }

        // Trả phần tử ở cuối hàng đợi
        public int GetRear()
        {
            if (size == 0)
                return -1;
            int rear = (front + size - 1) % capacity; // lấy vị trí cuối của hàng đợi
            return arr[rear];
        }

        // Trả phần tử ở đầu hàng đợi
        public int GetFront()
        {
            if (size == 0)
                return -1;
            return arr[front];
        }

        public void Print()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            for (int i = 0; i < size; i++)
            {
                int index = (front + i) % capacity; // Thực hiện cơ chế vòng
                Console.Write(arr[index] + " ");
            }

            Console.WriteLine();
        }
    }
}
