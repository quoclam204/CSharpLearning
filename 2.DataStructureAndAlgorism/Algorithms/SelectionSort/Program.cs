namespace SelectionSort
{
    internal class Program
    {
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Chọn giá trị nhỏ nhất ở vị trí 0
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j; // Tìm phần tử nhỏ nhất trong mảng
                    }    
                }

                // Sắp xếp mảng đó theo thứ tự tăng dần
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
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
            SelectionSort(arrNumbers);

            foreach (var item in arrNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
