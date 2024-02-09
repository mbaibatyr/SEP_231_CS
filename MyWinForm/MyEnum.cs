using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class MyEnum : Form
    {
        List<Pupil> pupils = new List<Pupil>()
        {
            new Pupil(){id=1, lastName="ivanov", firstName="sergey"},
            new Pupil(){id=2, lastName="petrov", firstName="artem"},
            new Pupil(){id=3, lastName="sidorov", firstName="alex"}

        };

        (string, string) getNameById(int id)
        {
            var lastName = pupils.Where(z => z.id == id).FirstOrDefault().lastName;
            var firstName = pupils.Where(z => z.id == id).FirstOrDefault().firstName;
            return (lastName, firstName);
        }

        void getName((string ln, string fn) parameter)
        {
            MessageBox.Show(parameter.Item1 + " " + parameter.Item2);
        }

        void getName2(Tuple<string, string> parameter)
        {
            MessageBox.Show(parameter.Item1 + " " + parameter.Item2);
        }

        void getReverseList(Tuple<int, int> parameter)
        {
            for (int i = parameter.Item2; i >= parameter.Item1; i--)
            {
                listBox1.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = getNameById(Convert.ToInt32(comboBox1.Text));
            MessageBox.Show(result.Item1 + " " + result.Item2);
        }
        public MyEnum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.TabStop
            DateTime dt = DateTime.Now;
            var dw = dt.DayOfWeek;


            ;
            Pupil pupil = new Pupil()
            {
                id = 1,
                lastName = "Ivanov",
                gender = Gender.female,
                nationality = "kazah"
            };

            int id = (int)pupil.gender;
            Text = id.ToString() + " " + pupil.gender;

            if (pupil.gender > Gender.male)
                ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getName(("hello", "step"));
            getName2(new Tuple<string, string>("hello", "step"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getReverseList(new Tuple<int, int>(1, 10));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Users\байбатыровм\source\repos\SEP_231_CS\MyLib2\bin\Debug\net6.0\MyLib2.dll");
            //foreach (var item in assembly.GetTypes().Where(z => z.IsClass))
            //{
            //    if (item.Name != "MyClass2")
            //        continue;
            //    listBox1.Items.Add(item.Name);
            //    foreach (var item2 in item.GetConstructors())
            //    {
            //        listBox1.Items.Add("     " + item2.Name);
            //    }
            //    foreach (var item2 in item.GetMembers())
            //    {
            //        listBox1.Items.Add("     " + item2.Name);
            //    }
            //    foreach (var item2 in item.GetMethods())
            //    {
            //        listBox1.Items.Add("     " + item2.Name);
            //    }
            //}

            Type type = assembly.GetType("MyLib2.MyClass2");
            MethodInfo Hello = type.GetMethod("Hello");
            object[] Name = { "STEP 2024" };
            var instance = Activator.CreateInstance(type);
            var result = Hello.Invoke(instance, Name);
            MessageBox.Show(result.ToString());
        }
    }



    public enum Gender
    {
        male = 100,
        female
    }

    public enum Status
    {
        OK = 1,
        WARNING = 2,
        ERROR = 3,
        CRITICAL = 4
    }

    public class StatusResult
    {
        public string result { get; set; }
        public string error { get; set; }
        public Status status { get; set; }
    }


    public class Pupil
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string nationality { get; set; }
        public Gender gender { get; set; }
    }
}
