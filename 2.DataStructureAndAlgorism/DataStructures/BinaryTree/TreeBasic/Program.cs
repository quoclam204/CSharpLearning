namespace TreeBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Node root = new Node(6);
            Node n2 = new Node(3);
            Node n3 = new Node(5);
            Node n4 = new Node(2);
            Node n5 = new Node(0);
            Node n6 = new Node(1);

            TreeOperations.AddChill(root, n2);
            TreeOperations.AddChill(root, n3);
            TreeOperations.AddChill(n2, n4);
            TreeOperations.AddChill(n4, n6);
            TreeOperations.AddChill(n3, n5);

            Console.WriteLine("Prents of each node: ");
            TreeOperations.PrintParents(root, null);

            Console.WriteLine("Children of each node:");
            TreeOperations.PrintChildren(root);

            // Nút không có con
            Console.WriteLine("Leaf nodes: ");
            TreeOperations.PrintLeafNodes(root);

            // Dấu gạch của mỗi nút
            Console.WriteLine("Degrees of nodes:");
            TreeOperations.PrintDegrees(root, null);
        }
    }
}
