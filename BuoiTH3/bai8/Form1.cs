namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnchao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chao " + comboBox1.SelectedItem.ToString());
        }
    }
}
