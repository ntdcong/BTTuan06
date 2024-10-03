namespace TinhToanCongTru
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                double so1 = Convert.ToDouble(textBox1.Text);
                double so2 = Convert.ToDouble(textBox2.Text);

                // Thực hiện các phép tính
                double tong = so1 + so2;

                // Hiển thị kết quả
                label3.Text = $"Tổng: {tong}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                double so3 = Convert.ToDouble(textBox3.Text);
                double so4 = Convert.ToDouble(textBox4.Text);

                // Thực hiện các phép tính
                double hieu = so3 + so4;

                // Hiển thị kết quả
                label4.Text = $"Hiệu: {hieu}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }
    }
}
