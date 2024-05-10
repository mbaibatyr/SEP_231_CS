using MyWinForm.Paterns;
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
    public partial class MySingleton : Form
    {
        public MySingleton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCity myCity = MyCity.CreateOrGetInstanse();

            foreach (var item in MyCity.lst)
            {
                listBox1.Items.Add($"{item.Id} - {item.Name}");
            }           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyCity myCity = MyCity.CreateOrGetInstanse(4, "Aktobe");            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in MyCity.lst)
            {
                listBox1.Items.Add($"{item.Id} - {item.Name}");
            }
        }
    }
}
