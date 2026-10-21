using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBasic
{
    public class TreeOperations
    {
        // Thêm 1 nút con vào 1 nút
        public static void AddChill(Node parent, Node child)
        {
            parent.children.Add(child);
        }

        // Hàm in nút cha của mỗi nút
        public static void PrintParents(Node node, Node parent)
        {
            if (parent == null)
                Console.WriteLine(node.data + " -> NULL");
            else
                Console.WriteLine(node.data + " -> " + parent.data);

            foreach (var chill in node.children)
            {
                PrintParents(chill, node);
            }
        }

        // Hàm in nút con của mỗi nút
        public static void PrintChildren(Node node)
        {
            Console.Write(node.data + " -> ");
            foreach (var child in node.children)
                Console.Write(child.data + " ");
            Console.WriteLine();

            foreach (var child in node.children)
                PrintChildren(child);
        }

        // Hàm in nút lá (leaf nodes)
        public static void PrintLeafNodes(Node node)
        {
            if (node.children.Count == 0)
            {
                Console.Write(node.data + " ");
                return;
            }
            foreach (var child in node.children)
                PrintLeafNodes(child);
        }

        // Hàm in bậc của 1 nút (là dấu gạch)
        public static void PrintDegrees(Node node, Node parent)
        {
            int degree = node.children.Count;
            if (parent != null)
                degree++;
            Console.WriteLine(node.data + " -> " + degree);

            foreach (var child in node.children)
                PrintDegrees(child, node);
        }
    }
}
