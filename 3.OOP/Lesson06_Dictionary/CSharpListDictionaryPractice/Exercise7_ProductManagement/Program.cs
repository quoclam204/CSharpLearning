namespace Exercise7_ProductManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>()
            {
                { "Laptop", 15000000 },
                { "Mouse", 200000 },
                { "Keyboard", 500000 }
            };

            products.Add("Monitor", 20000000);

            Console.WriteLine("Danh sach san pham la: ");
            foreach (var item in products)
            {
                Console.WriteLine(item.Key + " " +  item.Value);
            }

            if (products.ContainsKey("Laptop"))
            {
                Console.WriteLine("Co laptop trong danh sach!");
            }
            else
                Console.WriteLine("Khong co laptop trong danh sach!");

            Console.WriteLine("Gia sna pham laptop luc dau la: " + products["Laptop"]);
            products["Laptop"] = 17000000;
            Console.WriteLine("Gia sau khi cap nhat: " + products["Laptop"]);

            products.Remove("Laptop");

            Console.WriteLine("Danh sach san pham sau khi xoa laptop la: ");
            foreach (var item in products)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            int sum = 0;
            foreach (var item in products)
            {
                sum += item.Value;
            }
            Console.WriteLine("Tong gia tri cua tat ca san pham la: " + sum);
        }
    }
}
