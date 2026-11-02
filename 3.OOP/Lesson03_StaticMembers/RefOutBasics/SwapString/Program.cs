namespace SwapString
{
    internal class Program
    {
        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            string a = "quoc", b = "lam";
            Console.WriteLine($"Hai phan tu luc dau a và b la: {a} va {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"Sau khi hoan doi a và b la : {a} va {b}");
        }
    }
}
