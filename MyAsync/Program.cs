namespace MyAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");

            Parallel.Invoke(
                () =>
                {
                    Console.WriteLine("hello step 1");
                },
                () =>
                {
                    Console.WriteLine("hello step 2");
                },
                () =>
                {
                    Console.WriteLine("hello step 3");
                }
            );

            //Test1.MyPrint(1, 10);
            //Test1.MyPrint(10, 20);

            //var t1 = Task.Run(() => Test1.MyPrint(1, 10));
            //var t2 = Task.Run(() => Test1.MyPrint(10, 20));
            //var t3 = Task.Run(() => Test1.MyPrint(100, 120));

            //await Task.WhenAny(t1, t2, t3);

            Console.WriteLine("Finish");
        }
    }

    class Test1
    {
        public static void MyPrint(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }

        }
    }
}