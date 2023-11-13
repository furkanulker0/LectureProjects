namespace FamilyTree
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private string[] mothersString = new string[1];
        private string[][] childrensString = new string[1][];


        private void btnAdd_Click(object sender, EventArgs e)
        {
            mothersString[0] = textBox1.Text;

            List<string> childData = new List<string>();

            AddChildDataToList(childData, textBox2.Text, textBox7.Text);
            AddChildDataToList(childData, textBox3.Text, textBox8.Text);
            AddChildDataToList(childData, textBox4.Text, textBox9.Text);
            AddChildDataToList(childData, textBox5.Text, textBox10.Text);
            AddChildDataToList(childData, textBox6.Text, textBox11.Text);

            childrensString[0] = childData.ToArray();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox7.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
            textBox4.Text = "";
            textBox9.Text = "";
            textBox5.Text = "";
            textBox10.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";


        }

        private void AddChildDataToList(List<string> childData, string childName, string childAge)
        {
            if (!string.IsNullOrWhiteSpace(childName))
            {
                childData.Add(childName);
                childData.Add(childAge);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = textBox12.Text;


            int index = Array.IndexOf(mothersString, searchName);

            if (index != -1)
            {

                string[] childData = childrensString[index];


                listBox1.Items.Clear();

                for (int i = 0; i < childData.Length; i += 2)
                {
                    string childName = childData[i];
                    string childAge = childData[i + 1];
                    listBox1.Items.Add($"Child: {childName}, Age: {childAge}");
                }
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show($"There is no mother with name -{textBox12.Text}-");
            }

            textBox12.Text = "";
        }

        
    }

        
}
