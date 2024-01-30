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
    public partial class MyLinq : Form
    {
        int[] arrayInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        List<Car> lstCar;
        string[] arrayString_1 = new string[] { "a", "b", "c" };
        string[] arrayString_2 = new string[] { "a", "b", "d", "e" };

        public MyLinq()
        {
            InitializeComponent();
            lstCar = new List<Car>()
            {
                new Car(){Model="Camry", Color="red", Cost=20000000},
                new Car(){Model="Tucson", Color="red", Cost=15000000},
                new Car(){Model="Tuareg", Color="Black", Cost=34000000}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var array_1 = arrayInt.Where(z => z >= 5 && z % 2 != 0);

            var array_2 = from arr in arrayInt
                          where arr >= 5
                          where arr % 2 != 0
                          select arr;

            //object ob = button1;
            //(ob as Button).Text = "";
            //((Button)ob).Text = "";


            foreach (int item in array_2)
            {
                lbLinq.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lstTemp = from c in lstCar
                          where c.Color == "red"
                          select c;

            var lstTemp2 = lstCar.Where(z => z.Color == "red");



            foreach (Car car in lstTemp2)
            {
                lbLinq.Items.Add($"{car.Model} {car.Color} {car.Cost}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lstTemp = from c in lstCar
                          where c.Color == "red"
                          where c.Cost > 18000000
                          select new
                          {
                              MyModelCost = c.Model.ToUpper() + " (" + c.Cost + ")",
                              MyColor = c.Color
                          };


            foreach (var item in lstTemp)
            {
                lbLinq.Items.Add($"{item.MyColor}  {item.MyModelCost}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var arrayTemp = arrayString_1.Concat(arrayString_2);
            //var arrayTemp = arrayString_1.Intersect(arrayString_2);
            //var arrayTemp = arrayString_1.Union(arrayString_2);
            //var arrayTemp = arrayString_1.Except(arrayString_2);
            var arrayTemp = arrayString_2.Except(arrayString_1);
            foreach (var item in arrayTemp)
            {
                lbLinq.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbLinq.Items.Add(arrayInt.Contains(5));

            foreach (var item in arrayInt.Where(z => z.Equals(5)))
            {
                lbLinq.Items.Add(item);
            }

            lbLinq.Items.Add(arrayInt.Where(z => z.Equals(5)).FirstOrDefault());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //lbLinq.Items.Add(arrayInt.Count());
            //lbLinq.Items.Add(arrayInt.Max());
            //lbLinq.Items.Add(arrayInt.Min());
            //lbLinq.Items.Add(arrayInt.Average());

            //foreach (var item in arrayInt.Reverse())
            //{
            //    lbLinq.Items.Add(item);
            //}

            //foreach (var item in arrayInt.OrderByDescending(z=>z))
            //{
            //    lbLinq.Items.Add(item);
            //}

            foreach (var item in arrayString_1.Concat(arrayString_2).Distinct())
            {
                lbLinq.Items.Add(item);
            }

            

        }
    }

    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Cost { get; set; }
    }
}
