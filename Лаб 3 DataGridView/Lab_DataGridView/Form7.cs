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
    public partial class Form7 : Form
    {
        struct Student
        {
            public string FIO;
            public int year;
            public string region;
            public string faculty;
        };

        int f1 = 0, f2 = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int years = 0;
            if (f1 == 0)
            {
                dataGridView1.Columns.Add("fio", "ПІБ");
                dataGridView1.Columns.Add("years", "Рік народження");
                dataGridView1.Columns.Add("reg", "Місто");
                dataGridView1.Columns.Add("fac", "Факультет");
            }
            f1 = 1;
            //введення інформації в textBox1
            string fio = textBox1.Text;
            if (textBox2.Text != "")
                years = Convert.ToInt32(textBox2.Text);
            string regions = textBox4.Text;
            string facyltet = textBox3.Text;
            // і відображення її в таблиці.
            dataGridView1.Rows.Add(fio, years, regions, facyltet);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student[] Stmas = new Student[dataGridView1.Rows.Count];
            if (f2 == 0)
            {
                dataGridView2.Columns.Add("fio", "ПІБ");
                dataGridView2.Columns.Add("years", "Рік народження");
                dataGridView2.Columns.Add("reg", "Місто");
                dataGridView2.Columns.Add("fac", "Факультет");
            }
            f2 = 1;
            //запис інформації з таблиці в масив структур 
            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Название";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Stmas[i].FIO = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                Stmas[i].year = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                Stmas[i].region = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                Stmas[i].faculty = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
            }
            //контрольне виведення інформації з масива структур в іншу таблицю
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView2.Rows.Add(Stmas[i].FIO, Stmas[i].year, Stmas[i].region, Stmas[i].faculty);
            }
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Form6 fr5 = new Form6();
            fr5.Show();
            Hide();
        }
    }
}
