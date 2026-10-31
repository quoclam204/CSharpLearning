using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPractice
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ClassName { get; set; }
        public double GPA { get; set; }

        public Student()
        {

        }

        public Student(string studentID, string firstName, string lastName, DateTime dateOfBirth, string className, double gPA)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ClassName = className;
            GPA = gPA;
        }

        public string GetFullName()
        {
            return LastName + FirstName;
        }

        // protected
        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {StudentID} | First Name: {FirstName} | Last Name: {LastName} " +
                $"| Date of Birth: {DateOfBirth:dd/MM/yyyy} | Class Name: {ClassName} | GPA: {GPA}");
        }
    }
}
