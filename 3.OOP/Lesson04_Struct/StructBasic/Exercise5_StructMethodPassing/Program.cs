using System.Security.Cryptography.X509Certificates;

namespace Exercise5_StructMethodPassing
{
    class NewClass
    {
        public int n;
    }

    struct NewStruct
    {
        public int n;
    }

    internal class Program
    {
        public static void TrackStruct(NewStruct ns)
        {
            ns.n = 30;
        }

        public static void TrackClass(NewClass nc)
        {
            nc.n = 40;
        }

        static void Main(string[] args)
        {
            NewStruct ns = new NewStruct();
            NewClass nc = new NewClass();

            ns.n = 35;
            nc.n = 45;

            TrackStruct(ns); // Thay đổi thuộc tính trong hàm KHÔNG ảnh hưởng bản gốc
            TrackClass(nc);  // Thay đổi thuộc tính trong hàm CÓ ảnh hưởng bản gốc

            Console.WriteLine($"Struct: {ns.n}");
            Console.WriteLine($"Class: {nc.n}");
        }
    }
}
