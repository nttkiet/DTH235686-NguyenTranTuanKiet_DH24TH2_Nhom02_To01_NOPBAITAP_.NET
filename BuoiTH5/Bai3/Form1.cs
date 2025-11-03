namespace Bai3
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txttu1.Text);
            int mau1 = int.Parse(txtmau1.Text);
            int tu2 = int.Parse(txttu2.Text);
            int mau2 = int.Parse(txtmau2.Text);

            txtkqtu.Text = (tu1 * mau2 + tu2 * mau1).ToString();
            txtkqmau.Text = (mau1 * mau2).ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txttu1.Text);
            int mau1 = int.Parse(txtmau1.Text);
            int tu2 = int.Parse(txttu2.Text);
            int mau2 = int.Parse(txtmau2.Text);

            txtkqtu.Text = (tu1 * mau2 - tu2 * mau1).ToString();
            txtkqmau.Text = (mau1 * mau2).ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txttu1.Text);
            int mau1 = int.Parse(txtmau1.Text);
            int tu2 = int.Parse(txttu2.Text);
            int mau2 = int.Parse(txtmau2.Text);

            txtkqtu.Text = (tu1 * tu2).ToString();
            txtkqmau.Text = (mau1 * mau2).ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txttu1.Text);
            int mau1 = int.Parse(txtmau1.Text);
            int tu2 = int.Parse(txttu2.Text);
            int mau2 = int.Parse(txtmau2.Text);

            txtkqtu.Text = (tu1 * mau2).ToString();
            txtkqmau.Text = (tu2 * mau1).ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
