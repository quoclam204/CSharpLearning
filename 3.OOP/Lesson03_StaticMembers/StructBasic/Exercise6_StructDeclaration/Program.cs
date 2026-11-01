namespace Exercise6_StructDeclaration
{
    struct NewStruct
    {
        private int num;

        public int n
        {
            get { return num; }

            set
            {
                if (value < 50)
                    num = value;
            }
        }

        public void ClsMethod()
        {
            Console.WriteLine("Gia tri duoc luu giu la: {0}\n", num);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NewStruct myInstance = new NewStruct();

            myInstance.n = 20;
            myInstance.ClsMethod();
        }
    }
}
