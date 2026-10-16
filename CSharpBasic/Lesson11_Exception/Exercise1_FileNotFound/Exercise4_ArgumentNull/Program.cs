namespace Exercise4_ArgumentNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string? text = Console.ReadLine();

                if (string.IsNullOrEmpty(text))
                {
                    throw new ArgumentNullException();
                }    
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Input cannot be empty");
            }
        }
    }
}
