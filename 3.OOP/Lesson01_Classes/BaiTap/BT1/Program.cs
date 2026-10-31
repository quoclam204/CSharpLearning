namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            StudentManager studentManager = new StudentManager();

            // Nạp sinh viên vào danh sách sinh viên
            studentManager.AddStudent(new Student("Lâm", "Nguyễn"));
            studentManager.AddStudent(new Student("Khang", "Đặng"));
            studentManager.AddStudent(new Student("Tú", "Đỗ"));
            studentManager.AddStudent(new Student("Minh", "Lê"));
            studentManager.AddStudent(new Student("Thắng", "Nguyễn"));
            studentManager.AddStudent(new Student("Nguyễn", "Văn"));

            Console.WriteLine("Danh sách sinh viên: ");
            studentManager.DisplayStudentList();

            Console.WriteLine();

            studentManager.RemoveStudent("Nguyễn", "Văn");
            Console.WriteLine("Danh sách sinh viên sau khi xóa là: ");
            studentManager.DisplayStudentList();

            Console.WriteLine();
            studentManager.UpdateStudent("Lâm", "Nguyễn", "Lâm", "Quốc");
            Console.WriteLine("Danh sách sinh viên sau khi cập nhật là: ");
            studentManager.DisplayStudentList();

            Console.WriteLine();
            studentManager.SortStudent();
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp là: ");
            studentManager.DisplayStudentList();
        }
    }
}
