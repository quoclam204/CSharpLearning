namespace Exercise6_DictionaryUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                { "Lam", 8 },
                { "Nam", 7 },
                { "An", 9 }
            };

            Console.WriteLine("Danh sach sinh vien ban dau la: ");
            foreach (var item in students)
            {
                Console.Write($"{item.Key} - {item.Value}\n");
            }
            Console.WriteLine();

            students["Lam"] = 10;
            Console.WriteLine("Danh sach sinh vien sau khi cap nhat la: ");
            foreach (var item in students)
            {
                Console.Write($"{item.Key} - {item.Value}\n");
            }
            Console.WriteLine();

            students.Add("Minh", 8);

            if (students.ContainsKey("Minh"))
            {
                Console.WriteLine("Sinh vien Minh da duoc them vao danh sach!");
            }
            else
                Console.WriteLine("Sinh vien Minh da co trong danh sach!");

            Console.WriteLine("Danh sach khi them sinh vien la: ");
            foreach (var item in students)
            {
                Console.Write($"{item.Key} - {item.Value}\n");
            }
            Console.WriteLine();
        }
    }
}
