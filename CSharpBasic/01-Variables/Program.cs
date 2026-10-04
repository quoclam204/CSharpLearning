using System.Text;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Person person1 = new Person();
            person1.Name = "Lâm";

            // person1 và person2 cùng trỏ tới một object trong bộ nhớ.
            Person person2 = person1;

            //Person person2 = new Person(); // tạo mới Person nên không cùng trỏ tới một object trong bộ nhớ.
            person2.Name = "Nguyễn"; // thay đổi giá trị trong object chứ không tạo Person mới

            Console.WriteLine(person1.Name);
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}
