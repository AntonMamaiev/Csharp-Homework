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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = System.Convert.ToString(numericUpDown1.Value * 5);

        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = System.Convert.ToString(numericUpDown2.Value * 2);
        }

        private void button1_Click(object sender, EventArgs e)
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
            else
                numericUpDown1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                numericUpDown2.Enabled = true;
            else
                numericUpDown2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
