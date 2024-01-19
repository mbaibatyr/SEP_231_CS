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
        SqlConnection db;
        public MyForm()
        {
            InitializeComponent();
            config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            db = new SqlConnection(config["conStr"]);
            db.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception err)
            {                
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Close();
        }
    }
}
