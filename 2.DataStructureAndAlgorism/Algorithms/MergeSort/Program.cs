namespace MergeSort
{
    internal class Program
    {
        // left: 0
        // right: n - 1
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = left + (right - left) / 2; // chia nửa

            MergeSort(arr, left, mid); // chia nửa bên trái

            MergeSort(arr, mid + 1, right); // chia nửa bên phải

            // trộn 2 nửa lại
            Merge(arr, left, mid, right);
             
        }

        // trộn 2 nửa đã được sắp xếp thành 1 nửa lớn
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1]; // tính sô phần tử trong đoạn mảng đang trộn

            int i = left; // duyệt nửa trái
            int j = mid + 1; // duyệt nửa phải
            int k = 0; // vị trí ghi vào mảng temp

            // So sánh và lấy phần tử nhỏ hơn
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }

                k++;
            }

            // Đưa các phần tử còn dư bên trái vào temp
            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            // Đưa các phần tử còn dư bên phải vào temp
            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            // Chép kết quả đã trộn về mảng ban đầu.
            for (int x = 0; x < temp.Length; x++)
            {
                arr[left + x] = temp[x];
            }

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
            MergeSort(arrNumbers, 0, arrNumbers.Length - 1);

            foreach (var item in arrNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
