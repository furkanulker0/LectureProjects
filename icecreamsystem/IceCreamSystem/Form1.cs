using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace IceCreamSystem
{
    public partial class Form1 : Form
    {

        string icecream;
        string extra;
        double unitPrice;
        double unitCalorie;
        double lemonPrice;
        double bananaPrice;
        double chocPrice;
        double strawbPrice;
        int lemonCal;
        int chocCal;
        int strawbCal;
        int bananaCal;
        int lemonPiece;
        int chocPiece;
        int strawbPiece;
        int bananaPiece;
        int nutcalorie;
        int amount;
        string selectedNut;
        string selectedAddition;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);  //Formun keydown olayýna abone olmak için

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {


            selectedAddition = string.Join(", ", checkedListBox1.CheckedItems.OfType<string>());

            ListViewItem newitem = new ListViewItem(icecream);
            newitem.SubItems.Add(selectedAddition);
            newitem.SubItems.Add(selectedNut);
            newitem.SubItems.Add(unitPrice.ToString());
            newitem.SubItems.Add(unitCalorie.ToString());
            newitem.SubItems.Add(amount.ToString());
            newitem.SubItems.Add(txtTotal.Text);
            listView1.Items.Add(newitem);

            btnInsert.Enabled = false;

            UpdateGrandPrice();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            milktypeGroup.Enabled = false;
            additionGroup.Enabled = false;
            extraGroup.Enabled = false;
            caloripriceGroup.Enabled = false;
            btnDelete.Enabled = false;
            dietRadio.CheckedChanged += milkRadioControl;
            lowfatRadio.CheckedChanged += milkRadioControl;
            fatRadio.CheckedChanged += milkRadioControl;
            numerBanana.Enabled = false;
            numerChoc.Enabled = false;
            numerLem.Enabled = false;
            numerStraw.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            pictureBox1.Image = ýmageList1.Images[0];
            pictureBox2.Image = ýmageList1.Images[1];
            pictureBox3.Image = ýmageList1.Images[2];
            pictureBox4.Image = ýmageList1.Images[3];

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            icecream = "Diet";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            icecream = "Low Fat";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            icecream = "Fat";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            UpdateGrandPrice();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string[] words = textBox.Text.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (!string.IsNullOrEmpty(words[i]))
                    {
                        char[] letters = words[i].ToCharArray();
                        if (letters.Length > 0)
                        {
                            letters[0] = char.ToUpper(letters[0]);
                            words[i] = new string(letters);
                        }
                    }
                }

                textBox.Text = string.Join(" ", words);
                textBox.SelectionStart = textBox.Text.Length;
            }

            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtAddress.Text))
            {
                milktypeGroup.Enabled = true;
            }
            else
            {
                milktypeGroup.Enabled = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuþunun varsayýlan iþlenmesini devre dýþý býrak
                txtAddress.Focus(); // Ýkinci TextBox'e odaklan
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void milkRadioControl(object sender, EventArgs e)
        {
            if (dietRadio.Checked || lowfatRadio.Checked || fatRadio.Checked)
            {
                extraGroup.Enabled = true;
                additionGroup.Enabled = true;
                caloripriceGroup.Enabled = true;
            }
        }

        private void caloriesandprices(object sender, EventArgs e)
        {
            if (dietRadio.Checked)
            {
                lemonCal = 115;
                bananaCal = 175;
                strawbCal = 135;
                chocCal = 235;

                lemonPrice = 0.25;
                bananaPrice = 0.55;
                strawbPrice = 0.75;
                chocPrice = 0.80;
            }

            else if (lowfatRadio.Checked)
            {
                lemonCal = 125;
                bananaCal = 325;
                strawbCal = 225;
                chocCal = 340;

                lemonPrice = 0.35;
                bananaPrice = 0.65;
                strawbPrice = 0.85;
                chocPrice = 0.90;
            }

            else if (fatRadio.Checked)
            {
                lemonCal = 175;
                bananaCal = 365;
                strawbCal = 280;
                chocCal = 400;

                lemonPrice = 0.40;
                bananaPrice = 0.80;
                strawbPrice = 0.85;
                chocPrice = 1.00;
            }

            lemonPiece = (int)numerLem.Value;
            bananaPiece = (int)numerBanana.Value;
            strawbPiece = (int)numerStraw.Value;
            chocPiece = (int)numerChoc.Value;

            unitCalorie = (lemonPiece * lemonCal) + (bananaPiece * bananaCal) + (strawbPiece * strawbCal) +
                (chocPiece * chocCal);
            unitPrice = (lemonPiece * lemonPrice) + (bananaPiece * bananaPrice) + (strawbPiece * strawbPrice) +
                (chocPiece * chocPrice);

            txtUnitPrice.Text = unitPrice.ToString();
            txtUnitCalori.Text = unitCalorie.ToString();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    numerLem.Enabled = (e.NewValue == CheckState.Checked);
                    numerLem.Value = 0;
                    pictureBox4.Visible = true;
                    break;

                case 1:
                    numerBanana.Enabled = (e.NewValue == CheckState.Checked);
                    numerBanana.Value = 0;
                    pictureBox2.Visible = true;
                    break;

                case 2:
                    numerStraw.Enabled = (e.NewValue == CheckState.Checked);
                    numerStraw.Value = 0;
                    pictureBox1.Visible = true;
                    break;

                case 3:
                    numerChoc.Enabled = (e.NewValue == CheckState.Checked);
                    numerChoc.Value = 0;
                    pictureBox3.Visible = true;
                    break;

                default:
                    break;
            }

            if (listView1.SelectedItems.Count > 0)
            {
                string selectedAddition = string.Join(", ", checkedListBox1.CheckedItems.OfType<string>());
                listView1.SelectedItems[0].SubItems[1].Text = selectedAddition;
            }
        }

        private void extras(object sender, EventArgs e)
        {
            if (peanutRadio.Checked)
            {
                nutcalorie = 30;
                selectedNut = "PeaNut";
            }

            else if (hazelnutRadio.Checked)
            {
                nutcalorie = 45;
                selectedNut = "HazelNut";
            }

            else if (antepnutRadio.Checked)
            {
                nutcalorie = 75;
                selectedNut = "AntepNut";
            }

            int unitCalorieMat = int.Parse(txtUnitCalori.Text);

            txtUnitCalori.Text = (nutcalorie + unitCalorieMat).ToString();


        }

        private void amountt(object sender, EventArgs e)
        {
            amount = (int)numerAmount.Value;
            double unitPriceMat = double.Parse(txtUnitPrice.Text);
            txtTotal.Text = (unitPriceMat * amount).ToString();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {

            additionGroup.Enabled = false;
            extraGroup.Enabled = false;
            caloripriceGroup.Enabled = false;
            btnDelete.Enabled = false;
            numerAmount.Value = 0;
            txtTotal.Text = string.Empty;
            hazelnutRadio.Checked = false;
            peanutRadio.Checked = false;
            antepnutRadio.Checked = false;
            dietRadio.Checked = false;
            lowfatRadio.Checked = false;
            fatRadio.Checked = false;
            btnInsert.Enabled = true;

            checkedListBox1.ClearSelected();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtTotal.Text = string.Empty;

            milktypeGroup.Enabled = false;
            additionGroup.Enabled = false;
            extraGroup.Enabled = false;
            caloripriceGroup.Enabled = false;
            btnDelete.Enabled = false;
            numerAmount.Value = 0;
            listView1.Items.Clear();
            hazelnutRadio.Checked = false;
            peanutRadio.Checked = false;
            antepnutRadio.Checked = false;
            dietRadio.Checked = false;
            lowfatRadio.Checked = false;
            fatRadio.Checked = false;
            btnInsert.Enabled = true;
            txtGrandTotal.Text = string.Empty;

            checkedListBox1.ClearSelected();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void UpdateGrandPrice()
        {
            double grandPrice = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                double itemTotalPrice;
                if (double.TryParse(item.SubItems[6].Text, out itemTotalPrice))
                {
                    grandPrice += itemTotalPrice;
                }
            }

            txtGrandTotal.Text = grandPrice.ToString();
        }

    }
}