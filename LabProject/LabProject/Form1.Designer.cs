namespace LabProject
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNo = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            listView1 = new ListView();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            ımageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 42);
            label1.Name = "label1";
            label1.Size = new Size(119, 34);
            label1.TabIndex = 0;
            label1.Text = "STUDENT NO";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(135, 102);
            label2.Name = "label2";
            label2.Size = new Size(62, 34);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(135, 162);
            label3.Name = "label3";
            label3.Size = new Size(62, 33);
            label3.TabIndex = 2;
            label3.Text = "AGE";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(335, 41);
            txtNo.Multiline = true;
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(125, 34);
            txtNo.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(335, 101);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 34);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(335, 161);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 34);
            txtAge.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(308, 457);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(105, 48);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(461, 457);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 48);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.LargeImageList = ımageList1;
            listView1.Location = new Point(94, 302);
            listView1.Name = "listView1";
            listView1.Size = new Size(674, 122);
            listView1.SmallImageList = ımageList1;
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female", "Male" });
            comboBox1.Location = new Point(335, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(135, 237);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 11;
            label4.Text = "GENDER";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "UNDERGRADUATE", "POSTGRADUATE" });
            comboBox2.Location = new Point(682, 161);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 12;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(545, 162);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 13;
            label5.Text = "DEGREE";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(682, 218);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 14;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(545, 218);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 15;
            label6.Text = "REGISTERED";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "download.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 528);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNo;
        private TextBox txtName;
        private TextBox txtAge;
        private Button btnInsert;
        private Button btnDelete;
        private ListView listView1;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private CheckBox checkBox1;
        private Label label6;
        private ImageList ımageList1;
    }
}