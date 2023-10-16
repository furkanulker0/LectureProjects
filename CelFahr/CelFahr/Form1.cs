namespace CelFahr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deg1, deg2;
        private void button1_Click(object sender, EventArgs e)
        {
            deg1 = Convert.ToInt32(txtTemp.Text);
            txtTemp.Text = deg1.ToString();


            deg2 = Convert.ToInt32((deg1-32)/1.8);
            txtConTemp.Text = deg2.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deg1 = Convert.ToInt32(txtTemp.Text);
            txtTemp.Text = deg1.ToString();


            deg2 = Convert.ToInt32((deg1 / 1.8) + 32);
            txtConTemp.Text = deg2.ToString();
        }
    }
}