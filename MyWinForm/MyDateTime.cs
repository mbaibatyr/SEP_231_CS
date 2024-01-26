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
    public partial class MyDateTime : Form
    {
        public MyDateTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbDate.Items.Add("01.01.2024");
            lbDate.Items.Add("02.01.2024");
            lbDate.Items.Add("...");
            lbDate.Items.Add("31.12.2024");

            //DateTime dt = null;
            DateTime? dt2 = null;
            DateTime dtBegin = DateTime.Now;
            DateTime dtEnd = DateTime.Now.AddHours(2).AddMinutes(3).AddSeconds(4);
            TimeSpan ts = dtBegin - dtEnd;
            //lbDate.Items.Add(ts.TotalDays);
            //lbDate.Items.Add((dtBegin - dtEnd).TotalDays);
            //lbDate.Items.Add($"{ts:hh\\:mm\\:ss}");

            //lbDate.Items.Add(dtEnd.Subtract(dtBegin));
            //lbDate.Items.Add(dt.AddYears(-1));

            //lbDate.Items.Add(dt.ToString("dd.MM.yyyy"));
            //lbDate.Items.Add(dt.ToString("dd.MM.yyyy HH"));
            //lbDate.Items.Add(dt.ToString("dd.MM.yyyy HH:mm:ss"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbDate.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            Student student = new Student();
            //student.course.teacher.address.street;
            //student?.course?.teacher?.address.street;
            if (student != null)
                student.id = "123";
            if (student is not null)
                student.id = "123";
            Text = student?.id;
            Text = student?.id ?? "123";
            Text = student?.id != null ? "123" : student?.id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbDate.Items.Add(DateTime.Today);
            lbDate.Items.Add(DateTime.Now.ToString("yyyy-MM-dd"));
            var week = (int)DateTime.Now.AddDays(1).DayOfWeek;
            lbDate.Items.Add(week);
        }
    }

    class Student
    {
        public string id { get; set; }
    }
}
