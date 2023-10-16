namespace CelFahr
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
            txtTemp = new TextBox();
            txtConTemp = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 70);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Temperature";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 171);
            label2.Name = "label2";
            label2.Size = new Size(205, 25);
            label2.TabIndex = 1;
            label2.Text = "Converted Temparature";
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(338, 70);
            txtTemp.Multiline = true;
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(167, 34);
            txtTemp.TabIndex = 2;
            // 
            // txtConTemp
            // 
            txtConTemp.Location = new Point(338, 162);
            txtConTemp.Multiline = true;
            txtConTemp.Name = "txtConTemp";
            txtConTemp.Size = new Size(167, 34);
            txtConTemp.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(216, 262);
            button1.Name = "button1";
            button1.Size = new Size(119, 62);
            button1.TabIndex = 4;
            button1.Text = "C=>F";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(432, 262);
            button2.Name = "button2";
            button2.Size = new Size(126, 62);
            button2.TabIndex = 5;
            button2.Text = "F=>C";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtConTemp);
            Controls.Add(txtTemp);
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
        private TextBox txtTemp;
        private TextBox txtConTemp;
        private Button button1;
        private Button button2;
    }
}