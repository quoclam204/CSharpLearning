namespace Exercise3_ListArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Chuyển mảng thành thành list
            //List<int> listNumbser = numbers.ToList();
            List<int> listNumbers = new List<int>(numbers);

            // thêm phần tử 6, 7 vào danh sách
            listNumbers.AddRange(new int[] { 6, 7 });
            foreach (var item in listNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Tạo array mới có kích thước bằng số phần tử của list
            int[] newNumbers = new int[listNumbers.Count];

            // copy list sang array
            listNumbers.CopyTo(newNumbers);

            foreach (var item in newNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
