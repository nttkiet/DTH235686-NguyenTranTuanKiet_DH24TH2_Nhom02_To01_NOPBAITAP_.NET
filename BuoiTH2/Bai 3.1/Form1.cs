using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._1
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

        private void btnTinh_Click(object sender, EventArgs e)
        {
           float soX = float.Parse(txtSoX.Text);
            if (soX <= 1)
            {
                txtKetQua.Text= (7 * soX).ToString();

            }
            else if (soX >= 2)
            {
                txtKetQua.Text=((-8 * (soX * soX * soX)) - (12 * soX) - 1).ToString();
            }
            else
            {
                txtKetQua.Text=((soX * soX) - (6 * soX) - 19).ToString();
            }
        }
    }
}
