namespace Exercise9
{
    public class FilterVowel
    {
        public string[] GetStringsStartingWithVowel(string[] arr)
        {
            List<string> result = [];

            foreach (var item in arr)
            {
                if (item.Length > 0 && "ueoaiUEOAI".Contains(item[0]))
                {
                    result.Add(item);
                }    
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
