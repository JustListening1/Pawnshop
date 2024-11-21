using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pawnshop
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int admincode = 12345;

        private void button1_Click(object sender, EventArgs e)
        {
            // Attempt to parse the text in textBox1 to an integer
            if (int.TryParse(textBox1.Text, out int enteredCode))
            {
                if (enteredCode == admincode)
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid admin code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }   
}
