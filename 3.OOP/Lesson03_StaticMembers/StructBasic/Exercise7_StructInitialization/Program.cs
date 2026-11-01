namespace Exercise7_StructInitialization
{
    public struct NewStruct
    {
        // trường dữ liệu
        public int a, b;

        // hàm khởi tạo
        public NewStruct(int pt1, int pt2)
        {
            a = pt1;
            b = pt2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NewStruct newStruct;

            newStruct.a = 20;
            newStruct.b = 30;

            Console.WriteLine($"{newStruct.a}, {newStruct.b}");
        }
    }
}
