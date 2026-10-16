namespace Exercise5_ArgumentOutOfRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int size = -5;

                if (size < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // tạo một mảng số nguyên có size phần tử
                int[] arr = new int[size];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Array size must be positive");
            }
        }
    }
}
