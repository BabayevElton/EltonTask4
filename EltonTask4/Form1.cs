using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace EltonTask4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            comboBox1.Text = b;
            comboBox2.Text = a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;

            richTextBox1.Text += a + Environment.NewLine +
                                  b + Environment.NewLine +
                                  maskedTextBox1.Text + Environment.NewLine +
                                  maskedTextBox2.Text + Environment.NewLine +
                                  numericUpDown1.Text + Environment.NewLine +
                                  textBox1.Text + Environment.NewLine +
                                  maskedTextBox3.Text + Environment.NewLine +
                                  maskedTextBox4.Text + Environment.NewLine +
                                  textBox2.Text + Environment.NewLine +
                                  "------------------------" + Environment.NewLine;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sehife baglansinmi?", "Melumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

