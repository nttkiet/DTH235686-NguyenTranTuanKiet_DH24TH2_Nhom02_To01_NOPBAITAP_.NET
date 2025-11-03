namespace bai7
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có mảng!", "Lỗi");
                return;
            }

            if (int.TryParse(txtViTriThayThe.Text, out int vt) &&
                int.TryParse(txtSoThayThe.Text, out int so))
            {
                if (vt >= 0 && vt < arr.Length)
                {
                    arr[vt] = so;
                    txtketqua.Text = string.Join(" ", arr);
                }
                else
                {
                    MessageBox.Show("Vị trí không hợp lệ!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập số hợp lệ!", "Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtnhapmang.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập mảng số nguyên!", "Thông báo");
                return;
            }

            // Chuyển chuỗi thành mảng số nguyên
            arr = input.Select(ch => int.Parse(ch.ToString())).ToArray();

            // Hiển thị ra textbox kết quả
            txtketqua.Text = string.Join(" ", arr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có mảng! Hãy nhấn Xuất Mảng trước.", "Lỗi");
                return;
            }

            int tong = arr.Sum();
            int tongChan = arr.Where(x => x % 2 == 0).Sum();
            int tongLe = arr.Where(x => x % 2 != 0).Sum();

            txtTongMang.Text = tong.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có mảng!", "Lỗi");
                return;
            }

            int max = arr.Max();
            int min = arr.Min();

            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Chưa có mảng!", "Lỗi");
                return;
            }

            if (rdbTang.Checked)
                arr = arr.OrderBy(x => x).ToArray();
            else if (rdbGiam.Checked)
                arr = arr.OrderByDescending(x => x).ToArray();

            txtketqua.Text = string.Join(" ", arr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnhapmang.Clear();
            txtketqua.Clear();
            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtViTriThayThe.Clear();
            txtSoThayThe.Clear();
            arr = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
