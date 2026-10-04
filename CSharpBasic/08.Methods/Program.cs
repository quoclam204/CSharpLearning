using System.Runtime.CompilerServices;
using System.Text;

namespace _08.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bài tập 1: ");

            /* Write a method called CalculateSum that takes two integers as parameters and returns their sum. 
             * For example, CalculateSum(2, 3) should return 5. */

            static int CalculateSum(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine($"Tổng hai số nguyên là: {CalculateSum(2, 3)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 2: ");

            /* Write a method called IsPositive that takes an integer as a parameter and returns true if the 
             * integer is positive, and false otherwise. For example, IsPositive(-3) should return false. */

            static bool IsPositve(int number)
            {
                if (number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            Console.WriteLine($"{IsPositve(-2)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 3: ");

            /* Write a method called ReverseString that takes a string as a parameter and returns the reversed string. 
             * For example, ReverseString("hello") should return olleh.*/

            static string ReverseString(string reverse)
            {
                // chuyển string thành mảng char
                char[] charArray = reverse.ToCharArray();
                Array.Reverse(charArray); // đảo ngược thứ tự các ký tự trong mảng

                return new string(charArray);
            }

            string chuoi = "hello";

            Console.WriteLine($"Chuỗi ban đầu là: {chuoi}");

            Console.WriteLine($"Chuỗi sau khi đảo ngược là: {ReverseString(chuoi)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 4: ");

            /* Write a method called FindMax that takes an array of integers as a parameter and returns 
             * the largest value in the array. For example, FindMax([2, 5, 1, 7, 3]) should return 7. */

            int[] arrNumber = { 2, 5, 1, 7, 3 };

            static int FindMax(int[] numbers)
            {
                int max = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {

                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }
                }

                return max;
            }

            Console.WriteLine($"Giá trị lớn nhất trong mảng là: {FindMax(arrNumber)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 5: ");

            /* Write a method called IsPalindrome that takes a string as a parameter and returns true if the string is a
             * palindrome (i.e., it reads the same backward as forward), and false otherwise. For example, IsPalindrome("racecar") 
             * should return true. */

            static bool IsPalindrome(string text)
            {
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);

                string arrayNew = new string(charArray);

                if (text == arrayNew)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine($"Chuỗi sau khi đọc ngược và đọc xuôi là: {IsPalindrome("racecar")}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 6: ");

            /* Write a method called CalculateFactorial that takes an integer as a parameter and returns its factorial (i.e., 
             * the product of all positive integers up to and including the integer). For example, CalculateFactorial(5) 
             * should return 120. */

            static int CalculateFactorial(int number)
            {
                int result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }

            Console.WriteLine($"5! = {CalculateFactorial(5)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 7: ");

            /* Write a method called IsEven that takes an integer as a parameter and returns true if the 
             * integer is even, and false otherwise. For example, IsEven(7) should return false. */

            static bool IsEven(int number)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine($"Số nguyên điền vào là số 7: {IsEven(7)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 8: ");

            /* Write a method called SortArray that takes an array of integers as a parameter and returns a sorted array. 
             * For example, SortArray([3, 1, 5, 2, 4]) should return [1, 2, 3, 4, 5]. */

            static int[] SortArray(int[] arrayNumber)
            {
                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    for (int j = i + 1; j < arrayNumber.Length; j++)
                    {
                        if (arrayNumber[i] > arrayNumber[j])
                        {
                            int temp = arrayNumber[i];
                            arrayNumber[i] = arrayNumber[j];
                            arrayNumber[j] = temp;
                        }
                    }
                }

                return arrayNumber;
            }

            int[] numbers = { 3, 1, 5, 2, 4 };

            int[] result = SortArray(numbers);

            Console.WriteLine($"Mảng sau khi sắp xếp là: ");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 9: ");

            /* Write a method called ConvertToFahrenheit that takes a temperature in Celsius as a parameter and 
             * returns the equivalent temperature in Fahrenheit. For example, ConvertToFahrenheit(25) should return 77. */

            static double ConvertToFahrenheit(double celsius)
            {
                double fahrenheit = celsius * 9 / 5 + 32;

                return fahrenheit;
            }

            Console.WriteLine($"25 độ C sang độ F là: {ConvertToFahrenheit(25)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 10: ");

            /* Write a method called GetAverage that takes an array of integers as a parameter and returns the average 
             * of the values in the array. For example, GetAverage([1, 2, 3, 4, 5]) should return 3. */

            static double GetAverage(int[] arrayNumber)
            {
                double average;
                int sum = 0;

                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    sum += arrayNumber[i];
                }

                average = (double)sum / arrayNumber.Length;
                return average;
            }

            int[] number2 = { 1, 2, 3, 4, 5 };

            double result2 = GetAverage(number2);

            Console.WriteLine($"Giá trị trung bình của các phần tử [1, 2, 3, 4, 5] trong mảng là: {result2}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 11: ");

            /* Write a method named CountWords that takes a string as an input and returns the number of words in the string. 
             * Example: CountWords("The quick brown fox jumps over the lazy dog.") should return 9. */

            static int CountWords(string sentence)
            {
                string[] words = sentence.Split(' ');

                //int count = words.Count();

                //return count;

                //return words.Length;

                return words.Count();
            }

            string words = "The quick brown fox jumps over the lazy dog.";

            int result3 = CountWords(words);

            Console.WriteLine($"Số lượng từ có trong mảng là: {result3}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 12: ");

            /* Write a method named CalculateFactorial that takes an integer as an input and returns the factorial of that number. 
             * Example: CalculateFactorial(5) should return 120. */

            static int CalculateFactorial1(int number)
            {
                int result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }

            Console.WriteLine($"5! = {CalculateFactorial1(5)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 13: ");

            /* Write a method named ReverseString that takes a string as an input and returns the reverse of that string. 
             * Example: ReverseString("hello world") should return "dlrow olleh". */

            static string ReverseString1(string reverse)
            {
                // chuyển string thành mảng char
                char[] charArray = reverse.ToCharArray();
                Array.Reverse(charArray); // đảo ngược thứ tự các ký tự trong mảng

                return new string(charArray);
            }

            string chuoi1 = "hello world";

            Console.WriteLine($"Chuỗi hello world sau khi đảo ngược là: {ReverseString1(chuoi1)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 14: ");

            /* Write a method named GetLargestNumber that takes an array of integers as an input and returns the largest 
             * number in the array. Example: GetLargestNumber(new int[] { 3, 6, 9, 12 }) should return 12. */

            static int MaxNumber(int[] arrNumber)
            {
                int maxNumber = arrNumber[0];

                for (int i = 1; i < arrNumber.Length; i++)
                {
                    if (maxNumber < arrNumber[i])
                    {
                        maxNumber = arrNumber[i];
                    }
                }

                return maxNumber;
            }

            int[] arrNumber1 = { 3, 6, 9, 12 };

            Console.WriteLine($"Số lớn nhất trong mảng {{ 3, 6, 9, 12 }} là: {MaxNumber(arrNumber1)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 15: ");

            /* Write a method named GetMonthName that takes an integer representing a month (1-12) as an input and 
             * returns the name of the month. Example: GetMonthName(3) should return "March". */

            static string GetMonthName(int month)
            {
                switch (month)
                {
                    case 1:
                        return "January";
                    case 2:
                        return "February";
                    case 3:
                        return "March";
                    case 4:
                        return "April";
                    case 5:
                        return "May";
                    case 6:
                        return "June";
                    case 7:
                        return "July";
                    case 8:
                        return "August";
                    case 9:
                        return "September";
                    case 10:
                        return "October";
                    case 11:
                        return "November";
                    case 12:
                        return "December";
                    default:
                        return "Invalid month";
                }
            }

            Console.WriteLine(GetMonthName(3));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 15: ");

            /* Write a method named ReverseArray that takes an array of integers as an input and returns the reverse of the array.
             * Example: ReverseArray(new int[] { 1, 2, 3, 4, 5 }) should return { 5, 4, 3, 2, 1 }. */

            static int[] ReverseArray3(int[] arrNumber)
            {
                // tạo mảng mới có độ dài bằng mảng ban đầu
                int[] reverseArray = new int[arrNumber.Length];

                for (int i = 0; i < arrNumber.Length; i++)
                {
                    // lấy phần tử cuối gán vào mảng mới -> đảo ngược mảng
                    reverseArray[i] = arrNumber[arrNumber.Length - 1 - i];
                }

                return reverseArray;
            }

            int[] result4 = ReverseArray3(new int[] { 1, 2, 3, 4, 5 });

            foreach (var item in result4)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 16: ");

            /* Write a method named IsEven that takes an integer as an input and returns true if the 
             * integer is even, and false otherwise. Example: IsEven(7) should return false. */

            static bool IsEven1(int number)
            {
                if (number % 2 == 0)
                    return true;
                else
                    return false;
            }

            Console.WriteLine("Số nguyên mẫu là 7 nhập vào hàm: " + IsEven1(7));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 17: ");

            static int Mutiply(int a, int b)
            {
                return a * b;
            }

            Console.WriteLine("Kết quả của 5 x 7 = " + Mutiply(5, 7));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 18: ");

            /* Create a method called AddNumbers that takes in a variable number of integers and returns their sum. 
             * Expect the method to correctly add any number of integers passed to it. Example result: AddNumbers(1, 2, 3, 4, 5) 
             * returns 15.*/

            static int AddNumbers(int[] arrSum)
            {
                int sum = 0;

                for (int i = 0; i < arrSum.Length; i++)
                {
                    sum += arrSum[i];
                }

                return sum;
            }

            int[] arrSum = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Tổng của { 1, 2, 3, 4, 5 } là: " + AddNumbers(arrSum));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 19: ");

            /* Create a method called GetAverage that takes in an array of integers and returns their average. 
             * Expect the method to correctly calculate the average of any array of integers passed to it. Example result: 
             * GetAverage(new int[] { 2, 4, 6, 8 }) returns 5. */

            static double GetAverage1(int[] arrNumber)
            {
                double average;
                int sum = 0;

                for (int i = 0; i < arrNumber.Length; i++)
                {
                    sum += arrNumber[i];
                }

                average = (double)sum / arrNumber.Count();
                return average;
            }

            int[] arrNumber2 = { 2, 4, 6, 8 };

            Console.WriteLine("Giá trị trung bình của mảng { 2, 4, 6, 8 } là: " + GetAverage1(arrNumber2));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 20: ");

            /* Create a method called ReverseString that takes in a string and returns the reversed version of the string. 
             * Expect the method to correctly reverse any string passed to it. Example result: ReverseString("hello") returns "olleh" */

            static string ReverseString2(string text)
            {
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);

                return new string(charArray);
            }

            Console.WriteLine("Chuỗi (hello) sau khi đảo ngược là: " + ReverseString2("hello"));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 21: ");

            static bool IsEven2(int number)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                else
                    return false;
            }

            Console.WriteLine($"Số 7 truyền vào là: {IsEven2(7)}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 22: ");

            /* Create a method called GetMax that takes in an array of integers and returns the maximum value in the array. 
             * Expect the method to correctly identify the maximum value of any array of integers passed to it. Example result: 
             * GetMax(new int[] { 4, 8, 2, 9, 5 }) returns 9. */

            static int GetMax(int[] arrNumber)
            {
                int max = arrNumber[0];

                for (int i = 1; i < arrNumber.Length; i++)
                {
                    if (max < arrNumber[i])
                    {
                        max = arrNumber[i];
                    }    
                }

                return max;
            }

            int[] arrNumbers = { 4, 8, 2, 9, 5 };

            Console.WriteLine("Giá trị lớn nhất trong mảng { 4, 8, 2, 9, 5 } là: " + GetMax(arrNumbers));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 23: ");

            /* Create a method called IsPalindrome that takes in a string and returns a boolean indicating whether the string 
             * is a palindrome (i.e. the same forwards and backwards). Expect the method to correctly identify whether any string 
             * passed to it is a palindrome. Example result: IsPalindrome("racecar") returns true.*/

            static bool IsPalindrome1(string text)
            {
                // chuỗi thành mảng chuỗi
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray); // đảo ngược chuỗi

                string reversedText = new string(text); // tạo 1 chuỗi mới từ các ký tự hiện tại trong mảng charArray sau khi đảo ngược

                if (text == reversedText)
                {
                    return true;
                }
                else
                    return false;
            }

            Console.WriteLine("Chuỗi racecar đọc xuôi hay đọc ngược đểu giống nhau: " + IsPalindrome1("racecar"));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 24: ");

            /* Create a method called GetFirstLetters that takes in an array of strings and returns a string consisting of 
             * the first letter of each string in the array. Expect the method to correctly extract the first letter of each 
             * string in any array passed to it. Example result: GetFirstLetters(new string[] { "apple", "banana", "cherry" }) 
             * returns "abc". */

            static string GetFirstLetters(string[] words)
            {
                string result = "";

                for (int i = 0; i < words.Length; i++)
                {
                    // words[i]: lấy chuỗi hiện tại trong mảng.
                    // [0]: lấy ký tự đầu tiên của chuỗi đó.
                    result += words[i][0];
                }

                // Duyệt từng phần tử kiểu string trong mảng
                //foreach (string word in words)
                //{
                //    result += word[0];
                //}
                        
                return result;
            }

            Console.WriteLine(GetFirstLetters(new string[] { "apple", "banana", "cherry" }));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 25: ");

            /* Create a method called IsPrime that takes in an integer and returns a boolean indicating whether the 
             * integer is prime (i.e. only divisible by 1 and itself). Expect the method to correctly identify whether 
             * any integer passed to it is prime. Example result: IsPrime(13) returns true. */

            static bool IsPrime(int number)
            {
                if (number <= 1)
                    return false;

                // xem thử số đó có chia hết cho 2 và i++ không
                // nếu chia hết thì không phải là số nguyên tố
                // i = 2 vì số nguyên tố chia hết cho 1
                // i < number: vì số đó chia hết cho chính nó vd: số 13 thì tới i < 12 thôi
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }

            Console.WriteLine("Số 13 có phải là số nguyên tố không: " + IsPrime(1));

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 26: ");

            /* Create a method called FormatName that takes in two strings representing a person's first and last 
             * name and returns a formatted full name string (i.e. "Last, First"). Expect the method to correctly 
             * format any first and last name passed to it. Example result: FormatName("John", "Doe") returns "Doe, John". */

            static string FormatName(string ten, string ho)
            {
                return ho + ", " + ten;
            }

            Console.WriteLine("Nối chuỗi tên và họ của (Lâm) và (Nguyễn) là: " + FormatName("Lâm", "Nguyễn"));
        }
    }
}
