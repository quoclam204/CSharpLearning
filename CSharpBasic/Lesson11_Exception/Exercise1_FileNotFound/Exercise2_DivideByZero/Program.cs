namespace Exercise2_DivideByZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int a = 10, b = 0;
                int result = a / b;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
