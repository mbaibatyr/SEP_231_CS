using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class MyDelegate : Form
    {
        public MyDelegate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lst;
            List<MyGeneric3<string>> lst2;

            List<List<MyGeneric3<string>>> lst3;


            //decimal cost = 10.12M;
            //MyGeneric generic = new MyGeneric(cost);
            //generic.Print();

            //string scost = "1500 тенге 50 тиын";
            //MyGeneric2 generic2 = new MyGeneric2(scost);
            //generic2.Print();

            //object unknown = 100;
            //if (unknown.GetType() == typeof(decimal))
            //    ;

            decimal cost3 = 10.12M;
            MyGeneric3<decimal> generic3 = new MyGeneric3<decimal>(cost3);
            generic3.Print();

            string scost2 = "1500 тенге 50 тиын";
            MyGeneric3<string> generic4 = new MyGeneric3<string>(scost2);
            generic4.Print();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallDelegate(MyDelegate_1.Print, "123");
            CallDelegate(MyDelegate_1.Print2, "123");

            //MyDelegate_1.Print("step");
            //DelegatePrint del1 = new DelegatePrint(MyDelegate_1.Print);
            //del1("world1");

            //DelegatePrint del2 = MyDelegate_1.Print;
            //del2("world2");

            //DelegatePrint del3 = delegate (string name)
            //{
            //    MessageBox.Show($"Hello {name}");
            //};
            //del3("world3");

            //DelegatePrint del4 = (string name) =>
            //{
            //    MessageBox.Show($"Hello {name}");
            //};
            //del4("world4");

            //DelegatePrint del5 = MyDelegate_1.Print;
            //del5.Invoke("world5");
        }

        void CallDelegate(DelegatePrint del, string name)
        {
            del(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Text = comboBox1.SelectedIndex.ToString();
            //Math.Pow(2, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //List<string> lst = new List<string>();
            //var result = lst.Where(z => z.StartsWith("T"));
            ////MyAction.Print("hello", "step");
            //Text = MyAction.Print3("hell").ToString();

            var result = CallDelegate2(z => z.StartsWith("T"), new List<string>() { });

        }

        IEnumerable<string> CallDelegate2(Func<string, bool> func, List<string> lst)
        {
            return lst.Where(func);
        }

    }

    class MyAction
    {

        public static void Print(string st1, string st2)
        {
            Action<string, string> act1 = (a, b) =>
            {
                MessageBox.Show(a + " " + b);
            };
            act1(st1, st2);
        }
        public static string Print2(string st1, string st2)
        {
            Func<string, string, string> func1 = (a, b) =>
            {
                return a + " " + b;
            };
            return func1(st1, st2);
        }

        public static bool Print3(string st)
        {
            Predicate<string> pred1 = (a) =>
            {
                return a.Length > 5;
            };
            return pred1(st);
        }
    }


    delegate void DelegatePrint(string name);

    class MyDelegate_1
    {
        public static void Print(string name)
        {
            MessageBox.Show($"Hello {name}");
        }
        public static void Print2(string name)
        {
            MessageBox.Show($"Hello {name} Hello");
        }
    }



    public class Test
    {

    }

    public class Test2
    {

    }

    class MyGeneric3<T>
    {
        T cost;
        public MyGeneric3() { }
        public MyGeneric3(T Cost)
        {
            this.cost = Cost;
        }
        public void Print()
        {
            MessageBox.Show(cost.ToString());
        }
    }

    class MyGeneric
    {
        decimal cost;
        public MyGeneric() { }
        public MyGeneric(decimal Cost)
        {
            this.cost = Cost;
        }
        public void Print()
        {
            MessageBox.Show(cost.ToString());
        }
    }

    class MyGeneric2
    {
        string cost;
        public MyGeneric2() { }
        public MyGeneric2(string Cost)
        {
            this.cost = Cost;
        }
        public void Print()
        {
            MessageBox.Show(cost);
        }
    }

    public interface ITest<T>
    {
        void Print(T test);
    }

    class T1 : ITest<Test>
    {
        public void Print(Test test)
        {
            throw new NotImplementedException();
        }
    }

    class T2 : ITest<Test2>
    {
        public void Print(Test2 test)
        {
            throw new NotImplementedException();
        }
    }
}
