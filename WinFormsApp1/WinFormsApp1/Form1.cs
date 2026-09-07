namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassWord.Clear();
            txtHienThi.Clear();
            txtPassWord.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtPassWord.Text;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
