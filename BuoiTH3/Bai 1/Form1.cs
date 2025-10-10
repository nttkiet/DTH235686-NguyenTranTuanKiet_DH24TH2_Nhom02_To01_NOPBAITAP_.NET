using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = (MessageBox.Show("Bạn có chắc chắn muốn dừng hay không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question));

            if (rs == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là:";
            thongbao += this.txtPass.Text;
            if (this.chkNho.Checked == true)
                thongbao += "\n\rBạn có ghi nhớ.";
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
          
            if (chkHienMatKhau.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
