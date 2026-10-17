namespace Exercise4
{
    public class StringHelper
    {
        public int CountCharacter(string text, char character)
        {
            int count = 0;

            foreach (char item in text)
            {
                if (character == item)
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
