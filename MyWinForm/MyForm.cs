using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class MyForm : Form
    {
        static IConfigurationRoot config;
        public MyForm()
        {
            InitializeComponent();
            config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = new SqlConnection(config["conStr"]))
            {
                db.Open();
                if (db.State == ConnectionState.Open)
                    MessageBox.Show("Connected");
                else                    
                    MessageBox.Show("Not connected");
                db.Close();
            }
        }
    }
}
