using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int chu_vi;
            chu_vi = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text))*2;
            textBox3.Text = chu_vi.ToString();
        }

        private void btnhieu_Click(object sender, EventArgs e)
        {
            int dientich;
            dientich = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox3.Text = dientich.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
                try
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double d = Math.Sqrt(a * a + b * b);
                    textBox3.Text = d.ToString();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ.");
                }
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
