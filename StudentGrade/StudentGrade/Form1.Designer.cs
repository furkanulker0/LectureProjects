namespace StudentGrade
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
            txtName = new TextBox();
            txtLastname = new TextBox();
            txtMid = new TextBox();
            txtFinal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(292, 68);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 34);
            txtName.TabIndex = 1;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(292, 128);
            txtLastname.Multiline = true;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(164, 34);
            txtLastname.TabIndex = 2;
            // 
            // txtMid
            // 
            txtMid.Location = new Point(292, 198);
            txtMid.Multiline = true;
            txtMid.Name = "txtMid";
            txtMid.Size = new Size(164, 34);
            txtMid.TabIndex = 3;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(292, 261);
            txtFinal.Multiline = true;
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(164, 34);
            txtFinal.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 71);
            label1.Name = "label1";
            label1.Size = new Size(139, 34);
            label1.TabIndex = 5;
            label1.Text = "STUDENT NAME";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 137);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 6;
            label2.Text = "STUDENT LASTNAME";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(90, 207);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 7;
            label3.Text = "MIDTERM";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(267, 18);
            label4.Name = "label4";
            label4.Size = new Size(255, 36);
            label4.TabIndex = 8;
            label4.Text = "STUDENT INFORMATION";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(90, 270);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 9;
            label5.Text = "FINAL";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(292, 359);
            button1.Name = "button1";
            button1.Size = new Size(164, 61);
            button1.TabIndex = 10;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 513);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFinal);
            Controls.Add(txtMid);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtLastname;
        private TextBox txtMid;
        private TextBox txtFinal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}