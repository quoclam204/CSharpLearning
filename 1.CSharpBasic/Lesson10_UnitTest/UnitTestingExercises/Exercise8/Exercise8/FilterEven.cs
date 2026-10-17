namespace Exercise8
{
    public class FilterEven
    {
        public int[] GetEvenNumbers(int[] arr)
        {
            List<int> numbers = [];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    numbers.Add(arr[i]);
                }    
            }

            // Chuyển lại thành mảng vì hiện tại numbers là danh sách
            return numbers.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
