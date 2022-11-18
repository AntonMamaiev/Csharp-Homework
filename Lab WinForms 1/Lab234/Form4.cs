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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent(); 
            radioButton1.Checked = true;
            radioButton7.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // radioButton1
            if (radioButton1.Checked == true && radioButton7.Checked == true)
                textBox2.Text = textBox1.Text;
            if (radioButton1.Checked == true && radioButton8.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 100000);
            if (radioButton1.Checked == true && radioButton9.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 6894.75729);
            if (radioButton1.Checked == true && radioButton10.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 101325);
            if (radioButton1.Checked == true && radioButton11.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 9.80665);
            if (radioButton1.Checked == true && radioButton12.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 133.32237);
            // radioButton2
            if (radioButton2.Checked == true && radioButton8.Checked == true)
                textBox2.Text = textBox1.Text;
            if (radioButton2.Checked == true && radioButton7.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.00001);
            if (radioButton2.Checked == true && radioButton9.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.0689476);
            if (radioButton2.Checked == true && radioButton10.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 1.01325);
            if (radioButton2.Checked == true && radioButton11.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.0000980665);
            if (radioButton2.Checked == true && radioButton12.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.0013332237);
            // radioButton3
            if (radioButton3.Checked == true && radioButton7.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.000145038);
            if (radioButton3.Checked == true && radioButton8.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 14.50377);
            if (radioButton3.Checked == true && radioButton9.Checked == true)
                textBox2.Text = textBox1.Text; 
            if (radioButton3.Checked == true && radioButton10.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 14.69595);
            if (radioButton3.Checked == true && radioButton11.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.00142233);
            if (radioButton3.Checked == true && radioButton12.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.0193368);
            // radioButton4
            if (radioButton4.Checked == true && radioButton7.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.101325);
            if (radioButton4.Checked == true && radioButton8.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.986923);
            if (radioButton4.Checked == true && radioButton9.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.068046);
            if (radioButton4.Checked == true && radioButton10.Checked == true)
                textBox2.Text = textBox1.Text;
            if (radioButton4.Checked == true && radioButton11.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.0000967841);
            if (radioButton4.Checked == true && radioButton12.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.00131579);
            // radioButton5
            if (radioButton5.Checked == true && radioButton7.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.101972);
            if (radioButton5.Checked == true && radioButton8.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 10197.16213);
            if (radioButton5.Checked == true && radioButton9.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 703.06958);
            if (radioButton5.Checked == true && radioButton10.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 10332.27453);
            if (radioButton5.Checked == true && radioButton11.Checked == true)
                textBox2.Text = textBox1.Text;            
            if (radioButton5.Checked == true && radioButton12.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 13.5951);
            // radioButton6
            if (radioButton6.Checked == true && radioButton7.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.00750062);
            if (radioButton6.Checked == true && radioButton8.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 750.06168);
            if (radioButton6.Checked == true && radioButton9.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 51.71493);
            if (radioButton6.Checked == true && radioButton10.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 760);
            if (radioButton6.Checked == true && radioButton11.Checked == true)
                textBox2.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) / 0.0735559);
            if (radioButton6.Checked == true && radioButton12.Checked == true)
                textBox2.Text = textBox1.Text;            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
