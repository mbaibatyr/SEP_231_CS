namespace MyGC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test3 test3 = new Test3();
            test3.Print();

            //Test1 test1 = new Test1();
            //test1.Print();
            //GC.Collect();
            //Console.ReadLine();

            //using (Test2 test2 = new Test2())
            //{
            //    test2.Print();
            //}

            //using (Test1 test1 = new Test1())
            //{
            //    test1.Print();
            //}

            //Test2 test2 = new Test2();
            //test2.Print();
            //test2.Dispose();

        }
    }

    class Test1
    {
        public void Print()
        {
            Console.WriteLine("hello STEP");
        }

        ~Test1()
        {
            Console.WriteLine("call destructor");
        }
    }

    class Test2 : IDisposable
    {
        public void Print()
        {
            Console.WriteLine("hello STEP");
        }
        public void Dispose()
        {
            Console.WriteLine("call Dispose");
        }
    }

    unsafe class Test3
    {
        public void Print()
        {
            int* i;
            int x = 50;
            i = &x;
            Console.WriteLine(x);
            Console.WriteLine(*i);
        }
    }

}