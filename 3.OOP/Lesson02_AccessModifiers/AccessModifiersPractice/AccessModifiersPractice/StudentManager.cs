using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPractice
{
    internal class StudentManager //: Student
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(string studentId)
        {
            Student student = students.FirstOrDefault(s => s.StudentID == studentId);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Xóa sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên");
            }    
        }

        public void DisplayAllStudents()
        {
            foreach (Student student in students)
            {
                //DisplayInfo();
                student.DisplayInfo();
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            }
        }
    }   
}
