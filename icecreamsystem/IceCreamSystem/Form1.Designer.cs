namespace IceCreamSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            checkedListBox1 = new CheckedListBox();
            numerLem = new NumericUpDown();
            numerBanana = new NumericUpDown();
            numerStraw = new NumericUpDown();
            numerChoc = new NumericUpDown();
            antepnutRadio = new RadioButton();
            hazelnutRadio = new RadioButton();
            peanutRadio = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtUnitPrice = new TextBox();
            txtUnitCalori = new TextBox();
            txtTotal = new TextBox();
            numerAmount = new NumericUpDown();
            listView1 = new ListView();
            clmIceCream = new ColumnHeader();
            clmAdditions = new ColumnHeader();
            clmExtra = new ColumnHeader();
            clmUnitPrc = new ColumnHeader();
            clmCalori = new ColumnHeader();
            clmAmount = new ColumnHeader();
            clmTotal = new ColumnHeader();
            btnDelete = new Button();
            label13 = new Label();
            txtGrandTotal = new TextBox();
            btnInsert = new Button();
            btnNewOrder = new Button();
            btnNewCustomer = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lowfatRadio = new RadioButton();
            fatRadio = new RadioButton();
            dietRadio = new RadioButton();
            milktypeGroup = new GroupBox();
            extraGroup = new GroupBox();
            customerGroup = new GroupBox();
            additionGroup = new GroupBox();
            caloripriceGroup = new GroupBox();
            invoiceGroup = new GroupBox();
            picturesGroup = new GroupBox();
            pictureBox2 = new PictureBox();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)numerLem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numerBanana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numerStraw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numerChoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numerAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            milktypeGroup.SuspendLayout();
            extraGroup.SuspendLayout();
            customerGroup.SuspendLayout();
            additionGroup.SuspendLayout();
            caloripriceGroup.SuspendLayout();
            invoiceGroup.SuspendLayout();
            picturesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 27);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Name Surname";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 55);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 34);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 133);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(354, 78);
            txtAddress.TabIndex = 4;
            txtAddress.TextChanged += txtName_TextChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Window;
            checkedListBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Ice Lemon", "Ice Banana", "Ice Strawberry", "Ice-Chock" });
            checkedListBox1.Location = new Point(6, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(162, 108);
            checkedListBox1.TabIndex = 5;
            // 
            // numerLem
            // 
            numerLem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numerLem.Location = new Point(186, 26);
            numerLem.Name = "numerLem";
            numerLem.Size = new Size(55, 27);
            numerLem.TabIndex = 10;
            numerLem.ValueChanged += caloriesandprices;
            // 
            // numerBanana
            // 
            numerBanana.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numerBanana.Location = new Point(186, 50);
            numerBanana.Name = "numerBanana";
            numerBanana.Size = new Size(55, 27);
            numerBanana.TabIndex = 11;
            numerBanana.ValueChanged += caloriesandprices;
            // 
            // numerStraw
            // 
            numerStraw.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numerStraw.Location = new Point(186, 73);
            numerStraw.Name = "numerStraw";
            numerStraw.Size = new Size(55, 27);
            numerStraw.TabIndex = 12;
            numerStraw.ValueChanged += caloriesandprices;
            // 
            // numerChoc
            // 
            numerChoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numerChoc.Location = new Point(186, 97);
            numerChoc.Name = "numerChoc";
            numerChoc.Size = new Size(55, 27);
            numerChoc.TabIndex = 13;
            numerChoc.ValueChanged += caloriesandprices;
            // 
            // antepnutRadio
            // 
            antepnutRadio.AutoSize = true;
            antepnutRadio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            antepnutRadio.ForeColor = Color.Black;
            antepnutRadio.Location = new Point(10, 102);
            antepnutRadio.Name = "antepnutRadio";
            antepnutRadio.Size = new Size(94, 24);
            antepnutRadio.TabIndex = 2;
            antepnutRadio.TabStop = true;
            antepnutRadio.Text = "AntepNut";
            antepnutRadio.UseVisualStyleBackColor = true;
            antepnutRadio.CheckedChanged += extras;
            // 
            // hazelnutRadio
            // 
            hazelnutRadio.AutoSize = true;
            hazelnutRadio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hazelnutRadio.ForeColor = Color.Black;
            hazelnutRadio.Location = new Point(10, 65);
            hazelnutRadio.Name = "hazelnutRadio";
            hazelnutRadio.Size = new Size(92, 24);
            hazelnutRadio.TabIndex = 1;
            hazelnutRadio.TabStop = true;
            hazelnutRadio.Text = "HazelNut";
            hazelnutRadio.UseVisualStyleBackColor = true;
            hazelnutRadio.CheckedChanged += extras;
            // 
            // peanutRadio
            // 
            peanutRadio.AutoSize = true;
            peanutRadio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            peanutRadio.ForeColor = Color.Black;
            peanutRadio.Location = new Point(10, 23);
            peanutRadio.Name = "peanutRadio";
            peanutRadio.Size = new Size(77, 24);
            peanutRadio.TabIndex = 0;
            peanutRadio.TabStop = true;
            peanutRadio.Text = "PeaNut";
            peanutRadio.UseVisualStyleBackColor = true;
            peanutRadio.CheckedChanged += extras;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(27, 41);
            label8.Name = "label8";
            label8.Size = new Size(83, 25);
            label8.TabIndex = 19;
            label8.Text = "Unit Price";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(27, 86);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 20;
            label9.Text = "Unit Calori";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(27, 123);
            label10.Name = "label10";
            label10.Size = new Size(72, 25);
            label10.TabIndex = 21;
            label10.Text = "Amount";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(27, 168);
            label11.Name = "label11";
            label11.Size = new Size(96, 25);
            label11.TabIndex = 22;
            label11.Text = "Total Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(139, 38);
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(85, 27);
            txtUnitPrice.TabIndex = 23;
            // 
            // txtUnitCalori
            // 
            txtUnitCalori.Location = new Point(139, 77);
            txtUnitCalori.Multiline = true;
            txtUnitCalori.Name = "txtUnitCalori";
            txtUnitCalori.Size = new Size(85, 34);
            txtUnitCalori.TabIndex = 24;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(139, 159);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(85, 34);
            txtTotal.TabIndex = 25;
            // 
            // numerAmount
            // 
            numerAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numerAmount.Location = new Point(139, 121);
            numerAmount.Name = "numerAmount";
            numerAmount.Size = new Size(85, 27);
            numerAmount.TabIndex = 26;
            numerAmount.ValueChanged += amountt;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clmIceCream, clmAdditions, clmExtra, clmUnitPrc, clmCalori, clmAmount, clmTotal });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(30, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(632, 226);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // clmIceCream
            // 
            clmIceCream.Text = "Ice Cream";
            clmIceCream.Width = 98;
            // 
            // clmAdditions
            // 
            clmAdditions.Text = "Additions";
            clmAdditions.Width = 101;
            // 
            // clmExtra
            // 
            clmExtra.Text = "Extra";
            clmExtra.Width = 83;
            // 
            // clmUnitPrc
            // 
            clmUnitPrc.Text = "Unit Price";
            clmUnitPrc.Width = 88;
            // 
            // clmCalori
            // 
            clmCalori.Text = "Calori";
            clmCalori.Width = 78;
            // 
            // clmAmount
            // 
            clmAmount.Text = "Amount";
            clmAmount.Width = 78;
            // 
            // clmTotal
            // 
            clmTotal.Text = "Total Price";
            clmTotal.Width = 108;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(56, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 48);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(343, 295);
            label13.Name = "label13";
            label13.Size = new Size(105, 25);
            label13.TabIndex = 30;
            label13.Text = "Grand Total";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(469, 286);
            txtGrandTotal.Multiline = true;
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.Size = new Size(125, 34);
            txtGrandTotal.TabIndex = 31;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(545, 310);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(127, 54);
            btnInsert.TabIndex = 32;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewOrder.Location = new Point(690, 310);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(127, 54);
            btnNewOrder.TabIndex = 33;
            btnNewOrder.Text = "New Order";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewCustomer.Location = new Point(836, 310);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(127, 54);
            btnNewCustomer.TabIndex = 34;
            btnNewCustomer.Text = "New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(975, 310);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 54);
            btnExit.TabIndex = 35;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(142, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(142, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(25, 123);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 78);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // lowfatRadio
            // 
            lowfatRadio.AutoSize = true;
            lowfatRadio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lowfatRadio.ForeColor = Color.Black;
            lowfatRadio.Location = new Point(88, 35);
            lowfatRadio.Name = "lowfatRadio";
            lowfatRadio.Size = new Size(80, 24);
            lowfatRadio.TabIndex = 7;
            lowfatRadio.TabStop = true;
            lowfatRadio.Text = "Low Fat";
            lowfatRadio.UseVisualStyleBackColor = true;
            lowfatRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // fatRadio
            // 
            fatRadio.AutoSize = true;
            fatRadio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fatRadio.ForeColor = Color.Black;
            fatRadio.Location = new Point(191, 35);
            fatRadio.Name = "fatRadio";
            fatRadio.Size = new Size(49, 24);
            fatRadio.TabIndex = 8;
            fatRadio.TabStop = true;
            fatRadio.Text = "Fat";
            fatRadio.UseVisualStyleBackColor = true;
            fatRadio.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // dietRadio
            // 
            dietRadio.AutoSize = true;
            dietRadio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dietRadio.ForeColor = SystemColors.ControlText;
            dietRadio.Location = new Point(11, 35);
            dietRadio.Name = "dietRadio";
            dietRadio.Size = new Size(58, 24);
            dietRadio.TabIndex = 6;
            dietRadio.TabStop = true;
            dietRadio.Text = "Diet";
            dietRadio.UseVisualStyleBackColor = true;
            dietRadio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // milktypeGroup
            // 
            milktypeGroup.Controls.Add(fatRadio);
            milktypeGroup.Controls.Add(dietRadio);
            milktypeGroup.Controls.Add(lowfatRadio);
            milktypeGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            milktypeGroup.ForeColor = Color.FromArgb(128, 128, 255);
            milktypeGroup.Location = new Point(12, 242);
            milktypeGroup.Name = "milktypeGroup";
            milktypeGroup.Size = new Size(401, 85);
            milktypeGroup.TabIndex = 41;
            milktypeGroup.TabStop = false;
            milktypeGroup.Text = "Type of Milk";
            // 
            // extraGroup
            // 
            extraGroup.Controls.Add(antepnutRadio);
            extraGroup.Controls.Add(peanutRadio);
            extraGroup.Controls.Add(hazelnutRadio);
            extraGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            extraGroup.ForeColor = Color.FromArgb(128, 128, 255);
            extraGroup.Location = new Point(12, 507);
            extraGroup.Name = "extraGroup";
            extraGroup.Size = new Size(147, 161);
            extraGroup.TabIndex = 42;
            extraGroup.TabStop = false;
            extraGroup.Text = "Extra";
            // 
            // customerGroup
            // 
            customerGroup.Controls.Add(label2);
            customerGroup.Controls.Add(txtName);
            customerGroup.Controls.Add(label3);
            customerGroup.Controls.Add(txtAddress);
            customerGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customerGroup.ForeColor = Color.FromArgb(128, 128, 255);
            customerGroup.Location = new Point(12, 12);
            customerGroup.Name = "customerGroup";
            customerGroup.Size = new Size(401, 224);
            customerGroup.TabIndex = 43;
            customerGroup.TabStop = false;
            customerGroup.Text = "Customer Information";
            // 
            // additionGroup
            // 
            additionGroup.Controls.Add(checkedListBox1);
            additionGroup.Controls.Add(numerLem);
            additionGroup.Controls.Add(numerBanana);
            additionGroup.Controls.Add(numerStraw);
            additionGroup.Controls.Add(numerChoc);
            additionGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            additionGroup.ForeColor = Color.FromArgb(128, 128, 255);
            additionGroup.Location = new Point(12, 333);
            additionGroup.Name = "additionGroup";
            additionGroup.Size = new Size(401, 168);
            additionGroup.TabIndex = 44;
            additionGroup.TabStop = false;
            additionGroup.Text = "Addition";
            // 
            // caloripriceGroup
            // 
            caloripriceGroup.Controls.Add(label8);
            caloripriceGroup.Controls.Add(label9);
            caloripriceGroup.Controls.Add(label10);
            caloripriceGroup.Controls.Add(label11);
            caloripriceGroup.Controls.Add(txtUnitPrice);
            caloripriceGroup.Controls.Add(txtUnitCalori);
            caloripriceGroup.Controls.Add(txtTotal);
            caloripriceGroup.Controls.Add(numerAmount);
            caloripriceGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            caloripriceGroup.ForeColor = Color.FromArgb(128, 128, 255);
            caloripriceGroup.Location = new Point(176, 507);
            caloripriceGroup.Name = "caloripriceGroup";
            caloripriceGroup.Size = new Size(237, 211);
            caloripriceGroup.TabIndex = 45;
            caloripriceGroup.TabStop = false;
            caloripriceGroup.Text = "Calori and Prices";
            // 
            // invoiceGroup
            // 
            invoiceGroup.Controls.Add(listView1);
            invoiceGroup.Controls.Add(btnDelete);
            invoiceGroup.Controls.Add(label13);
            invoiceGroup.Controls.Add(txtGrandTotal);
            invoiceGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            invoiceGroup.ForeColor = Color.FromArgb(128, 128, 255);
            invoiceGroup.Location = new Point(459, 366);
            invoiceGroup.Name = "invoiceGroup";
            invoiceGroup.Size = new Size(690, 352);
            invoiceGroup.TabIndex = 46;
            invoiceGroup.TabStop = false;
            invoiceGroup.Text = "Invoice";
            // 
            // picturesGroup
            // 
            picturesGroup.Controls.Add(pictureBox2);
            picturesGroup.Controls.Add(pictureBox1);
            picturesGroup.Controls.Add(pictureBox3);
            picturesGroup.Controls.Add(pictureBox4);
            picturesGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            picturesGroup.ForeColor = Color.FromArgb(128, 128, 255);
            picturesGroup.Location = new Point(673, 12);
            picturesGroup.Name = "picturesGroup";
            picturesGroup.Size = new Size(280, 224);
            picturesGroup.TabIndex = 47;
            picturesGroup.TabStop = false;
            picturesGroup.Text = "Additions Pictures";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(25, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "strawbpicture.jpg");
            ımageList1.Images.SetKeyName(1, "bananapicture.jpg");
            ımageList1.Images.SetKeyName(2, "chocpicture.jpg");
            ımageList1.Images.SetKeyName(3, "lemonpicture.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 748);
            Controls.Add(picturesGroup);
            Controls.Add(invoiceGroup);
            Controls.Add(caloripriceGroup);
            Controls.Add(additionGroup);
            Controls.Add(customerGroup);
            Controls.Add(extraGroup);
            Controls.Add(milktypeGroup);
            Controls.Add(btnExit);
            Controls.Add(btnNewCustomer);
            Controls.Add(btnNewOrder);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numerLem).EndInit();
            ((System.ComponentModel.ISupportInitialize)numerBanana).EndInit();
            ((System.ComponentModel.ISupportInitialize)numerStraw).EndInit();
            ((System.ComponentModel.ISupportInitialize)numerChoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numerAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            milktypeGroup.ResumeLayout(false);
            milktypeGroup.PerformLayout();
            extraGroup.ResumeLayout(false);
            extraGroup.PerformLayout();
            customerGroup.ResumeLayout(false);
            customerGroup.PerformLayout();
            additionGroup.ResumeLayout(false);
            caloripriceGroup.ResumeLayout(false);
            caloripriceGroup.PerformLayout();
            invoiceGroup.ResumeLayout(false);
            invoiceGroup.PerformLayout();
            picturesGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtAddress;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numerLem;
        private NumericUpDown numerBanana;
        private NumericUpDown numerStraw;
        private NumericUpDown numerChoc;
        private RadioButton antepnutRadio;
        private RadioButton hazelnutRadio;
        private RadioButton peanutRadio;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtUnitPrice;
        private TextBox txtUnitCalori;
        private TextBox txtTotal;
        private NumericUpDown numerAmount;
        private ListView listView1;
        private Button btnDelete;
        private Label label13;
        private TextBox txtGrandTotal;
        private Button btnInsert;
        private Button btnNewOrder;
        private Button btnNewCustomer;
        private Button btnExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private RadioButton lowfatRadio;
        private RadioButton fatRadio;
        private RadioButton dietRadio;
        private GroupBox milktypeGroup;
        private GroupBox extraGroup;
        private GroupBox customerGroup;
        private GroupBox additionGroup;
        private GroupBox caloripriceGroup;
        private GroupBox invoiceGroup;
        private ColumnHeader clmIceCream;
        private ColumnHeader clmAdditions;
        private ColumnHeader clmExtra;
        private ColumnHeader clmUnitPrc;
        private ColumnHeader clmCalori;
        private ColumnHeader clmAmount;
        private ColumnHeader clmTotal;
        private GroupBox picturesGroup;
        private PictureBox pictureBox2;
        private ImageList ımageList1;
    }
}