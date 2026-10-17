namespace Exercise5
{
    public class FindMax
    {
        public int MaxNumber(int[] arrNumber)
        {
            int max = arrNumber[0];

            foreach (var item in arrNumber)
            {
                if (max < item)
                {
                    max = item;
                }    
            }

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
