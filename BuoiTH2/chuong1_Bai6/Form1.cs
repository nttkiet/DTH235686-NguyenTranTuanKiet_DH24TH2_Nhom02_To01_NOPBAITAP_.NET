using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int sum;
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show("Tong :" + sum.ToString());
        }

        private void btnhieu_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            MessageBox.Show("Hieu :" + hieu.ToString());
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tich ;
            tich = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            MessageBox.Show("Tich :" + tich.ToString());
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            int thuong;
            thuong = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            MessageBox.Show("Thuong :" + thuong.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txta_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
