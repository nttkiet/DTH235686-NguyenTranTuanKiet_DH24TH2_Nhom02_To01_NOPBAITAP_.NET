namespace bai5
{
    public partial class Form1 : Form
    {
        int[] arr = new int[10];
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rd.Next(1, 100); // số ngẫu nhiên từ 1–99

            textBox1.Text = string.Join("  ", arr);
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tong = arr.Sum();
            textBox2.Text = "Tổng mảng = " + tong;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dem = arr.Count(x => x % 2 != 0);
            textBox2.Text = "Có " + dem + " phần tử lẻ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tongLe = arr.Where(x => x % 2 != 0).Sum();
            textBox2.Text = "Tổng giá trị phần tử lẻ = " + tongLe;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int min = arr.Min();
            textBox2.Text = "Phần tử nhỏ nhất = " + min;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] += 2;

            textBox1.Text = string.Join("  ", arr);
            textBox2.Text = "Đã tăng mỗi phần tử lên 2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            textBox1.Text = string.Join("  ", arr);
            textBox2.Text = "Đã sắp xếp tăng dần";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            textBox1.Text = string.Join("  ", arr);
            textBox2.Text = "Đã sắp xếp giảm dần";
        }
    }
}

