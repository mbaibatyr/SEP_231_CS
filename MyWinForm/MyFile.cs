using ClosedXML.Excel;
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
            FileInfo fi = new FileInfo(Path + "file_1.txt");
            Text = fi.Length.ToString();
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

        private void button8_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(Path + "city.csv");


            using (var wb = new XLWorkbook())
            {
                var ws = wb.AddWorksheet("report");
                ws.Cell(1, 1).Value = "id";
                ws.Cell(1, 2).Value = "name";
                ws.Cell(1, 3).Value = "country";

                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 2).Style.Font.Bold = true;
                ws.Cell(1, 3).Style.Font.Bold = true;
                ws.Cell(1, 3).Style.Font.FontColor = XLColor.Red;
                

                int row = 2;
                foreach (var item in lines.Skip(1))
                {
                    var array = item.Split(';');
                    for (int i = 1; i <= 3; i++)
                    {
                        ws.Cell(row, i).Value = array[i - 1];
                    }
                    row++;
                }

                ws.Column(3).AdjustToContents();

                wb.SaveAs(Path + "excel.xlsx");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.AddWorksheet("report");
                ws.Cell(1, 1).Value = "id";
                ws.Cell(1, 2).Value = "name";
                ws.Cell(1, 3).Value = "country";

                List<Data> list = new List<Data>()
                {
                    new Data{ Id="1", Name="Almaty", Country = "KZ"},
                    new Data{ Id="2", Name="Moscow", Country = "RU"},
                };

                ws.Cell(2, 1).InsertData(list);

                wb.SaveAs(Path + "excel2.xlsx");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var wb = new XLWorkbook(Path + "excel.xlsx"))
            {
                var ws = wb.Worksheet(1);
                var rows = ws.RangeUsed().RowsUsed().Skip(1);
                foreach (var row in rows)
                {
                    listBox1.Items.Add($"{row.Cell(1).Value} " +
                        $"{row.Cell(2).Value} " +
                        $"{row.Cell(3).Value} ");
                }
            }
        }
    }

    class Data
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

   
}
