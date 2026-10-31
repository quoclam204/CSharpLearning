namespace AccessModifiersPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            StudentManager studentManager = new StudentManager();

            studentManager.AddStudent(new Student("SV01", "Lâm", "Nguyễn", new DateTime(27/02/2004), "CTK46B", 2.0));
            studentManager.AddStudent(new Student("SV01", "Lâm", "Nguyễn", new DateTime(2004, 2, 27), "CTK46B", 2.0));
            studentManager.AddStudent(new Student("SV02", "Minh", "Trần", new DateTime(2003, 8, 15), "CTK46B", 3.5));
            studentManager.AddStudent(new Student("SV03", "Anh", "Lê", new DateTime(2004, 5, 10), "CTK46A", 3.2));
            studentManager.AddStudent(new Student("SV04", "Hùng", "Phạm", new DateTime(2003, 11, 20), "CTK46C", 2.8));

            Console.WriteLine("Danh sách sinh viên là: ");
            studentManager.DisplayAllStudents();


        }
    }
}
