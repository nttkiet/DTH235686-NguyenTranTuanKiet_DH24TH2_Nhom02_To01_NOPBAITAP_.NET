namespace BuoiTH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        int sopt = 0;
        //CAC PHUONG THUC  
        //phuong thuc in mang  
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + "  ";
            return chuoi;
        }
        //phuong thuc tim max  
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        public void sochan()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                    chuoi += a[i] + " ";
            }
        }
        public void sole()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 != 0)
                    chuoi += a[i] + " ";
            }
        }
        //phuong thuc tinh trung binh  
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        //phuong thuc sap xep tang  
        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }
        public void SapXepGiam()
        {
            Array.Sort(a, 0, sopt);
            Array.Reverse(a, 0, sopt);
        }
        //phuong thuc tim UCLN cua 2 so  
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        //phuong thuc kiem tra so nguyen to  
        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }

        //phuong thuc dem SNT  
        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }
        //phuong thuc in SNT  
        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
            }
            return chuoi;
        }

        private void lblkq_Click(object sender, EventArgs e)
        {

        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++) ;
            if (this.sopt == a.Length)
            {
                this.txtnhap.Text = "\r";
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (this.txtnhap.Text == "")
                    MessageBox.Show("Hãy nhập phần tử nảng", "Thông báo");
                else
                {
                    a[sopt] = int.Parse(this.txtnhap.Text);
                    sopt++;
                    this.txtkq.Text += this.txtnhap.Text + " ";
                    this.txtnhap.Clear();
                    this.txtnhap.Focus();
                    if (sopt > 0)
                        this.btnin.Enabled = true;
                }
            }

        }
        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            //xuat cac phan tu co trong mnag  
            if (sopt == 0)
                txtkq.Text = "Mảng rỗng!";
            else
                txtkq.Text = "Các phần tử trong mảng là: \n\r" + InMang();

        }

        private void btntang_Click(object sender, EventArgs e)
        {

            if (sopt == 0)
                txtkq.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                this.txtkq.Text = "Đã sắp xếp mảng tăng dần";
            }
        }

        private void btnsonguyento_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtkq.Text = "Mảng rỗng!";
            else
                txtkq.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }

        private void btnucln_Click(object sender, EventArgs e)
        {
            txtkq.Text = "Ước chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " +
            timUCLN(a[0], a[1]).ToString();
        }

        private void btntrungbinh_Click(object sender, EventArgs e)
        {
            txtkq.Text = "Trung bình mảng là: " + TrungBinhMang().ToString();
        }

        private void btngiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtkq.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                this.txtkq.Text = "Đã sắp xếp mảng tăng dần";
            }
        }

        private void btntonghaimang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            txtkq.Text = "Tổng hai mảng là: " + sum.ToString();
        }

        private void btnlonnhat_Click(object sender, EventArgs e)
        {
            int max;
            if (sopt == 0)
                txtkq.Text = "Mảng rỗng!";
            else
            {
                max = TimMax();
                txtkq.Text = "Phần tử lớn nhất trong mảng là: " + max.ToString();
            }
        }

        private void btnsonhonhat_Click(object sender, EventArgs e)
        {
            int min;
            if (sopt == 0)
                txtkq.Text = "Mảng rỗng!";
            else
            {
                min = TimMin();
                txtkq.Text = "Phần tử nhỏ nhất trong mảng là: " + min.ToString();
            }
        }

        private void btndemsole_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
        }

        private void btndemsochan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 == 0)
                    dem++;
            }
        }
    }


}
