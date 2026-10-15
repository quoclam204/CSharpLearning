namespace Exercise7
{
    public class CountTest
    {
        public int Count(string[] arr)
        {
            int count = 0;

            foreach (var item in arr)
            {
                if (item.Contains("test"))
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
