namespace Exercise1_FileNotFound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("abc.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Không tìm thấy tệp tin");
            }
        }
    }
}
