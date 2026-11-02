namespace MethodRefOut
{
    internal class Program
    {
        public static void Change(ref int number)
        {
            number = 10;
        }

        public static void GetNumber(out int number)
        {
            number = 20;
        }

        static void Main(string[] args)
        {
            int r = 15;
            Change(ref r);
            Console.WriteLine(r);

            int o = 25;
            GetNumber(out o);
            Console.WriteLine(o);
        }
    }
}
