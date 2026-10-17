namespace Exercise3
{
    public class ArraySumNumber
    {
        public int ArrayNumber(int[] arr)
        {
            int sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
