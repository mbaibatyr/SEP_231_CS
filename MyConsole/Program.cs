using System.Text;
using Microsoft.Extensions.Configuration;
using Serilog.Core;
using Serilog;

namespace MyConsole
{
    internal class Program
    {
        static IConfigurationRoot config;
        static Logger logger;
        static void Main(string[] args)
        {
            config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            logger = new LoggerConfiguration()
             .WriteTo.File("logs\\" + DateTime.Now.ToString("dd.MM.yyyy") + ".log",
                 outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
             .CreateLogger();


            Console.WriteLine(config["param1"]);


            //DateTime dtBegin = new DateTime(2024, 1, 1);
            //DateTime dtEnd = new DateTime(2025, 1, 1);
            //int index = 1;
            //while (true)
            //{
            //    Console.WriteLine($"{index++}. {dtBegin}");
            //    dtBegin = dtBegin.AddDays(1);
            //    if (dtEnd <= dtBegin)
            //        break;
            //}

            //DateTime dtCur = DateTime.Now.AddDays(1);
            //DateTime dtFirstMonth = new DateTime(dtCur.Year, dtCur.Month, 1);
            //Console.WriteLine(dtFirstMonth);
            //Console.WriteLine(dtCur.DayOfWeek);
            //Console.WriteLine((int)dtCur.DayOfWeek);
            //DateTime dtPrev = new DateTime(2007, 10, 11);

            //var ts = dtCur - dtPrev;
            //Console.WriteLine((dtCur - dtPrev).TotalDays);

            //MyCLass myCLass = new MyCLass("hello step 111");
            //myCLass.Print();

            //MyCLass myCLass2 = new MyCLass();
            //myCLass2.Assign("hello step 222");
            //myCLass2.Print();

            //MyCLass2 myCLass2 = new MyCLass2();
            //Console.WriteLine(myCLass2.DoSquare(5));

            //MyCLass3 myCLass3 = new MyCLass3();
            //Console.WriteLine(myCLass3.DoSquare(5));


            //int sum;
            //double multyplay;
            //f_3(2, 10, out sum, out multyplay);
            //Console.WriteLine($"{sum} {multyplay}");

            //f_3(sum, sum, out sum, out multyplay);
            //Console.WriteLine($"{sum} {multyplay}");
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

    class MyCLass
    {
        const string st = "";
        private string Name { get; set; }
        public MyCLass()
        {}
        public MyCLass(string name)
        {
            Name = name;
        }
        public MyCLass(string name, string value)
        {
            Name = name;
        }
        public MyCLass(string name, int value)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }

        public void Assign(string name)
        {
            Name = name;            
        }
    }

    public interface IMove
    {
        void DoMove();
    }
    public interface IPrint
    {
        void DoPrint();
    }

    public interface IResult
    {
        double DoSquare(int value);
    }

    class MyCLass2 : MyCLass, IMove, IPrint, IResult
    {
        public void DoMove()
        {
            Console.WriteLine("MyCLass2 moved");
        }

        public void DoPrint()
        {
            Console.WriteLine("MyCLass2 printed");
        }

        public double DoSquare(int value)
        {
            return value * value;
        }
    }

    class MyCLass3 : IResult
    {
        public double DoSquare(int value)
        {
            return Math.Pow(value, 2);
        }
    }
}