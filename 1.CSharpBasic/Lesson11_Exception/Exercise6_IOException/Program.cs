namespace Exercise6_IOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("abc.txt");
                Console.WriteLine(content.ToUpper());
            }
            catch (IOException)
            {
                Console.WriteLine("Cannot read file");
            }
        }
    }
}
