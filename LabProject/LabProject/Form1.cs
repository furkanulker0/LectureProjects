namespace LabProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string checkbox = checkBox1.Checked ? "Registered" : "Unregistered";
            
            ListViewItem newitem = new ListViewItem(txtNo.Text);
            if (checkbox == "Registered")
            {
                newitem.Checked = true;
            }
            if (comboBox2.Text == "UNDERGRADUATE")
            {
                newitem.ImageIndex = 0;
            }
            newitem.SubItems.Add(txtName.Text);
            newitem.SubItems.Add(txtAge.Text);
            newitem.SubItems.Add(comboBox1.Text);
            newitem.SubItems.Add(comboBox2.Text);
            newitem.SubItems.Add(checkBox1.Text);
            listView1.Items.Add(newitem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("STUDENT NO", 130);
            listView1.Columns.Add("NAME", 140);
            listView1.Columns.Add("AGE", 80);
            listView1.Columns.Add("GENDER", 80);
            listView1.Columns.Add("DEGREE", 140);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}