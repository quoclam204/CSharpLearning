using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson08_Overloading
{
    internal class Calculator
    {
        // ===== BÀI 1 =====
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        // ===== BÀI 2 =====
        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Divide(double a, double b, double c)
        {
            return a / (b * c);
        }

        public double Divide(double a, double b, double c, double d)
        {
            return (a * b) / (c * d);
        }

        // ===== BÀI 3 =====
        public string Concatenate(string text1, string text2)
        {
            return text1 + text2;
        }

        public string Concatenate(string text1, string text2, string text3)
        {
            return text1 + text2 + text3;
        }

        // ===== BÀI 4 =====
        public double Average(int[] arrNumber)
        {
            int sum = 0;

            for (int i = 0; i < arrNumber.Length; i++)
            {
                sum += arrNumber[i];
            }

            return (double)sum / arrNumber.Count();
        }

        // Chọn giá trị được chỉ định
        public double Average(int[] arrNumber, int value)
        {
            int sum = 0, count = 0;

            for (int i = 0; i < arrNumber.Length; i++)
            {
                if (value < arrNumber[i])
                {
                    sum += arrNumber[i];

                    // tăng count lên để lấy số lượng phần tử lớn hơn số chỉ định
                    count++;
                }    
            }

            return (double)sum / count;
        }

        // ===== BÀI 5 =====
        public int Convert(double a)
        {
            return (int)a;
        }

        // bool toString giúp C# phân biệt 2 method khác nhau
        public string Convert(double a, bool toString)
        {
            return a.ToString();
        }

        // ===== BÀI 6 =====
        //string → chuỗi ban đầu
        //startIndex → bắt đầu lấy từ vị trí nào
        //length → lấy bao nhiêu ký tự
        // Phương thức 1: Nhận chuỗi, vị trí bắt đầu và độ dài cần lấy.    
        // Lưu ý: length: là n - 1
        public string Substring(string text, int startIndex, int lenth)
        {
            return text.Substring(startIndex, lenth);
        }

        // Phương thức 2: Nhận chuỗi, vị trí bắt đầu và vị trí kết thúc.    
        public string Substring(string text, int startIndex, int endIndex, bool useEndIndex)
        {
            /* startIndex: Bắt đầu ở đâu?
             * endIndex: Kết thúc ở đâu?
             * endIndex - startIndex: Cần lấy bao nhiêu ký tự?*/
            return text.Substring(startIndex, endIndex - startIndex);
        }

        // ===== BÀI 7 =====
        public bool Compare(DateTime date1, DateTime date2)
        {
            if (date1 < date2)
                return true;
            else
                return false;
        }

        public double Compare(DateTime date1, DateTime date2, bool ex)
        {
            return (date2 - date1).TotalDays;
        }

        // ===== BÀI 8 =====
        public void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        public void Swap(int[] arr, int index1, int index2, int index3, int index4)
        {
            int temp = arr[index1];
            arr[index1] = arr[index3];
            arr[index3] = temp;

            int temp1 = arr[index2];
            arr[index2] = arr[index4];
            arr[index4] = temp1;
        }

        // ===== BÀI 9 =====
        // Thay thế tất cả các chuỗi con được chỉ định bằng một chuỗi thay thế.
        public string Replace(string text, string oldValue, string newValue)
        {
            return text.Replace(oldValue, newValue);
        }

        // Thay thế ký tự đầu tiên được chỉ định trong chuỗi bằng ký tự thay thế.
        public string Replace(string text, char oldChar, char newChar)
        {
            // Lấy vị trí của ký tự cần thay đổi
            int index = text.IndexOf(oldChar);

            // Tạo chuỗi đó thành mảng
            char[] chars = text.ToCharArray();

            // Thay thế ký tự đó từ vị trí cần thay đổi
            chars[index] = newChar;

            return new string(chars);
        }

        // ===== BÀI 10 =====
        public int Max(int[] arrNumber)
        {
            int max = arrNumber[0];

            foreach (var item in arrNumber)
            {
                if (max < item)
                {
                    max = item;
                }    
            }

            return max;
        }

        public int Max(int[] arrNumber, bool unUsed)
        {
            int max = arrNumber[0];
            int index = 0;

            for (int i = 0; i < arrNumber.Length; i++)
            {
                if (max < arrNumber[i])
                {
                    max = arrNumber[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
