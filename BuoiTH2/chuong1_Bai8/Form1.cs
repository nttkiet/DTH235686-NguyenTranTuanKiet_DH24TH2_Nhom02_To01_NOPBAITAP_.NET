using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int sum;
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = sum.ToString();
        }

        private void btnhieu_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = hieu.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tich;
            tich = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox3.Text = tich.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            int thuong;
            thuong = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            textBox3.Text = thuong.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
