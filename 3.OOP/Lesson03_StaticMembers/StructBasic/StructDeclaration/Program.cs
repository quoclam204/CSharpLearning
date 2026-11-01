namespace StructDeclaration
{
    struct QuocLamStruct
    {
        public int a;
        public int b;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khai bao struct trong C#");

            QuocLamStruct quoclam = new QuocLamStruct();
            quoclam.a = 27;
            quoclam.b = 02;

            int sum = quoclam.a + quoclam.b;

            Console.WriteLine("Tong la: " + sum);

            Console.ReadKey();
        }
    }
}
