using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyIO = System.IO;

namespace MyWinForm
{
    public partial class MyFile : Form
    {
        const string Path = @"C:\Users\байбатыровм\Desktop\MyTest\";
        const string Path2 = "C:\\Users\\байбатыровм\\Desktop\\MyTest\\";
        public MyFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(Path + "file_1.txt", "привет СТЕП", Encoding.UTF8);
            //string[] array = new string[] { "hello step1", "hello step2"};
            //File.WriteAllLines(Path + "file_1.txt", array);
            byte[] data = Encoding.UTF8.GetBytes("hello world");
            File.WriteAllBytes(Path + "file_1.txt", data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] array = new string[] { "hello step1", "hello step2" };
            File.AppendAllLines(Path + "file_1.txt", array);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in File.ReadAllLines(Path + "file_1.txt"))
            {
                listBox1.Items.Add(item);
            }
            tbTest.Text = File.ReadAllText(Path + "file_1.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (var item in File.ReadAllLines(Path + "file_1.txt"))
            {
                i++;
                sb.AppendLine(item);
                if (i == 5)
                    sb.AppendLine("hello world");
            }
            File.WriteAllText(Path + "file_2.txt", sb.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path + "file_1.txt"))
                File.Delete(Path + "file_1.txt");
            //File.Copy(Path + "file_1.txt", Path + "file_2.txt", true);
            //File.Move(Path + "file_1.txt", Path + "123\\file_1.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(File.GetLastWriteTime(Path + "file_1.txt"));
            
            //FileInfo info = new FileInfo(Path + "file_1.txt");
            //listBox1.Items.Add(info.LastWriteTime);
            //listBox1.Items.Add(info.LastAccessTime);

            listBox1.Items.Add(MyIO.Path.GetExtension(Path + "file_1.txt"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.SetLastWriteTime(Path + "file_2.txt", DateTime.Now.AddDays(-2000));

            var days = (DateTime.Now - DateTime.Now.AddDays(-10)).Hours;
            

            //foreach (var item in Directory.GetFiles(Path, "*.csv"))
            //{
            //    //if(MyIO.Path.GetExtension(item) == ".csv")
            //        listBox1.Items.Add(MyIO.Path.GetFileName(item));
            //}
        }
    }
}
