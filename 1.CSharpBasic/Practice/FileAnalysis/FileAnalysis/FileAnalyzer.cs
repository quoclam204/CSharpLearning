using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalysis
{
    public class FileAnalyzer
    {
        // Số ký tự
        public int CountCharacter(string content)
        {
            return content.Length;      
        }
       
        // Số dòng
        public int CountLines(string content)
        {
            string[] lines = content.Split("\n");
            return lines.Length;
        }

        // Số từ
        public int CountWords(string text)
        {
            string[] words = text.Split(
                (char[]?)null, // Tách theo mọi loại khoảng trắng \n \t và khoảng trắng
                StringSplitOptions.RemoveEmptyEntries // Bỏ các phần tử rỗng
            );
            return words.Length;
        }

        // Độ dài trung bình của từ
        public double AverageWordLength(string text)
        {
            // Tách từ và tạo thành mảng
            string[] words = text.Split(
                (char[]?)null, 
                StringSplitOptions.RemoveEmptyEntries 
            );

            if (words.Length == 0)
            {
                return 0;
            }    

            int totalLength = 0;

            // Tính tổng số ký tự của tất cả các từ
            foreach (var item in words)
            {
                totalLength += item.Length;
            }

            double average = (double)totalLength / words.Length; // Chia cho số từ có trong mảng

            return average;
        }
    }
}
