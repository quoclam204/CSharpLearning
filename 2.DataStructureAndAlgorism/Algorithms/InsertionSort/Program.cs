namespace InsertionSort
{
    internal class Program
    {
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i]; // Phần tử muốn chèn
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j]; // Nếu true thì chuyển phần tử lớn hơn sang phải
                    j--;
                }

                arr[j + 1] = key;
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
            InsertionSort(arrNumbers);

            foreach (var item in arrNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
