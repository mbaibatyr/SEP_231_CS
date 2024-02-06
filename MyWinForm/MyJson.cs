using Newtonsoft.Json;
using RestSharp;
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
            string json = File.ReadAllText(@"C:\Users\байбатыровм\Desktop\myjson.json");
            Root root = JsonConvert.DeserializeObject<Root>(json);

            listBox1.Items.Add($"{root.status}");
            foreach (var item in root.data)
            {
                listBox1.Items.Add($"{item.id} {item.employee_name} {item.employee_salary} {item.profile_image} {item.employee_age}");
            }
            listBox1.Items.Add($"{root.message}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://dummy.restapiexample.com/api/v1/employees");
            var request = new RestRequest("");
            var response = client.ExecuteGet(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Root root = JsonConvert.DeserializeObject<Root>(response.Content);

                listBox1.Items.Add($"{root.status}");
                foreach (var item in root.data)
                {
                    listBox1.Items.Add($"{item.id} {item.employee_name} {item.employee_salary} {item.profile_image} {item.employee_age}");
                }
                listBox1.Items.Add($"{root.message}");
            }
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
