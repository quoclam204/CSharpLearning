namespace BinarySearch
{
    internal class Program
    {
        static int BinarySearch(int[] arr, int value)
        {
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex <= endIndex)
            {
                // Chia mảng thành hai nửa
                int midIndex = startIndex + (endIndex - startIndex) / 2;

                if (arr[midIndex] == value)
                {
                    return midIndex;
                }    
                // Tìm bên phải
                else if (arr[midIndex] < value)
                {
                    startIndex = midIndex + 1;
                }    
                else
                {
                    endIndex = midIndex - 1; // Tìm bên trái
                }    
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int[] arrNumbers = { 11, 17, 21, 25, 27, 31, 35, 40, 45, 50 };

            Console.WriteLine("Mảng lúc đầu là: ");
                
            foreach (var item in arrNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Phần tử được tìm thấy tại vị trí: " + BinarySearch(arrNumbers, 31));
        }
    }
}
