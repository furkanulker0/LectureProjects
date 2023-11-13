namespace FractionAdder
{
    public partial class FRACTIONS : Form
    {
        public FRACTIONS()
        {
            InitializeComponent();
        }

        double x1, x2, x3, x4, x5;
        string x6;
        double  deciresult;
        string fracresult;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(txtIlkPay.Text);
            x2 = Convert.ToInt32(txtIlkPayda.Text);
            x3 = Convert.ToInt32(txtIkýPay.Text);
            x4 = Convert.ToInt32(txtIkýPayda.Text);
            x5 = Convert.ToInt32(x1+x3);

            deciresult = (x1 / x2) + (x3 / x4);

            txtDres.Text = deciresult.ToString();

            if (x2 == x4)
            {

                fracresult = ($"{x5}/{x2}");
                txtFres.Text = fracresult.ToString();

            }
            else
            {
                fracresult = ("Paydalar Eþit Deðil!");
                txtFres.Text = fracresult.ToString();

            }
            
        }
    }
}