namespace SwapNumber
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Swap2(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Hai phan tu luc dau a và b la: {a} va {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"Sau khi hoan doi bang ref a và b la : {a} va {b}");

            int c = 30, d = 40;
            Console.WriteLine($"Hai phan tu luc dau c và d la: {c} va {d}");

            Swap2(c, d);
            Console.WriteLine($"Sau khi hoan doi bang ham thong thuong c và d la : {c} va {d}");
        }
    }
}
