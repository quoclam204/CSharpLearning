using System.Text;

namespace _07._2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // GetLength(0) và GetLength(1) -> Số dòng và số cột có trong mảng (0 là dòng; 1 là cột)

            Console.WriteLine("Bài tập 1: ");

            /*Write a program that initializes a 2D array of integers with values from 1 to 9 
             * and prints the array to the console. Expected output: 1 2 3 4 5 6 7 8 9*/

            int[,] matrixNumbers = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // numbers.GetLength(0) -> Lấy số lượng của hàng thứ nhất
            // numbers.GetLength(1) -> Lấy số lượng của cột thứ nhất

            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1); j++)
                {
                    Console.Write($"{matrixNumbers[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 2: ");

            /*Write a program that initializes a 2D array of integers with random values between 1 
             * and 100 and prints the array to the console. Expected output: [random array of integers between 1 and 100]*/

            Random random = new Random();
            int number = random.Next(1, 101);

            int[,] matrixNumbers2 = new int[3, 3];

            for (int i = 0; i < matrixNumbers2.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers2.GetLongLength(1); j++)
                {
                    matrixNumbers2[i, j] = random.Next(1, 101);
                    Console.Write($"{matrixNumbers2[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 3: ");

            /*Write a program that initializes a 2D array of characters with the letters of the alphabet 
             * in order and prints the array to the console. Expected output: 
             * a b c d e f g h i j k l m n o p q r s t u v w x y z*/

            char[,] matrixLetter =
            {
                {'a', 'b', 'c', 'd', 'e'},
                {'f', 'g', 'h', 'i', 'j'},
                {'k', 'l', 'm', 'n', 'o'},
                {'p', 'q', 'r', 's', 't'},
                {'u', 'v', 'w', 'x', 'y'},
                {'z', ' ', ' ', ' ', ' '}
            };

            for (int i = 0; i < matrixLetter.GetLength(0); i++)
            {
                for (int j = 0; j < matrixLetter.GetLength(1); j++)
                {
                    if (matrixLetter[i, j] != ' ')
                    {
                        Console.Write($"{matrixLetter[i, j]} ");
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 4: ");

            /*Write a program that initializes a 2D array of integers with values from 1 to 25 and 
             * prints only the even numbers to the console. Expected output: 2 4 6 8 10 12 14 16 18 20 22 24*/

            int[,] matrixNumbers3 =
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };

            for (int i = 0; i < matrixNumbers3.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers3.GetLength(1); j++)
                {
                    if (matrixNumbers3[i, j] % 2 == 0)
                    {
                        Console.Write($"{matrixNumbers3[i, j]} ");
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 5: ");

            /*Write a program that initializes a 2D array of strings with names of countries and their 
             * capitals, then prints each country and its capital to the console. Expected output: 
             * USA Washington D.C. France Paris Japan Tokyo Mexico Mexico City*/

            string[,] matrixCountry =
            {
                { "USA", "Washington D.C." },
                { "France", "Paris" },
                { "Japan", "Tokyo" },
                { "Mexico", "Mexico City" }
            };

            for (int i = 0; i < matrixCountry.GetLength(0); i++)
            {
                for (int j = 0; j < matrixCountry.GetLength(1); j++)
                {
                    Console.Write($"{matrixCountry[i, j]} ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 6: ");

            /* Write a program that initializes a 2D array of integers with values from 1 to 16 and prints 
             * the diagonal elements of the array to the console. Expected output: 1 6 11 16 */

            int[,] matrixNumber =
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            Console.Write("Các phần tử nằm trên đường chéo chính: ");

            for (int i = 0; i < matrixNumber.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumber.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matrixNumber[i, j]} ");
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 7: ");

            /* Write a program that initializes a 2D array of integers with random values between 1 and 100, 
             * then finds and prints the smallest value in the array. Expected output: The smallest value 
             * in the array is: [smallest value]*/

            int[,] matrixNumbers4 = new int[4, 4];

            // làm mồi để so sánh với các số khác trong mảng
            int smallest = 101; // Khởi tạo giá trị nhỏ nhất là 101, vì tạo số random ngẫu nhiên trong mảng là từ 1 đến 100

            for (int i = 0; i < matrixNumbers4.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers4.GetLength(1); j++)
                {
                    matrixNumbers4[i, j] = random.Next(1, 101);

                    Console.Write($"{matrixNumbers4[i, j]} ");

                    if (matrixNumbers4[i, j] < smallest)
                    {
                        smallest = matrixNumbers4[i, j];
                    }
                }
            }

            Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {smallest}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 8: ");

            /*Write a program that initializes a 2D array of integers with random values between 1 and 100, 
             * then finds and prints the sum of all the values in the array. Expected output: The sum of all the values in the array is: [sum]*/

            int[,] matrixNumbers5 = new int[3, 3];

            int sum = 0;

            for (int i = 0; i < matrixNumbers5.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers5.GetLength(1); j++)
                {
                    sum += matrixNumbers5[i, j] = random.Next(1, 101);

                    Console.Write($"{matrixNumbers5[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Tổng tất cả các giá trị trong mảng là: {sum}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 9: ");

            /* Write a program that initializes a 2D array of integers with values from 1 to 100, 
             * then finds and prints the average of the values in the array. Expected output: 
             * The average of all the values in the array is: [average] */

            int[,] matrixNumbers6 = new int[10, 10];

            int sum1 = 0;
            int number1 = 1;

            for (int i = 0; i < matrixNumbers6.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers6.GetLength(1); j++)
                {
                    // tạo các giá trị trong mảng từ 1 đến 100
                    matrixNumbers6[i, j] = number1;

                    sum1 += matrixNumbers6[i, j];

                    Console.Write($"{matrixNumbers6[i, j]} ");

                    number1++;
                }
                Console.WriteLine();
            }

            // Tính giá trị trung bình của các phần tử trong mảng
            double average = (double)sum1 / matrixNumbers6.Length;

            Console.WriteLine($"Giá trị trung bình của các phần tử trong mảng là: {average}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 10: ");

            /* Write a program that initializes a 2D array of integers with random values between 1 and 100, 
             * then sorts each row of the array in ascending order and prints the sorted array to the console. 
             * Expected output: [sorted array of integers] */

            int[,] matrixNumbers7 = new int[3, 3];

            // Tạo mảng random số nguyên ngẫu nhiên
            Console.WriteLine("Mảng ban đầu là: ");
            for (int i = 0; i < matrixNumbers7.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers7.GetLength(1); j++)
                {
                    matrixNumbers7[i, j] = random.Next(1, 101);

                    Console.Write($"{matrixNumbers7[i, j]} ");
                }
                Console.WriteLine();
            }

            // Thực hiện sắp xếp mảng
            // i chọn dòng → j chọn số hiện tại → k chọn số phía sau để so sánh. (j và k là dùng để so sánh các số)
            for (int i = 0; i < matrixNumbers7.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers7.GetLength(1); j++)
                {
                    for (int k = j + 1; k < matrixNumbers7.GetLength(1); k++)
                    {
                        if (matrixNumbers7[i, j] > matrixNumbers7[i, k])
                        {
                            int temp = matrixNumbers7[i, j];
                            matrixNumbers7[i, j] = matrixNumbers7[i, k];
                            matrixNumbers7[i, k] = temp;
                        }
                    }
                }
            }

            Console.WriteLine($"Mảng sau khi sắp xếp theo thứ tự tăng dần là: ");
            for (int i = 0; i < matrixNumbers7.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers7.GetLength(1); j++)
                {
                    Console.Write($"{matrixNumbers7[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 11: ");

            /* Write a program that initializes a 2D array of integers with random values between 
             * \1 and 100, then finds and prints the largest value in the array. Expected output: 
             * The largest value in the array is: [largest value] */

            int[,] matrixNumbers8 = new int[3, 3];

            int largest = 0;

            for (int i = 0; i < matrixNumbers8.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers8.GetLength(1); j++)
                {
                    matrixNumbers8[i, j] = random.Next(1, 101);

                    if (matrixNumbers8[i, j] > largest)
                    {
                        largest = matrixNumbers8[i, j];
                    }

                    Console.Write($"{matrixNumbers8[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Giá trị lớn nhất trong mảng là: {largest}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 12: ");

            /* Write a program that initializes a 2D array of integers with random values between 1 and 100, 
             * then finds and prints the median value in the array. Expected output: The median value in the array is: 
             * [median value] */

            int[,] matrixNumbers9 = new int[3, 3];

            // Tạo mảng random số nguyên ngẫu nhiên
            Console.WriteLine("Mảng ban đầu là: ");
            for (int i = 0; i < matrixNumbers9.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers9.GetLength(1); j++)
                {
                    matrixNumbers9[i, j] = random.Next(1, 101);

                    Console.Write($"{matrixNumbers9[i, j]} ");
                }
                Console.WriteLine();
            }

            // Tạo một mảng 1 chiều để chứa các giá trị trong mảng 2 chiều
            int[] arrayNumber = new int[matrixNumbers9.Length];

            int index = 0;

            for (int i = 0; i < matrixNumbers9.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers9.GetLength(1); j++)
                {
                    // Gán các giá trị trong mảng 2 chiều vào mảng 1 chiều
                    arrayNumber[index] = matrixNumbers9[i, j];
                    index++;
                }
            }

            // Sắp xếp mảng 1 chiều tăng dần
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

            Console.WriteLine("Mảng sau khi sắp xếp thành mảng 1 chiều là: ");
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.Write($"{arrayNumber[i]} ");
            }

            // Tìm giá trị trung vị
            int media = arrayNumber[arrayNumber.Length / 2];

            Console.WriteLine($"Giá trị trung vị trong mảng là: {media}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 13: ");

            /* Write a program that initializes a 2D array of integers with random values between 1 and 100, 
             * then prints the row and column indices of the minimum value in the array to the console. Expected output: 
             * The minimum value in the array is located at row [row] and column [column]. */

            int[,] matrixNumbers10 = new int[3, 3];

            int minRow = 0, minColumn = 0;

            // Khởi tạo giá trị nhỏ nhất là 101, vì tạo số random ngẫu nhiên trong mảng là từ 1 đến 100
            Console.WriteLine("Mảng ban đầu là: ");
            for (int i = 0; i < matrixNumbers10.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers10.GetLength(1); j++)
                {
                    matrixNumbers10[i, j] = random.Next(1, 101);

                    Console.Write($"{matrixNumbers10[i, j]} ");
                }
                Console.WriteLine();
            }

            // Tìm giá trị nhỏ nhất trong mảng 2 chiều
            for (int i = 0; i < matrixNumbers10.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers10.GetLength(1); j++)
                {
                    if (matrixNumbers10[i, j] < matrixNumbers10[minRow, minColumn])
                    {
                        minRow = i;
                        minColumn = j;
                    }    
                }
            }

            Console.WriteLine($"Giá trị của chỉ số hàng nhỏ nhất là: {minRow} và Giá trị của chỉ số cột nhỏ nhất là: {minColumn}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 14: ");

            /* Write a program that initializes a 2D array of integers with random values between 1 and 100, 
             * then prints the row and column indices of the maximum value in the array to the console. Expected output: 
             * The maximum value in the array is located at row [row] */

            int[,] matrixNumbers11 = new int[3, 3];

            int maxRow = 0, maxColumn = 0;

            for (int i = 0; i < matrixNumbers11.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers11.GetLength(1); j++)
                {
                    matrixNumbers11[i, j] = random.Next(1, 101);

                    Console.Write($"{matrixNumbers11[i, j]} ");
                }
                Console.WriteLine();
            }

            // Tìm giá trị lớn nhất trong mảng 2 chiều
            for (int i = 0; i < matrixNumbers11.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers11.GetLength(1); j++)
                {
                   if (matrixNumbers11[i, j] > matrixNumbers11[maxRow, maxColumn])
                    {
                        maxRow = i;
                        maxColumn = j;
                    }   
                }
            }

            Console.WriteLine($"Giá trị của chỉ số hàng lớn nhất là: {maxRow} và Giá trị của chỉ số cột lớn nhất là: {maxColumn}");
        }
    }
}
