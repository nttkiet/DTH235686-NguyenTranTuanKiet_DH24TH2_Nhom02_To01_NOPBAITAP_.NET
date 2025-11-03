namespace Chuong4_bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtn.Text);
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            txts.Text = gt.ToString();
        }
    }
}
