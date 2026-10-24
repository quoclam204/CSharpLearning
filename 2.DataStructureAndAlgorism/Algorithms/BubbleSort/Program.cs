namespace BubbleSort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length -1 - i   ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }    
                }
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
            BubbleSort(arrNumbers);

            foreach (var item in arrNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
