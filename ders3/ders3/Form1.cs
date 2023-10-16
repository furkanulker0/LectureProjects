namespace ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, num3, result;
        private void btnMin_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtNum1.Text);
            txtNum1.Text = num1.ToString();
            num2 = Convert.ToInt32(txtNum2.Text);
            txtNum2.Text = num2.ToString();
            num3 = Convert.ToInt32(txtNum3.Text);
            txtNum3.Text = num3.ToString();

            if (num1 > num2 && num1 > num3)
            {
                result = num1;
                result = Convert.ToInt32(result);
                txtResult.Text = result.ToString();
            }
            else if (num2 > num3)
            {
                result = num2;
                result = Convert.ToInt32(result);
                txtResult.Text = result.ToString();
            }
            else
            {
                result = num3;
                result = Convert.ToInt32(result);
                txtResult.Text = result.ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtNum1.Text);
            txtNum1.Text = num1.ToString();
            num2 = Convert.ToInt32(txtNum2.Text);
            txtNum2.Text = num2.ToString();
            num3 = Convert.ToInt32(txtNum3.Text);
            txtNum3.Text = num3.ToString();

            if (num1 < num2 && num1 < num3)
            {
                result = num1;
                result = Convert.ToInt32(result);
                txtResult.Text = result.ToString();
            }
            else if (num2 < num3)
            {
                result = num2;
                result = Convert.ToInt32(result);
                txtResult.Text = result.ToString();
            }
            else
            {
                result = num3;
                result = Convert.ToInt32(result);
                txtResult.Text = result.ToString();
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtNum1.Text);
            txtNum1.Text = num1.ToString();
            num2 = Convert.ToInt32(txtNum2.Text);
            txtNum2.Text = num2.ToString();
            num3 = Convert.ToInt32(txtNum3.Text);
            txtNum3.Text = num3.ToString();

            result = (num1 + num2 + num3) / 3;
            result = Convert.ToInt32(result);
            txtResult.Text = result.ToString();
        }
    }
}