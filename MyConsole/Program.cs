using System.Text;

namespace MyConsole
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int sum;
            double multyplay;
            f_3(2, 10, out sum, out multyplay);
            Console.WriteLine($"{sum} {multyplay}");

            f_3(sum, sum, out sum, out multyplay);
            Console.WriteLine($"{sum} {multyplay}");
        }

        static void f_1(string st)
        {
            Console.WriteLine(st);
        }

        static void f_2(ref int i)
        {
            i += 10;
        }

        static void f_3(int a, int b, out int sum, out double multyplay)
        {
            sum = a + b;
            multyplay = a * b;
        }

        static void f_4(in int a, in int b, out int sum)
        {
            sum = a + b;            
        }

        static void f_5(string st) => Console.WriteLine("Hello " + st);
        static void f_6(string st)
        {
            Console.WriteLine("Hello " + st);
            // var result = "qweqeqe".Where(z => z.Equals("12"));
        }
        
    }

}