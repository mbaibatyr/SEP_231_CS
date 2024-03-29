﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("select id, name, population from city", db))
            {
                var dr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("id;name;population");
                while (dr.Read())
                {
                    sb.AppendLine($"{dr[0].ToString()};{dr[1].ToString()};{dr[2].ToString()}");
                    listBox1.Items.Add(dr[1].ToString());
                }
                File.WriteAllText("city.csv", sb.ToString(), Encoding.UTF8);               
            }
        }
    }
}
