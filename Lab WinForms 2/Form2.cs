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
    public partial class Form2 : Form
    {
        int index = -1;
        struct country
        {
            public string name;
            public string capital;
            public int area;
        };
        country[] CntryArray = new country[5];
        public Form2()
        {
            InitializeComponent();
            CntryArray[0].name = "Італія"; CntryArray[0].capital = "Рим"; CntryArray[0].area = 3000;
            CntryArray[1].name = "Польща"; CntryArray[1].capital = "Варшава"; CntryArray[1].area = 5000;
            CntryArray[2].name = "Україна"; CntryArray[2].capital = "Київ"; CntryArray[2].area = 6000;
            CntryArray[3].name = "Германія"; CntryArray[3].capital = "Берлін"; CntryArray[3].area = 6500;
            CntryArray[4].name = "Литва"; CntryArray[4].capital = "Вільнюс"; CntryArray[4].area = 4500;
            for (int i =0; i < 5; i++)
            {
                listBox1.Items.Add(CntryArray[i].name);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        



    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            textBox1.Text = CntryArray[index].capital;
            textBox2.Text = System.Convert.ToString(CntryArray[index].area);

        }
    }
}
