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
    public partial class Form4 : Form
    {
        int f = 0, f2 = 0, f3=0, f5 = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] Matr;
            Matr = new int[2, 4];
            int Length_i = Matr.GetLength(0), Length_j = Matr.GetLength(1);
            //заповнення матриці
            for (int i = 0; i < Length_i; i++)
                for (int j = 0; j < Length_j; j++)
                    Matr[i, j] = i + j;
            //виведення матриці в dataGridView
            for (int i = 0; i < Length_i; i++)
            {
                if (f5 == 0)
                    dataGridView1.Rows.Add();
                for (int j = 0; j < Length_j; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Matr[i, j];
            }
            f5 = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //знайти суми елементів кожного рядка і вивести в додатковий стовпчик
            int n = dataGridView2.Columns.Count, m = dataGridView2.Rows.Count;
            int[,] mas = new int[m, n];
            int sumr = 0;
            int Length_i = mas.GetLength(0), Length_j = mas.GetLength(1);

            for (int i = 0; i < Length_i; i++)
                for (int j = 0; j < Length_j; j++)
                    mas[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
            if (f == 0)
                dataGridView2.Columns.Add("column5", "Сума ряду");
            f = 1;
            if (Length_j == 4)
                Length_j -= 1;
            for (int i = 0; i < Length_i; i++)
            {
                for (int j = 0; j < Length_j+1; j++)
                {
                    if (i < Length_i && j < Length_j)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = mas[i, j];
                        sumr += mas[i, j];
                    }
                    else
                        dataGridView2.Rows[i].Cells[j].Value = sumr;

                }
                sumr = 0;
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //знайти суми елементів кожного стовпчика  і вивести в додатковий рядок.
            int n = dataGridView2.Columns.Count, m = dataGridView2.Rows.Count;
            int[,] mas = new int[m, n];
            int[] sum = new int[n];
            int k=0;
            int Length_i = mas.GetLength(0), Length_j = mas.GetLength(1);

            for (int i = 0; i < Length_j; i++)
                sum[i] = 0;

            for (int i = 0; i < Length_i; i++)
                for (int j = 0; j < Length_j; j++)
                    mas[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
            if (f2 == 0)
                dataGridView2.Rows.Add();
            f2 = 1;
            if (Length_i == 4)
                Length_i -=1;
            for (int j = 0; j < Length_j; j++)
            {
                for (int i = 0; i < Length_i; i++)
                {
                    sum[k] += mas[i, j];
                }
                k++;
            }
            k = 0;
            for (int i = 0; i < Length_i+1; i++)
            {
                for (int j = 0; j < Length_j; j++)
                {
                    if (i < Length_i && j < Length_j)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = mas[i, j];
                    }
                    if (i == m)
                        dataGridView2.Rows[i].Cells[j].Value = sum[j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[,] Matr;
            Matr = new int[3, 3];
            int Length_i = Matr.GetLength(0), Length_j = Matr.GetLength(1);
            //заповнення матриці
            for (int i = 0; i < Length_i; i++)
                for (int j = 0; j < Length_j; j++)
                    Matr[i, j] = rand.Next(-10,10);
            //виведення матриці в dataGridView
            for (int i = 0; i < Length_i; i++)
            {
                if (f3 == 0)
                    dataGridView2.Rows.Add();
                for (int j = 0; j < Length_j; j++)
                    dataGridView2.Rows[i].Cells[j].Value = Matr[i, j];
            }
            f3 = 1;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //знайти суму елементів головної діагоналі
            int n = dataGridView2.Columns.Count, m = dataGridView2.Rows.Count;
            int[,] mas = new int[m, n];
            int sum=0;
            int Length_i = mas.GetLength(0), Length_j = mas.GetLength(1);

            for (int i = 0; i < Length_i; i++)
                for (int j = 0; j < Length_j; j++)
                    mas[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);

            for (int i = 0; i < Length_i; i++)
            {
                sum += mas[i, i];
            }
            textBox1.Text = "" + sum;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //знайти максимальний елемент і вивести в текстове вікно
            int n = dataGridView2.Columns.Count, m = dataGridView2.Rows.Count;
            int[,] mas = new int[m, n];
            int max = -100;
            int Length_i = mas.GetLength(0), Length_j = mas.GetLength(1);

            for (int i = 0; i < Length_i; i++)
                for (int j = 0; j < Length_j; j++)
                    mas[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);

            for (int i = 0; i < Length_i; i++)
            {
                for (int j = 0; j < Length_j; j++)
                {
                    if (max <= mas[i, j])
                        max = mas[i, j];
                }
            }
            textBox2.Text = ""+max;
        }
    }
}
