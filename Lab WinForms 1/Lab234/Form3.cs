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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                this.BackColor = System.Drawing.Color.Yellow;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                this.BackColor = System.Drawing.Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                this.BackColor = System.Drawing.Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton4.Checked == true)
                textBox1.Text = "вибрано жовтий і radioButton4";
            else if (radioButton1.Checked == true && radioButton5.Checked == true)
                textBox1.Text = "вибрано жовтий і radioButton5";
            else if (radioButton2.Checked == true && radioButton4.Checked == true)
                textBox1.Text = "вибрано синій і radioButton4";
            else if (radioButton2.Checked == true && radioButton5.Checked == true)
                textBox1.Text = "вибрано синій і radioButton5";
            else if (radioButton3.Checked == true && radioButton4.Checked == true)
                textBox1.Text = "вибрано червоний і radioButton4";
            else if (radioButton3.Checked == true && radioButton5.Checked == true)
                textBox1.Text = "вибрано червоний і radioButton5";
        }
    }
}
