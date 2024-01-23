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
            list.
        }
    }
}
