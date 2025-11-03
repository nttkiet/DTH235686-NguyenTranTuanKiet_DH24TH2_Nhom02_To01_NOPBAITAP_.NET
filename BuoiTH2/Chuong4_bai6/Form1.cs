namespace Chuong4_bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtn.Text);
            float s = 0;
            for(int i=1;i<=n;i++)
            {
                s += 1 / (float)(2 * i - 1);
            }
            txts.Text = s.ToString();
        }
    }
}
