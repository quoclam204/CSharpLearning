namespace Exercise1_ListBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumbers = new List<int>(5);

            for (int i = 1; i <= 5; i++)
            {
                listNumbers.Add(i);
            }

            //listNumbers.Add(1);
            //listNumbers.Add(2);
            //listNumbers.Add(3);
            //listNumbers.Add(4);
            //listNumbers.Add(5);

            foreach (int numbers in listNumbers)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();

            Console.WriteLine("So luong phan tu la: " + listNumbers.Count);

            if (listNumbers.Contains(10))
            {
                Console.WriteLine("So 10 co ton tai trong danh sach");
            }
            else
                Console.WriteLine("So 10 khong ton tai trong danh sach");
        }
    }
}
