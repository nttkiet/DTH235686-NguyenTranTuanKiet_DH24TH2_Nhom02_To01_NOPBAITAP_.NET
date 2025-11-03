using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.cblk.Items.Add("Tuổi trẻ");
            this.cblk.Items.Add("Thanh niên");
            this.cblk.Items.Add("VNExpress");
            this.cblk.Items.Add("Dân trí");
            this.cblk.Items.Add("Công an");
            this.cblk.Items.Add("24h");
            this.cblk.Items.Add("Zingme");
            this.cblk.Items.Add("Kênh 14");
            this.cblk.Items.Add("Sài Gòn Tiếp Thị");
            this.cblk.SelectedItem = "VNExpress";
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.txtkq.Text = "Bạn chọn web ";
            this.txtkq.Text += this.cblk.SelectedItem.ToString();

        }

        private void btnrelst_Click(object sender, EventArgs e)
        {
            this.cblk.SelectedItem = "VNExpress"; this.txtkq.Clear();
        }
    }
}
