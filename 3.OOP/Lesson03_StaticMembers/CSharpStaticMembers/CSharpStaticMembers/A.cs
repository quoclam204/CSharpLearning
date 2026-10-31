using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpStaticMembers
{
    sealed internal class A
    {
        public void NiemPhong()
        {
            Console.WriteLine("Lớp này là lớp niêm phong dùng để ngăn chặn kế thừa");
        }
    }
}
