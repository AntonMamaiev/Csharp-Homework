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
    public partial class Form5 : Form
    {
        int f = 0, f1 = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 fr4 = new Form4();
            fr4.Show();
            Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("math", "Матем");
            dataGridView2.Columns.Add("inf", "інформ");
            dataGridView2.Columns.Add("ukr", "укр");

            dataGridView2.Rows.Add(5, 3, 2);
            dataGridView2.Rows[0].HeaderCell.Value = "Іваненко";

            dataGridView2.Rows.Add(4, 5, 3);
            dataGridView2.Rows[1].HeaderCell.Value = "Сидоренко";



        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form6 fr6 = new Form6();
            fr6.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] sr = new double[2];
            int row = dataGridView2.RowCount, col = dataGridView2.ColumnCount;
            if (f1 == 1) { col--; }
            for (int i = 0; i < row; i++)
            {
                double s = 0;
                for (int j = 0; j < col; j++)
                {
                    s = s + Convert.ToInt16(dataGridView2.Rows[i].Cells[j].Value);
                    sr[i] = s;
                }
            }
            for(int j = 0; j < row; j++)
            {
                sr[j] = sr[j] / col;
            }
            if (f == 0)
                dataGridView2.Columns.Add("sr", "Серед_бал");
            f = 1; f1=1;
            for (int i = 0; i < dataGridView2.RowCount ; i++)
                dataGridView2.Rows[i].Cells[3].Value = sr[i];

        }
            

    }
}
