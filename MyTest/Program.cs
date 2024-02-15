namespace MyTest
{
    public delegate string delegateSayHello(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            delegateSayHello delegate_1 = new delegateSayHello(SayHello);
            delegateSayHello delegate_2 = SayHello;

            delegateSayHello delegate_3 = delegate (string st)
            {
                return "Hello " + st + " step";
            };
            delegateSayHello delegate_4 = (st) => 
            {
                return "Hello " + st + " step Lambda";
            };

            Func<string, string> MyFunc = (st) =>
            {
                return "Hello " + st + " step FUNC";
            };

            Console.WriteLine(SayHelloFunc(MyFunc, "KZ"));

            //Console.WriteLine(MyFunc("world"));

        }

        static string SayHello(string name)
        {
            return "Hello " + name;
        }

        static string SayHelloFunc(Func<string, string> func, string name)
        {
            return func(name);
        }
    }
}