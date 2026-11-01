namespace Exercise3_NestedStruct
{
    internal class Program
    {
        struct NhanVien
        {
            public string Name;
            public NgaySinh Date;
        }

        struct NgaySinh
        {
            public int day;
            public int month;
            public int year;
        }

        static void Main(string[] args)
        {
            NhanVien nhanVien = new NhanVien();

            nhanVien.Name = "Quoc Lam";

            // Gán ngày sinh (struct lồng struct)
            nhanVien.Date.day = 27;
            nhanVien.Date.month = 02;
            nhanVien.Date.year = 2004;

            Console.WriteLine("Ten nhan vien: " + nhanVien.Name);
            Console.WriteLine($"Ngay sinh: {nhanVien.Date.day}/{nhanVien.Date.month}/{nhanVien.Date.year}");
        }
    }
}
