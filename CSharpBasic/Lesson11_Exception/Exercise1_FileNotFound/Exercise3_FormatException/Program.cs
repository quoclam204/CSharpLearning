namespace Exercise3_FormatException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = "QuocLam";
                int number = int.Parse(text);

                Console.WriteLine(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
