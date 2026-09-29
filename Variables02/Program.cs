using System.Text;

namespace Variables02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("BT1: declare variables");

            /* -với mỗi kiểu dữ liệu tự đặt ra 5 biến có kiểu dữ liệu như sau (bool, char, decimal, double, float, int, string)
            => tổng cộng có 50 biến và 7 kiểu dữ liệu khác nhau:

            -thay đổi giá trị của các biến đã được tạo trước đó thành một giá trị mới.
            - in ra màn hình console các giá trị đó */

            // =========================
            // 1. BOOL
            // =========================
            bool isActive = true;
            bool hasValue = false;
            bool canLogin = true;
            bool isEmpty = true;
            bool isCompleted = false;

            // =========================
            // 2. CHAR
            // =========================
            char number = '2';
            char letter = 'A';
            char vietnameseChar = 'Đ';
            char firtsLetterOfName = 'L';
            char symbol = '@';

            // =========================
            // 3. DECIMAL
            // =========================
            decimal price = 50m;
            decimal salary = 8000.50m;
            decimal tax = 0.15m;
            decimal balance = 5000000m;
            decimal discount = 100000.75m;

            // =========================
            // 4. DOUBLE
            // =========================
            double height = 1.75;
            double weight = 70.5;
            double pi = 3.14159;
            double score = 9.5;
            double temperature = 36.0;

            // =========================
            // 5. FLOAT
            // =========================
            float speed = 60.5f;
            float roomTemperature = 22.5f;
            float personHeight = 1.75f;   
            float personWeight = 70.5f;
            float averageScore = 8.5f;

            // =========================
            // 6. INT
            // =========================
            int age = 22;
            int year = 2026;
            int count = 100;
            int total = 200;
            int quantity = 50;

            // =========================
            // 7. STRING
            // =========================
            string name = "Lâm";
            string address = "Đà Lạt";
            string phoneNumber = "0123456789";
            string email = "quoclam@gmail.com";
            string job = "Developer";
            string hobby = "Reading";

            // =========================
            // THAY ĐỔI GIÁ TRỊ
            // =========================
            isActive = false;
            number = '3';
            price = 40m;
            height = 1.80;
            speed = 70.5f;
            age = 23;
            name = "Quốc Lâm";

            Console.WriteLine(isActive);
            Console.WriteLine(number);
            Console.WriteLine(price);
            Console.WriteLine(height);
            Console.WriteLine(speed);
            Console.WriteLine(age);
            Console.WriteLine(name);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("BT2: chuyển đổi kiểu dữ liệu (bool, char, decimal, double, float, int, string)");

            /* => chuyển đổi kiểu dữ liệu từ char có giá trị là 'c' sang kiểu int
            => chuyển đổi kiểu dữ liệu từ int có giá trị là 100 sang kiểu char
            và cứ thế chuyển đổi toàn bộ kiểu dữ liệu này sang kiểu dữ liệu khác từ bool => char => decimal => double in ra màn hình xem chuyện gì sảy ra */

            char valueChar = 'c';
            int charToInt = (int)valueChar;
            Console.WriteLine("Chuyển đổi kiểu char -> int: {0}", charToInt);

            int number03 = 100;
            char character02 = (char)number03;
            Console.WriteLine($"Chuyển đổi kiểu int -> char: {character02}");

            decimal valueDecimal = 10.5m;
            double decimalToDouble = (double)valueDecimal;
            Console.WriteLine($"Chuyển đổi kiểu decimal -> double: {decimalToDouble}");

            bool valueBool = true;
            int boolToInt = valueBool ? 10 : 9;
            Console.WriteLine("Chuyển đổi kiểu dữ liệu bool -> int: " + boolToInt);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("BT3: nhập xuất dữ liệu");

            /* => nhập dữ liệu từ bàn phím sau đó lưu vào biến => in ra màn hình
            nhập vào tên, tuổi và in ra 2 câu dưới
            - in ra "My name's {tên của bạn}.";
            - in ra "I'm {tuổi của bạn} years old";
            -thử cố tình nhập sai dữ liệu giữa số và chữ xem chuyện gì sảy ra */

            Console.Write("Nhập số tuổi của bạn: ");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nhập tên của bạn: ");
            string nameInput = Console.ReadLine();

            Console.WriteLine($"My name's {nameInput}.");
            Console.WriteLine($"I'm {ageInput} years old");
        }
    }
}
