using System;
using System.Windows.Forms;

namespace треугольникV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;

            bool isEmptyOrInvalid = false;
            foreach (string s in new[] { text1, text2, text3 })
            {
                if (s == "")
                {
                    isEmptyOrInvalid = true;
                    break;
                }
                else if (!char.IsDigit(s[0]) || s.Length > 1 && !char.IsDigit(s[1]))
                {
                    isEmptyOrInvalid = true;
                    break;
                }
            }

            if (isEmptyOrInvalid)
            {
                MessageBox.Show("Одно или несколько полей содержат пустые значения или не являются цифрами.");
                return;
            }

            double a = Convert.ToDouble(text1);
            double b = Convert.ToDouble(text2);
            double c = Convert.ToDouble(text3);

            if (a == b && a == c)
            {
                this.Hide();
                var form2 = new Form2();
                form2.Show();
            }
            else if ((a == b && a != c) || (a != b && b == c))
            {
                this.Hide();
                var form3 = new Form3();
                form3.Show();
            }
            else if (a != b && a != c)
            {
                this.Hide();
                var form4 = new Form4();
                form4.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
