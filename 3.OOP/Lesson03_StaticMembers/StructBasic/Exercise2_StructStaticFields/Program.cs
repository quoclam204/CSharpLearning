namespace Exercise2_StructStaticFields
{
    struct QuocLamStruct2
    {
        public static int a;
        public static int b;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khai bao struct trong C#");

            // vì dùng biến static nên phải truy cập bằng tên của struct đó luôn
            QuocLamStruct2.a = 27;
            QuocLamStruct2.b = 02;

            int sum = QuocLamStruct2.a + QuocLamStruct2.b;

            Console.WriteLine("Tong la: " + sum);

            Console.ReadKey();
        }
    }
}
