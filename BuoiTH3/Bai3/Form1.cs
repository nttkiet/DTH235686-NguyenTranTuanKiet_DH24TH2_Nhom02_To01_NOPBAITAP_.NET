namespace Bai3
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

        private void btnok_Click(object sender, EventArgs e)
        {

            this.txtkq.Text = "Bạn đã chọn website ";
            this.txtkq.Text += this.lstname.SelectedItems[0].Text;
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }
        private void txtkq_TextChanged(object sender, EventArgs e)
        {
            this.txtkq.Clear();
        }
        
            private void txtkq_TextChanged_1(object sender, EventArgs e)
        {

        }
       
        }
    }
