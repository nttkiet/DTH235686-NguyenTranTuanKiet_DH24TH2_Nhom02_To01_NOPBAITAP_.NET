namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tinhtoan_Click(object sender, EventArgs e)
        {
            

        }
        

        private void tong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(texta.Text);
            int b = int.Parse(txtb.Text);
            int tong = a + b;
            txtkq.Text = tong.ToString();
        }
        private void hieu_Click(object sender, EventArgs e)
        {
            int a = int.Parse(texta.Text);
            int b = int.Parse(txtb.Text);
            int hieu = a - b;
            txtkq.Text = hieu.ToString();
        }
        private void tich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(texta.Text);
            int b = int.Parse(txtb.Text);
            int tich = a * b;
            txtkq.Text = tich.ToString();
        }
        private void thuong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(texta.Text);
            int b = int.Parse(txtb.Text);
            if (int.Parse(txtb.Text) == 0)
            {
                MessageBox.Show("Khong the chia cho 0");
            }
            else
            {
                float thuong = a / b;
                txtkq.Text = thuong.ToString();
            }
        }
    }
}
