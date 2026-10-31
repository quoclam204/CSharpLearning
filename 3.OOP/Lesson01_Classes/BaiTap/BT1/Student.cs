using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Student
    {
        // Khai báo thuộc tính
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Student()
        {
            firstName = "";
            lastName = "";
        }

        public Student(string firstName1)
        {
            firstName = firstName1;
        }

        public Student(string firstName1, string lastName1)
        {
            firstName = firstName1;
            lastName = lastName1;
        }

        public string GetFullName()
        {
            return firstName + " - " + lastName;
        }
    }
}
