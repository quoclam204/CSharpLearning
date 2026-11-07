namespace Exercise2_ListSearchRemove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                10, 20, 30, 40, 20, 50
            };

            Console.WriteLine($"Vi tri so 30 trong danh sach la: {numbers.IndexOf(20)}");

            if (numbers.Contains(100))
            {
                Console.WriteLine("So 100 co ton tai trong danh sach");
            }
            else
                Console.WriteLine("Trong danh sach khong ton tai so 100");

            Console.WriteLine("Mang ban dau là: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Remove(20);
            Console.WriteLine("Mang sau khi xoa so 20 la: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
