namespace LabTask
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
            txtIdNum = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtOOPgrade = new TextBox();
            txtCalculusGrade = new TextBox();
            txtDataStructureGrade = new TextBox();
            txtStudentAvg = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnShow = new Button();
            rchTxtBox = new RichTextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtIdNum
            // 
            txtIdNum.Location = new Point(185, 33);
            txtIdNum.Name = "txtIdNum";
            txtIdNum.Size = new Size(125, 27);
            txtIdNum.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(185, 123);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 3;
            // 
            // txtOOPgrade
            // 
            txtOOPgrade.Location = new Point(185, 179);
            txtOOPgrade.Name = "txtOOPgrade";
            txtOOPgrade.Size = new Size(125, 27);
            txtOOPgrade.TabIndex = 4;
            // 
            // txtCalculusGrade
            // 
            txtCalculusGrade.Location = new Point(185, 229);
            txtCalculusGrade.Name = "txtCalculusGrade";
            txtCalculusGrade.Size = new Size(125, 27);
            txtCalculusGrade.TabIndex = 5;
            // 
            // txtDataStructureGrade
            // 
            txtDataStructureGrade.Location = new Point(185, 289);
            txtDataStructureGrade.Name = "txtDataStructureGrade";
            txtDataStructureGrade.Size = new Size(125, 27);
            txtDataStructureGrade.TabIndex = 6;
            // 
            // txtStudentAvg
            // 
            txtStudentAvg.Location = new Point(185, 341);
            txtStudentAvg.Name = "txtStudentAvg";
            txtStudentAvg.Size = new Size(125, 27);
            txtStudentAvg.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 8;
            label1.Text = "ID Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 130);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 8;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 186);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "OOP Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 236);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 8;
            label5.Text = "Calculus Grade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 296);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 8;
            label6.Text = "Data Structure Grade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 344);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 9;
            label7.Text = "Student Average:";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(474, 308);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(118, 73);
            btnShow.TabIndex = 10;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // rchTxtBox
            // 
            rchTxtBox.Location = new Point(386, 33);
            rchTxtBox.Name = "rchTxtBox";
            rchTxtBox.Size = new Size(299, 252);
            rchTxtBox.TabIndex = 11;
            rchTxtBox.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(131, 396);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 42);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(rchTxtBox);
            Controls.Add(btnShow);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtStudentAvg);
            Controls.Add(txtDataStructureGrade);
            Controls.Add(txtCalculusGrade);
            Controls.Add(txtOOPgrade);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtIdNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdNum;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtOOPgrade;
        private TextBox txtCalculusGrade;
        private TextBox txtDataStructureGrade;
        private TextBox txtStudentAvg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnShow;
        private RichTextBox rchTxtBox;
        private Button btnSave;
    }
}