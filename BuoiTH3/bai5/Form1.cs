namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int TimMax(int so1, int so2)
        {
            if (so1 < so2)
                return so1;
            else
                return so2;
        }
        //phuong thuc tim uoc chung cua 2 so  
        public string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            string chuoi = "";
            for (int i = 1; i <= max; i++)
                if ((a % i == 0) && (b % i == 0))
                    chuoi += " " + i.ToString();
            return chuoi;
        }
        //phuong thuc tim UCLN cua 2 so  
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        private void txtnhapn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int a, b;

            a = int.Parse(this.txtnhapn.Text);
            b = int.Parse(this.txtnhapm.Text);
            if (this.ckucchung.Checked == true)
                this.txtkq.Text = TimUocChung(a, b);
            if (this.cklon.Checked == true)
                this.txtkq.Text = timUCLN(a, b).ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.txtnhapn.Clear();
            this.txtnhapm.Clear();
            this.txtkq.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
