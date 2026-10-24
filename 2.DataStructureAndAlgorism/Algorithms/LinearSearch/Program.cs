namespace LinearSearch
{
    internal class Program
    {
        static int LinearSearch(int[] A, int x)
        {
            int i = 0;
            int n = A.Length;

            while (i < n)
            {
                if (A[i] == x)
                {   
                    Console.WriteLine($"Phần tử {x} được tìm thấy tại chỉ mục {i}");
                    return i;
                }

                i++;
            }

            Console.WriteLine("Phần tử không được tìm thấy!");

            return -1; // trả về -1 nghĩa là không tìm thấy
        }

        // int? nghĩa là cho phép trả về giá trị null
        // T là kiểu dữ liệu bất kỳ: int, string...
        static int? LinearSearch2<T>(T[] A, T x)
        {
            int i = 0;
            int n = A.Length;

            while (i < n)
            {
                // Kiểm tra phần tử hiện tại có bằng với giá trị cần tìm không
                if (EqualityComparer<T>.Default.Equals(A[i], x))
                {
                    Console.WriteLine($"Tìm thấy {x} tại chỉ mục {i}");
                    return i;
                }

                i++;
            }

            Console.WriteLine("Phần tử không được tìm thấy!");

            return -1; // trả về -1 nghĩa là không tìm thấy


        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int[] arrNumbers = { 1, 2, 3, 4, 5 };

            LinearSearch(arrNumbers, 6);

            LinearSearch2(arrNumbers, 5);
        }
    }
}
