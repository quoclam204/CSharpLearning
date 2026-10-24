namespace HeapSort
{
    internal class Program
    {
        // Sắp xếp mảng
        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Bước 1: Xây dựng Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Bước 2: Đưa phần tử lớn nhất về cuối mảng
            for (int i = n - 1; i > 0; i--)
            {
                // Đổi chỗ phần tử đầu và cuối
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Điều chỉnh lại Heap
                Heapify(arr, i, 0);
            }
        }

        // Điều chỉnh cây Heap để nút cha lớn hơn hoặc bằng các nút con, theo quy tắc Max Heap.
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;        // Nút cha
            int left = 2 * i + 1;   // Nút con trái
            int right = 2 * i + 2;  // Nút con phải

            // Nếu nút con trái lớn hơn nút cha
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // Nếu nút con phải lớn hơn nút lớn nhất hiện tại
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // Nếu nút cha chưa phải lớn nhất
            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                // Tiếp tục điều chỉnh cây con
                Heapify(arr, n, largest);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1, 2 };

            HeapSort(arr);

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
