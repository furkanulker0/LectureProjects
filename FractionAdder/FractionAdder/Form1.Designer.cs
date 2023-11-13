namespace FractionAdder
{
    partial class FRACTIONS
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIlkPay = new TextBox();
            txtIlkPayda = new TextBox();
            txtIkıPay = new TextBox();
            txtIkıPayda = new TextBox();
            txtFres = new TextBox();
            txtDres = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 23);
            label1.Name = "label1";
            label1.Size = new Size(312, 33);
            label1.TabIndex = 0;
            label1.Text = "ADDITION OF TWO FRACTION";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 90);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "FIRST FRACTION :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(98, 137);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 2;
            label3.Text = "SECOND FRACTION :";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(96, 269);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 3;
            label4.Text = "FRACTION RESULT :";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 316);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 4;
            label5.Text = "DECIMAL RESULT :";
            // 
            // txtIlkPay
            // 
            txtIlkPay.Location = new Point(285, 87);
            txtIlkPay.Name = "txtIlkPay";
            txtIlkPay.Size = new Size(45, 27);
            txtIlkPay.TabIndex = 5;
            // 
            // txtIlkPayda
            // 
            txtIlkPayda.Location = new Point(397, 88);
            txtIlkPayda.Name = "txtIlkPayda";
            txtIlkPayda.Size = new Size(45, 27);
            txtIlkPayda.TabIndex = 6;
            // 
            // txtIkıPay
            // 
            txtIkıPay.Location = new Point(285, 137);
            txtIkıPay.Name = "txtIkıPay";
            txtIkıPay.Size = new Size(45, 27);
            txtIkıPay.TabIndex = 7;
            // 
            // txtIkıPayda
            // 
            txtIkıPayda.Location = new Point(397, 137);
            txtIkıPayda.Name = "txtIkıPayda";
            txtIkıPayda.Size = new Size(45, 27);
            txtIkıPayda.TabIndex = 8;
            // 
            // txtFres
            // 
            txtFres.Location = new Point(286, 267);
            txtFres.Multiline = true;
            txtFres.Name = "txtFres";
            txtFres.Size = new Size(156, 27);
            txtFres.TabIndex = 9;
            // 
            // txtDres
            // 
            txtDres.Location = new Point(286, 314);
            txtDres.Multiline = true;
            txtDres.Name = "txtDres";
            txtDres.Size = new Size(156, 27);
            txtDres.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(356, 86);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 11;
            label6.Text = "/";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(356, 136);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 12;
            label7.Text = "/";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(308, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 42);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FRACTIONS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDres);
            Controls.Add(txtFres);
            Controls.Add(txtIkıPayda);
            Controls.Add(txtIkıPay);
            Controls.Add(txtIlkPayda);
            Controls.Add(txtIlkPay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRACTIONS";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIlkPay;
        private TextBox txtIlkPayda;
        private TextBox txtIkıPay;
        private TextBox txtIkıPayda;
        private TextBox txtFres;
        private TextBox txtDres;
        private Label label6;
        private Label label7;
        private Button btnAdd;
    }
}