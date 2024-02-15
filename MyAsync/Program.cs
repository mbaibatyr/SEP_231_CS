namespace MyAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");

            //Parallel.Invoke(
            //    () =>
            //    {
            //        Console.WriteLine("hello step 1");
            //    },
            //    () =>
            //    {
            //        Console.WriteLine("hello step 2");
            //    },
            //    () =>
            //    {
            //        Console.WriteLine("hello step 3");
            //    }
            //);

            DateTime dt = DateTime.Now;
            //Test1.MyPrint(1, 5);
            //Test1.MyPrint(10, 20);
            //3,3288091

            var t1 = Task.Run(() => Test1.MyPrint(1, 5));
            var t2 = Task.Run(() => Test1.MyPrint(10, 20));
            
                        //var t3 = Task.Run(() => Test1.MyPrint(100, 120));

            //await Task.WhenAll(t1, t2);
            Console.WriteLine((DateTime.Now - dt).TotalSeconds);
            //2,2680787
            //Console.WriteLine("Finish");
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