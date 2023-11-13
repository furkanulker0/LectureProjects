namespace StudentGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int midterm1;
        int final1;
        double resultmid;
        double resultfin;
        double score;
        Student student = new Student();
        
        private void button1_Click(object sender, EventArgs e)
        {
            student.Name = txtName.Text;
            student.Lastname = txtLastname.Text;

            midterm1 = Convert.ToInt32(txtMid.Text);
            final1 = Convert.ToInt32(txtFinal.Text);

            resultmid = (midterm1 * 4 ) / 10  ;
            resultfin = (final1 *6 ) / 10 ;

            score = resultfin + resultmid;
            

            MessageBox.Show($"{student.Name} {student.Lastname} adlý öðrencinin notu " +
                $"{score} ");
        }
    }
}