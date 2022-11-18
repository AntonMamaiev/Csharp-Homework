using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracLISTBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox2.Items.Add("Огірок");
            listBox2.Items.Add("Помідор");
            listBox2.Items.Add("Кабачок");
            listBox2.SelectionMode = SelectionMode.MultiExtended;

            string[] ov = { "Морква", "Цибуля", "Баклажан", "Редька" };
            listBox2.Items.AddRange(ov);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(2);
            listBox2.Items.Remove("Баклажан");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            textBox1.Text = (string)listBox1.Items[i];
            listBox3.Items.Add(listBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove("Яблуко");
            listBox1.Items.Insert(3, "Слива");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = (string)listBox1.Items[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox2.Items.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            for (int x = 0; x < listBox2.Items.Count; x++)
                if (listBox2.GetSelected(x) == true)         
                    listBox3.Items.Add(listBox2.Items[x]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
