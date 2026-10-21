using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBasic
{
    public class Node
    {
        public int data;
        public List<Node> children;

        public Node(int x)
        {
            data = x; // giá trị nút
            children = new List<Node>(); // danh sách các nút con
        }
    }
}
