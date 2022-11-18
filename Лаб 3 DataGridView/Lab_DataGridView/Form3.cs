using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_DataGridView
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, 2);
            dataGridView1.Rows.Add(3, 4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] mas = new int[2, 2];

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    mas[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);            
            textBox1.Text = Convert.ToString(mas[0, 0]);
            textBox2.Text = Convert.ToString(mas[0, 1]);
            textBox3.Text = Convert.ToString(mas[1, 0]);
            textBox4.Text = Convert.ToString(mas[1, 1]);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
