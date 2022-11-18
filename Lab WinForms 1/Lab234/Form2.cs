using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab234
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown44.Enabled = false;
            numericUpDown33.Enabled = false;
            numericUpDown66.Enabled = false;
            numericUpDown55.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = System.Convert.ToString(numericUpDown1.Value * 5);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = System.Convert.ToString(numericUpDown2.Value * 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true)
                textBox3.Text = System.Convert.ToString(numericUpDown1.Value * 5 + numericUpDown2.Value * 2);
            else
                textBox3.Text = System.Convert.ToString(0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                numericUpDown1.Enabled = true;
            else { 
                numericUpDown1.Enabled = false;
                textBox1.Text = System.Convert.ToString(0);
                numericUpDown1.Value = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                numericUpDown2.Enabled = true;
            else
            {
                numericUpDown2.Enabled = false;
                textBox2.Text = System.Convert.ToString(0);
                numericUpDown2.Value = 0;
            }
        }


        //Газованка
        
        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
                numericUpDown33.Enabled = true;
            else
            {
                numericUpDown33.Enabled = false;
                textBox33.Text = System.Convert.ToString(0);
                numericUpDown33.Value = 0;
            }
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked == true)
                numericUpDown44.Enabled = true;
            else
            {
                numericUpDown44.Enabled = false;
                textBox44.Text = System.Convert.ToString(0);
                numericUpDown44.Value = 0;
            }
        }

        private void numericUpDown33_ValueChanged(object sender, EventArgs e)
        {
            textBox33.Text = System.Convert.ToString(numericUpDown33.Value * 10);
        }

        private void numericUpDown44_ValueChanged(object sender, EventArgs e)
        {
            textBox44.Text = System.Convert.ToString(numericUpDown44.Value * 3);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (checkBox44.Checked == true || checkBox33.Checked == true)
                textBox43.Text = System.Convert.ToString(numericUpDown33.Value * 10 + numericUpDown44.Value * 3);
            else
                textBox43.Text = System.Convert.ToString(0);
        }

        // Чаї
        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox55.Checked == true)
                numericUpDown55.Enabled = true;
            else
            {
                numericUpDown55.Enabled = false;
                textBox55.Text = System.Convert.ToString(0);
                numericUpDown55.Value = 0;
            }
        }

        private void checkBox66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox66.Checked == true)
                numericUpDown66.Enabled = true;
            else
            {
                numericUpDown66.Enabled = false;
                textBox66.Text = System.Convert.ToString(0);
                numericUpDown55.Value = 0;
            }
        }

        private void numericUpDown55_ValueChanged(object sender, EventArgs e)
        {
            textBox55.Text = System.Convert.ToString(numericUpDown55.Value * 6);
        }

        private void numericUpDown66_ValueChanged(object sender, EventArgs e)
        {
            textBox66.Text = System.Convert.ToString(numericUpDown66.Value * 8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox55.Checked == true || checkBox66.Checked == true)
                textBox56.Text = System.Convert.ToString(numericUpDown55.Value * 6 + numericUpDown66.Value * 8);
            else
                textBox56.Text = System.Convert.ToString(0);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Text = System.Convert.ToString(numericUpDown55.Value * 6 + numericUpDown66.Value * 8 + numericUpDown33.Value * 10 + numericUpDown44.Value * 3 + numericUpDown1.Value * 5 + numericUpDown2.Value * 2);
        }
    }
}
