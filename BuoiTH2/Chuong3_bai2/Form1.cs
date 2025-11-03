namespace Chuong_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnname_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtthang.Text);
            switch (x)
            {
                case 1:
                case 2:
                case 3:
                    MessageBox.Show("Mùa Xuân");
                    break;
                case 4:
                case 5:
                case 6:
                    MessageBox.Show("Mùa Hạ");
                    break;
                case 7:
                case 8:
                case 9:
                    MessageBox.Show("Mua Thu");
                    break;
                case 10:
                case 11:
                case 12:
                    MessageBox.Show("Mùa Đông");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
