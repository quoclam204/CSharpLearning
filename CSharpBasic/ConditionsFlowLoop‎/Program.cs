using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConditionsFlowLoop‎
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bài tập 1: ");

            /* Generate a random number between 1 and 100, and write an if statement that checks if the number 
            is greater than 50.If it is, print "The number is greater than 50"; otherwise, print "The number " +
            "is less than or equal to 50". */

            Random rnd = new Random();
            int number = rnd.Next(1, 100);

            if (number > 50)
            {
                Console.WriteLine($"Số lớn hơn 50 là: {number}");
            }
            else if (number <= 50)
            {
                Console.WriteLine($"Số nhỏ hơn hoặc bằng 50 là: {number}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 2: ");

            /* Write an if-else statement that checks if a number is even or odd.If it's even, print 
            "The number is even"; otherwise, print "The number is odd". */

            if (number % 2 == 0)
            {
                Console.WriteLine($"Số vừa random là số chẵn: {number}");
            }
            else
            {
                Console.WriteLine($"Số vừa random là số lẻ: {number}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 3: ");

            /* Write an if-else statement that checks a student's grade and prints a message depending on the grade. 
            If the grade is greater than or equal to 90, print "Excellent work!"; if it's between 80 and 89, print "Good job!"; 
            if it's between 70 and 79, print "Nice try!"; and if it's less than 70, print "You need more practice!". */

            Console.WriteLine($"Điểm số của học sinh hiện tại là: {number}");

            if (number >= 90)
            {
                Console.WriteLine("Làm việc tuyệt vời!");
            }
            else if (number >= 80 && number <= 89)
            {
                Console.WriteLine("Làm tốt lắm!");
            }
            else if (number >= 70 && number <= 79)
            {
                Console.WriteLine("Cố gắng thêm nhé!");
            }
            else if (number < 70)
            {
                Console.WriteLine("Bạn cần luyện tập nhiều hơn!");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 4: ");

            /* Write a switch statement that checks a person's job title and prints a message depending on the title. 
            If the title is "Manager", print "You are in charge"; if it's "Employee", print "You work for the manager"; 
            and if it's "Intern", print "You are learning". */

            string[] title = { "Manager", "Employee", "Intern" };

            string jobTitle = title[rnd.Next(0, title.Length)];

            Console.WriteLine($"Chức danh công việc của tôi hiện tại là: {jobTitle}");

            switch (jobTitle)
            {
                case "Manager":
                    Console.WriteLine($"Tôi là người quản lý!");
                    break;
                case "Employee":
                    Console.WriteLine($"Tôi làm việc cho quản lý!");
                    break;
                case "Intern":
                    Console.WriteLine($"Tôi đang học hỏi!");
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 5: ");

            /* Write a loop that generates a random number between 1 and 10, and prints the number 
            until it generates the number 7. */

            int number1;

            do
            {
                number1 = rnd.Next(1, 11);

                Console.WriteLine($"Số được in ra là: {number1}");

            } while (number1 != 7);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 6: ");

            /* Write a do-while loop that asks the user to enter a number between 1 and 100, 
             * and keeps asking until the user enters a valid number. */

            int nhapSo;

            do
            {
                Console.Write("Nhập một số từ 1 đến 100: ");
                nhapSo = int.Parse(Console.ReadLine());
            } while (nhapSo < 1 || nhapSo > 100);

            Console.WriteLine($"Số hợp lệ khi đã nhập là: {nhapSo}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 7: ");

            /* Write a while loop that counts from 1 to 10 and prints each number. */

            int dem = 1;

            while (dem <= 10)
            {
                Console.WriteLine(dem);
                dem++;
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 8: ");

            /* Write a loop that generates 10 random numbers between 1 and 100, and prints the sum of the numbers. */

            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                int number2 = rnd.Next(1, 101);

                Console.WriteLine($"Số thứ {i + 1} là: {number2}");

                sum += number2;
            }

            Console.WriteLine($"Tổng là: {sum}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 9: ");

            /* Write a loop that prints the first 10 even numbers. */

            for (int i = 0; i < 10; i++)
            {
                int soChan = i * 2;

                Console.WriteLine($"Số chẵn thứ {i} là: {soChan}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 10: ");

            /* Write a loop that generates a random number between 1 and 100, and keeps generating 
             * numbers until it generates a number that is greater than 50. */

            while (true)
            {
                int number3 = rnd.Next(1, 101);

                Console.WriteLine($"Số ngẫu nhiên là: {number3}");

                if (number3 > 50)
                {
                    break;
                }
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 11: ");

            /* Write an if statement that checks if a number is positive or negative, and prints a message accordingly. */

            Console.Write("Nhập 1 số bất kỳ: ");
            int nhapSo1 = int.Parse(Console.ReadLine());

            if (nhapSo1 > 0)
            {
                Console.WriteLine("Số bạn vừa nhập là 1 số dương!");
            }
            else if (nhapSo1 < 0)
            {
                Console.WriteLine("Số bạn vừa nhập là 1 số âm!");
            }
            else
            {
                Console.WriteLine("Số bạn vừa nhập là 0!");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 12: ");

            /* Write a switch statement that checks the day of the week and prints a message depending on the day.
                If it's Monday, print "It's Monday, the week is starting"; if it's Friday, print "It's Friday, 
                the weekend is almost here"; and if it's any other day, print "It's a regular day". */

            DateTime now = DateTime.Now;

            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Hôm nay là thứ 2, tuần mới bắt đầu!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Hôm nay là thứ 6, cuối tuần sắp đến!");
                    break;
                default:
                    Console.WriteLine("Hôm nay là 1 ngày bình thường!");
                    break;
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 13: ");

            /* Write an if-else statement that checks if a number is divisible by 3 and / or 5, and prints 
            a message accordingly.If it's divisible by 3, print "The number is divisible by 3"; if it's 
            divisible by 5, print "The number is divisible by 5"; and if it's divisible by both, print 
            "The number is divisible by both 3 and 5". */

            Console.Write("Nhập 1 số bất kỳ: ");
            int nhapSo2 = int.Parse(Console.ReadLine());

            if (nhapSo2 % 3 == 0 && nhapSo2 % 5 == 0)
            {
                Console.WriteLine("Số bạn vừa nhập chia hết cho cả 3 và 5!");
            }
            else if (nhapSo2 % 3 == 0)
            {
                Console.WriteLine("Số bạn vừa nhập chia hết cho 3!");
            }
            else if (nhapSo2 % 5 == 0)
            {
                Console.WriteLine("Số bạn vừa nhập chia hết cho 5!");
            }
            else
            {
                Console.WriteLine("Số bạn vừa nhập không chia hết cho cả 3 và 5!");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 14: ");

            /* Write an expression that calculates the area of a rectangle with a length of 5 and a width of 10. */

            int chieuDaiHCN = 5, chieuRongHCN = 10;
            Console.WriteLine("Chiều dài hình chữ nhật là: " + chieuDaiHCN);
            Console.WriteLine("Chiều rộng hình chữ nhật là: " + chieuRongHCN);
            Console.WriteLine("Diện tích hình chữ nhật là: " + chieuDaiHCN * chieuRongHCN);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 15: ");

            /* Write a loop that prints the first 10 numbers in the Fibonacci sequence. */
            // 0 1 1 2 3 5 8 13 21 34

            int a = 0, b = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);

                int next = a + b;
                a = b;
                b = next;

            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 16: ");

            /* Write an if-else statement that checks if a number is between 0 and 100, and prints a message 
            accordingly.If it's between 0 and 50, print "The number is between 0 and 50"; if it's between 
            51 and 100, print "The number is between 51 and 100"; and if it's not between 0 and 100, print 
            "The number is not between 0 and 100". */

            Console.Write("Nhập 1 số bất kỳ: ");
            int nhapSo3 = int.Parse(Console.ReadLine());

            if (nhapSo3 >= 0 && nhapSo3 <= 50)
            {
                Console.WriteLine("Số bạn vừa nhập nằm trong khoảng từ 0 đến 50!");
            }
            else if (nhapSo3 >= 51 && nhapSo3 <= 100)
            {
                Console.WriteLine("Số bạn vừa nhập nằm trong khoảng từ 51 đến 100!");
            }
            else
            {
                Console.WriteLine("Số bạn vừa nhập không nằm trong khoảng từ 0 đến 100!");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 17: ");

            /* Write a loop that generates a random number between 1 and 100, and prints the number 
            until it generates a number that is 55 */

            int number4;

            do
            {
                number4 = rnd.Next(1, 101);
                Console.WriteLine(number4);
            } while (number4 != 55);
        }
    }
}
