namespace ders3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtResult = new TextBox();
            btnMin = new Button();
            btnAvg = new Button();
            btnMax = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 64);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "First Number";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 130);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Second Number";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 196);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 2;
            label3.Text = "Third Number";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(124, 261);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "Result";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(329, 55);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 34);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(329, 121);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 34);
            txtNum2.TabIndex = 5;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(329, 187);
            txtNum3.Multiline = true;
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(125, 34);
            txtNum3.TabIndex = 6;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(329, 252);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 34);
            txtResult.TabIndex = 7;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.Location = new Point(514, 336);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(115, 48);
            btnMin.TabIndex = 8;
            btnMin.Text = "Max";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnAvg
            // 
            btnAvg.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvg.Location = new Point(329, 336);
            btnAvg.Name = "btnAvg";
            btnAvg.Size = new Size(125, 48);
            btnAvg.TabIndex = 9;
            btnAvg.Text = "Avg";
            btnAvg.UseVisualStyleBackColor = true;
            btnAvg.Click += btnAvg_Click;
            // 
            // btnMax
            // 
            btnMax.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMax.Location = new Point(148, 336);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(115, 48);
            btnMax.TabIndex = 10;
            btnMax.Text = "Min";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMax);
            Controls.Add(btnAvg);
            Controls.Add(btnMin);
            Controls.Add(txtResult);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtResult;
        private Button btnMin;
        private Button btnAvg;
        private Button btnMax;
    }
}