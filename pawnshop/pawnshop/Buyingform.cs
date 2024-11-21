using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pawnshop
{
    public partial class Buyingform : Form
    {
        public Buyingform()
        {
            InitializeComponent();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Buyingform_Load(object sender, EventArgs e)
        {

        }

        private void chb_iphone_CheckedChanged(object sender, EventArgs e)
        {


            if (chb_iphone.Checked)
            {
               
                listBox1.Items.Add("iphone X ₱7,500");
            }
            else
            {
                
                listBox1.Items.Remove("iphone X ₱7,500");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {

                listBox1.Items.Add("gold bar 5g 18karat");
            }
            else
            {

                listBox1.Items.Remove("gold bar 5g 18karat");
            }
        }



        private void chb_S23_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_S23.Checked)
            {

                listBox1.Items.Add("samsung s23");
            }
            else
            {

                listBox1.Items.Remove("samsung s23");
            }
        }

        private void chb_rog_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_rog.Checked)
            {

                listBox1.Items.Add("rog");
            }
            else
            {

                listBox1.Items.Remove("rog");
            }
        }

        private void chb_red_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_red.Checked)
            {

                listBox1.Items.Add("red");
            }
            else
            {

                listBox1.Items.Remove("red");
            }
        }

        private void chb_redmi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_redmi.Checked)
            {

                listBox1.Items.Add("Redmi");
            }
            else
            {

                listBox1.Items.Remove("Redmi");
            }
        }

        private void chb_A53_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_A53.Checked)
            {

                listBox1.Items.Add("samsung A53");
            }
            else
            {

                listBox1.Items.Remove("samsung A53");
            }
        }

        private void chb_shark_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_shark.Checked)
            {

                listBox1.Items.Add("shark");
            }
            else
            {

                listBox1.Items.Remove("shark");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {

                listBox1.Items.Add("Bracelet Rose Gold");
            }
            else
            {

                listBox1.Items.Remove("Bracelet Rose Gold");
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {

                listBox1.Items.Add("Ring Bi-Color");
            }
            else
            {

                listBox1.Items.Remove("Ring Bi-Color");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {

                listBox1.Items.Add("Earring Tri-Color");
            }
            else
            {

                listBox1.Items.Remove("Earring Tri-Color");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {

                listBox1.Items.Add("Necklace White Gold");
                
            }
            else
            {

                listBox1.Items.Remove("Necklace White Gold");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
