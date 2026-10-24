namespace QuickSort
{
    internal class Program
    {
        /* low: chỉ số đầu.
           high: chỉ số cuối.
           pivot: giá trị được chọn làm chốt */
        
        // Sắp xếp mảng
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            // 2. Gọi Partition để tìm vị trí Pivot
            int pivotIndex = Partition(arr, left, right);

            // 3. Sắp xếp bên trái Pivot
            QuickSort(arr, left, pivotIndex - 1);

            // 4. Sắp xếp bên phải Pivot
            QuickSort(arr, pivotIndex + 1, right);
        }

        // Phân chia mảng
        static int Partition(int[] arr, int left, int right)
        {
            // chọn phần tử cuối cùng làm pivot
            int pivot = arr[right];

            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }    
            }

            // Đưa Pivot về vị trí đúng
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp2;

            return i + 1;

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int[] arrNumbers = { 5, 3, 8, 1, 2 };

            Console.WriteLine("Mảng lúc đầu là: ");

            foreach (var item in arrNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Mảng sau khi được sắp xếp từ nhỏ đến lớn là: ");
            QuickSort(arrNumbers, 0, arrNumbers.Length - 1);

            foreach (var item in arrNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
