using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class StudentManager
    {
        // Tạo danh sách sinh viên để lưu các sinh viên
        // Nếu dùng public thì bên ngoài có thể tự ý thêm xóa sửa sinh viên được
        private List<Student> studentList = new List<Student>();

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public void RemoveStudent(string firstName, string lastName)
        {
            Student student = studentList.FirstOrDefault(
                s => s.firstName == firstName && s.lastName == lastName);

            if (student != null)
            {
                studentList.Remove(student);
                Console.WriteLine("Đã xóa: " + student.GetFullName());
            }    
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }    
        }

        public void UpdateStudent(string oldFitstName, string oldLastName, string newFirstName, string newLastName)
        {
            Student student = studentList.FirstOrDefault(
                s => s.firstName == oldFitstName && s.lastName == oldLastName);

            if (student != null)
            {
                student.firstName = newFirstName;
                student.lastName = newLastName;

                Console.WriteLine("Cập nhật sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }    
        }

        public void SortStudent()
        {
            studentList.Sort((a, b) => string.Compare(a.firstName, b.firstName));
        }
            
        public void DisplayStudentList()
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.GetFullName());
            }
        }
    }
}
