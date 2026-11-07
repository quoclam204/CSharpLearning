namespace Exercise4_DictionaryBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Lam", 9);
            students.Add("Nam", 8);
            students.Add("An", 7);
            students.Add("Minh", 10);

            Console.WriteLine("Diem cua sinh vien Lam la: " + students["Lam"]);

            foreach (var item in students)
            {
                Console.Write($"Ten sinh vien {item.Key} - So diem {item.Value} \n");
            }

            Console.WriteLine("So luong sinh vien: " + students.Count);
        }
    }
}
