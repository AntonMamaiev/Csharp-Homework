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
    public partial class Form6 : Form
    {
        int f = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("naz", "Назва");
            dataGridView2.Columns.Add("cina", "Ціна");
            dataGridView2.Columns.Add("kst", "Кількість");
            dataGridView2.Columns.Add("misto", "Місто постач.");

            dataGridView2.Rows.Add("Товар 1", 300, 15, "Київ");
            dataGridView2.Rows.Add("Товар 2", 785, 8, "Київ");
            dataGridView2.Rows.Add("Товар 3", 465, 7, "Львів");
            dataGridView2.Rows.Add("Товар 4", 354, 9, "Суми");
            dataGridView2.Rows.Add("Товар 5", 95, 25, "Київ");
            dataGridView2.Rows.Add("Товар 6", 452, 7, "Чернігів");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fr5= new Form5();
            fr5.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                dataGridView1.Columns.Add("naz", "Назва");
                dataGridView1.Columns.Add("cina", "Ціна");
                dataGridView1.Rows.Add("Товар 1");
                dataGridView1.Rows.Add("Товар 2");
                dataGridView1.Rows.Add("Товар 3");
                dataGridView1.Rows.Add("Товар 4");
                dataGridView1.Rows.Add("Товар 5");
                dataGridView1.Rows.Add("Товар 6");
            }
            f++;
                int k = 0;
                double sum = 0, sum2 = 0, tot = 1;
                for (int j = 0; j < 6; j++)
                {
                    sum = Convert.ToDouble(dataGridView2.Rows[j].Cells[1].Value);
                    sum2 = Convert.ToDouble(dataGridView2.Rows[j].Cells[2].Value);
                    tot = sum * sum2;
                    dataGridView1.Rows[j].Cells[1].Value = tot;
                    k++;
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (f == 1)
            {
                double sum = 0;
                for (int j = 0; j < 6; j++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[j].Cells[1].Value);
                }
                textBox1.Text = "" + sum;
            }
            else
            {
                double sum = 0, sum2 = 0, tot = 1, sumt = 0;
                for (int j = 0; j < 6; j++)
                {
                    sum = Convert.ToDouble(dataGridView2.Rows[j].Cells[1].Value);
                    sum2 = Convert.ToDouble(dataGridView2.Rows[j].Cells[2].Value);
                    tot = sum * sum2;
                    sumt += tot;
                }
                textBox1.Text = "" + sumt;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            Hide();

        }
    }
}
