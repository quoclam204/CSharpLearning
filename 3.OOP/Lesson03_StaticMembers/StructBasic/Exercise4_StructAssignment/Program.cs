namespace Exercise4_StructAssignment
{
    internal class Program
    {
        class NewClass
        {
            public int a;
            public int b;
        }

        struct NewStruct
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            // Class (tham chiếu)
            NewClass newClass1 = new NewClass();
            newClass1.a = 20;
            newClass1.b = 30;

            // Không phải sao chép object, mà là sao chép địa chỉ tham chiếu đến object. (referen type)
            NewClass newClass2 = newClass1; // newClass2 đang trỏ đến Object mà newClass1 đang trỏ tới
            newClass1.a = 25; // Thực hiện thay đổi dữ liệu của Object1
            newClass1.b = 35;
            Console.WriteLine($"Thuc hien hoat dong gan Class: {newClass2.a} và {newClass2.b}");

            // Struct (tham trị)
            NewStruct newStruct1 = new NewStruct();
            newStruct1.x = 40;
            newStruct1.y = 50;

            NewStruct newStruct2 = newStruct1; // Sao chép dữ liệu sang biến thứ 2
            newStruct1.x = 45; // newStruct1 là 45 và 55 còn newStruct2 vẫn giữ nguyên 40 và 50
            newStruct1.y = 55;
            Console.WriteLine($"Thuc hien hoat dong gan Struct: {newStruct2.x} và {newStruct2.y}");
        }
    }
}
