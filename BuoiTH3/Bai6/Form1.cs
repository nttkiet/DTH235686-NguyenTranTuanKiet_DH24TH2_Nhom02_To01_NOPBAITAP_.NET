using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai6
{


    public partial class Form1 : Form
    {
        private ColorDialog colorDialog = new ColorDialog();
        private FontDialog fontDialog = new FontDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = txtnhap.Text.Trim();

            if (!string.IsNullOrEmpty(text))
            {
                lisname.Items.Add(text);  // Thêm text vào listBox1
                txtnhap.Clear();           // Xóa text trong TextBox sau khi thêm
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (lisname.SelectedIndex != -1)  // Kiểm tra có mục được chọn
                {
                    lisname.Items.RemoveAt(lisname.SelectedIndex);  // Xóa mục được chọn
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn mục muốn xóa!");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lisname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lisname.SelectedIndex != -1)  // Nếu có mục được chọn
            {
                textBox1.Text = lisname.SelectedItem.ToString();  // Hiển thị nội dung ra TextBox
            }
        }

        private void btnmauchu_Click_1(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void btnfontchu_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void btnnenmau_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
              {
                textBox1.BackColor = colorDialog.Color;
                }
        }
    }
}






   