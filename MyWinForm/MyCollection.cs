using System;
using System.Collections;
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
    public partial class MyCollection : Form
    {
        public MyCollection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i.ToString());
            }
            foreach (string item in list)
            {
                listBox1.Items.Add(item);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add("123");
            list.Add(123);
            list.Add(new object());            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            for (int i = 0; i < 10; i++)
            {
                if(!dic1.ContainsKey(i.ToString()))
                    dic1.Add(i.ToString(), i.ToString());
            }
            if (!dic1.ContainsKey("5"))
                dic1.Add("5", "456654564");


            Dictionary<string, List<ClassForList>> dic2 = new Dictionary<string, List<ClassForList>>();


            List<ClassForList> list1 = new List<ClassForList>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(new ClassForList { param= i.ToString(), value = i.ToString() });
            }
            list1.Add(new ClassForList { param = "5", value = "5" });

            foreach (var item in list1)
            {
                listBox1.Items.Add($"{item.param} - {item.value}");
            }


        }
    }

    class ClassForList
    {
        public string param { get; set; }
        public string value { get; set; }
    }
}
