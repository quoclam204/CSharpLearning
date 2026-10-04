using Microsoft.VisualBasic;
using System;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bài tập 1: ");

            /* Declare an array of integers with values 1, 2, 3, 4, 5. 
               Print the values in the array to the console. Expected output: 1 2 3 4 5 */

            int[] number = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 2: ");

            /* Declare an array of strings with values "apple", "banana", "cherry", "date", "elderberry".
            Print the values in the array to the console.Expected output: apple banana cherry date elderberry */

            string[] array = { "apple", "banana", "cherry", "date", "elderberry" };

            foreach (string fruit in array)
            {
                Console.Write($"{fruit} ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 3: ");

            /* Declare an array of integers with values 1, 2, 3, 4, 5.Use a loop to add 2 to each value in the array, 
            and then print the values to the console.Expected output: 3 4 5 6 7 */

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i] + 2} ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 4: ");

            /* Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to calculate the sum of the values 
             * in the array, and then print the sum to the console. Expected output: 15*/

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            Console.WriteLine($"Tổng trong mảng là: {sum}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 5: ");

            /* Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to calculate the average 
             * of the values in the array, and then print the average to the console. Expected output: 3 */

            int average = 0;

            for (int i = 0; i < number.Length; i++)
            {
                average += number[i] % 2;
            }

            Console.WriteLine($"Trung bình cộng trong mảng là: {average}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 6: ");

            /* Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to find the maximum value in the array, 
             * and then print the maximum value to the console. Expected output: 5 */

            int max = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (max < number[i])
                {
                    max = number[i];
                }
            }

            Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 7: ");

            /* Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to find the minimum value 
             * in the array, and then print the minimum value to the console. Expected output: 1*/

            int min = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (min > number[i])
                {
                    min = number[i];
                }
            }

            Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 8: ");

            /*Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to sort the values 
             * in the array in descending order, and then print the sorted values to the console. Expected output: 5 4 3 2 1*/

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] < number[j])
                    {
                        int temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }

            Console.Write("Mảng sau khi được sắp xếp từ lớn đến nhỏ là: ");

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 9: ");

            /*Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to reverse the order of 
             * the values in the array, and then print the reversed values to the console. Expected output: 5 4 3 2 1*/

            int[] number2 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < number2.Length / 2; i++)
            {
                int temp = number2[i];
                number2[i] = number2[number2.Length - 1 - i];
                number2[number2.Length - 1 - i] = temp;
            }

            Console.WriteLine("Mảng sau khi đổi là: ");

            for (int i = 0; i < number2.Length; i++)
            {
                Console.Write($"{number2[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 10: ");

            /*Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to search for the 
             * value 3 in the array, and then print "found" to the console if the value is found, and "not found" 
             * if the value is not found. Expected output: found*/

            int[] number3 = { 1, 2, 3, 4, 5 };

            bool found = false;

            for (int i = 0; i < number3.Length; i++)
            {
                if (number3[i] == 3)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 11: ");

            /*Declare an array of integers with values 1, 2, 3, 4, 5. Use a loop to search for the value 
             * 6 in the array, and then print "found" to the console if the value is found, and "not found" 
             * if the value is not found. Expected output: not found*/

            int[] number4 = { 1, 2, 3, 4, 5 };

            bool found1 = false;

            foreach (var array1 in number4)
            {
                if (array1 == 6)
                {
                    found1 = true;
                }
            }

            if (found1)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Bài tập 12: ");

            /*Declare an array of strings with values "apple", "banana", "cherry", "date", "elderberry". 
             * Use a loop to concatenate all the strings in the array into a single string, separated by spaces, 
             * and then print the concatenated string to the console. Expected output: "apple banana cherry date elderberry"*/

            string result = "";

            foreach (string fruit in array)
            {
                result += fruit + " ";
            }

            Console.WriteLine(result);
        }
    }
}
