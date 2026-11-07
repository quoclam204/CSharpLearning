namespace Exercise5_DictionarySearchRemove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                { "Lam", 9 },
                { "Nam", 8 },
                { "An", 7 },
                { "Minh", 10 }
            };

            if (students.ContainsKey("Lam"))
            {
                Console.WriteLine("Co sinh vien Lam trong danh sach!");
            }
            else
                Console.WriteLine("Sinh vien Lam hien chua co trong danh sach");


            if (students.ContainsValue(10))
            {
                Console.WriteLine("Co diem 10 trong danh sach sinh vien!");
            }
            else
                Console.WriteLine("Khong co diem 10 trong danh sach sinh vien!");

            foreach (var item in students)
            {
                if (item.Key == "An")
                {
                    Console.WriteLine($"Diem cua An = {item.Value}");
                }    
            }

            students.Remove("An");
            Console.WriteLine("Danh sach sinh vien sau khi xoa ten An la: ");
            foreach (var item in students)
            {
                Console.Write($"{item.Key} - {item.Value}\n");
            }
            Console.WriteLine();

            Console.WriteLine("In cac Key:");
            foreach (var item in students)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("In cac Value:");
            foreach (var item in students)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
