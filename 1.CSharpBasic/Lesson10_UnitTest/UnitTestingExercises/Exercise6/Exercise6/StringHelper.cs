namespace Exercise6
{
    public class StringHelper
    {
        public string RemoveVowels(string text)
        {
            string result = "";

            foreach (char item in text)
            {
                // Nếu không phải là nguyên âm thì thêm ký tự đó vào result
                if ("ueoaiUEOAI".Contains(item) == false)
                {
                    result += item;
                }    
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
