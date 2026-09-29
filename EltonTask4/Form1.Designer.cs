namespace EltonTask4
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            maskedTextBox4 = new MaskedTextBox();
            button2 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_12_08_1734521;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 62);
            label1.TabIndex = 1;
            label1.Text = "BMU TRAVEL";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bus;
            pictureBox2.Location = new Point(911, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(30, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 326);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marshurut";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(88, 254);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(88, 203);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(151, 31);
            maskedTextBox2.TabIndex = 13;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(88, 158);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(300, 51);
            button1.Name = "button1";
            button1.Size = new Size(57, 116);
            button1.TabIndex = 12;
            button1.Text = "<         >";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sumqayit", "Baki", "Quba", "Lenkeran" });
            comboBox2.Location = new Point(88, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 33);
            comboBox2.TabIndex = 11;
            comboBox2.Text = "Sec";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BMU" });
            comboBox1.Location = new Point(88, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Sec";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 265);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 9;
            label6.Text = "Yer :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 210);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 8;
            label5.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 158);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "Tarix :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 108);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Haraya :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Haradan :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(729, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 326);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sernisin melumati";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 31);
            textBox2.TabIndex = 23;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(115, 140);
            maskedTextBox4.Mask = "(999) 000-0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(177, 31);
            maskedTextBox4.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(155, 254);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Bilet al";
            button2.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(115, 94);
            maskedTextBox3.Mask = "00000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(177, 31);
            maskedTextBox3.TabIndex = 21;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 31);
            textBox1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(8, 192);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 18;
            label10.Text = "Email :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 147);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 17;
            label9.Text = "Telefon :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 101);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 16;
            label8.Text = "Fin Kod :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 51);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 15;
            label7.Text = "Ad ve Soyad :";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(118, 591);
            button3.Name = "button3";
            button3.Size = new Size(405, 29);
            button3.TabIndex = 22;
            button3.Text = "Siyahidan sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(662, 591);
            button4.Name = "button4";
            button4.Size = new Size(405, 29);
            button4.TabIndex = 23;
            button4.Text = "Proqramdan cixis";
            button4.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 475);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1093, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1215, 722);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private Label label7;
        private Button button2;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Button button3;
        private Button button4;
        private RichTextBox richTextBox1;
        private MaskedTextBox maskedTextBox4;
        private TextBox textBox2;
    }
}
