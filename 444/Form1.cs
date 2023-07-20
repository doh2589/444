using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _444
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int price;
            int NetPrice;
            float discount;

            price = Convert.ToInt16(textBox1.Text);
            discount = Convert.ToInt16(textBox2.Text);
            NetPrice = price - discount;


            if (price >= 0 && price <= 499)
            {
                discount = 0;
            }
            else if (price >= 500 && price <= 1000)
            {
                discount = (price * 5) / 100;
            }
            else if (price >= 1000 && price <= 5000)
            {
                discount = (price * 10) / 100;
            }
            else
            {
                discount = (price * 20) / 100;
            }

            NetPrice = price - discount;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
