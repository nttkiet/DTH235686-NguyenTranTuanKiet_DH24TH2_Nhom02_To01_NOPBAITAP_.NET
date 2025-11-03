namespace Chuong4_bai3
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

        private void btntinh_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtn.Text);
            float s = 0;
            for(int i= 1;i<=n;i++)
            {
                s += 1f/ i;
            }
           txts.Text = s.ToString();
        }
    }
}
