using Newtonsoft.Json;
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
    public partial class MyJson : Form
    {
        public MyJson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Root tmp = JsonConvert.DeserializeObject<MyData>(json);
        }
    }


    public class Root
    {
        public string status { get; set; }
        public MyData[] data { get; set; }
        public string message { get; set; }
    }

    public class MyData
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
    }


}
