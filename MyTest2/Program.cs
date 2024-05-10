namespace MyTest2
{
    public interface IPrinter
    {
        void Print(Report rep);
    }

    public class Report
    {
        public string Text { get; set; }
    }

    public class PScreen : IPrinter
    {
        public void Print(Report rep)
        {
            Console.WriteLine("screen");
        }
    }

    public class PFile : IPrinter
    {
        public void Print(Report rep)
        {
            Console.WriteLine("file");
        }
    }

    public class POutlook : IPrinter
    {
        public void Print(Report rep)
        {
            Console.WriteLine("Send mail");
        }
    }

    public class Call
    {
        IPrinter printer;
        Report rep;
        public Call(IPrinter printer, Report rep)
        {
            this.printer = printer;
            this.rep = rep;
        }
        public void Go()
        {
            printer.Print(rep);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Call call = new Call(new PScreen(), new Report() { Text = "MyRep"});
            Call call2 = new Call(new PFile(), new Report() { Text = "MyRepText2" });
            Call call3 = new Call(new POutlook(), new Report() { Text = "MyRepText2sdftsssdf" });
        }
    }

    class Turtle : IMove, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }


    public interface IMove
    {
        void Move();
    }

    public interface IEat
    {
        void Eat();
    }

    public interface IFly
    {
        void Fly();
    }



}
