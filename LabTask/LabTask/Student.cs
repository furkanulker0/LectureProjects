using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    

    internal class Student
    {
        public int idNumber;
        public string name;
        public string surname;
        public int oopGrade;
        public int calculusGrade;
        public int dataStructureGrade;
        public int studentAvg;

    }
}

/*using System.Windows.Forms;

namespace LabTask
{
    public partial class Form1 : Form
    {
        private TextBox[] textBoxArray;
        private RichTextBox richTextBox1;

        public Form1()
        {
            InitializeComponent();

            textBoxArray = new TextBox[7];

            for (int i = 0; i < 7; i++)
            {
                textBoxArray[i] = new TextBox();
                textBoxArray[i].Location = new System.Drawing.Point(20, 20 + i * 30);
                this.Controls.Add(textBoxArray[i]);
            }

            rchTxtBox = new RichTextBox();
            rchTxtBox.Location = new System.Drawing.Point(20, 250);
            rchTxtBox.Size = new System.Drawing.Size(200, 100);
            this.Controls.Add(rchTxtBox);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string[] values = new string[7];
            for (int i = 0; i < 7; i++)
            {
                values[i] = textBoxArray[i].Text;
            }

            rchTxtBox.Clear();
            foreach (string value in values)
            {
                rchTxtBox.AppendText(value + Environment.NewLine);
            }


        }
    }
} */
