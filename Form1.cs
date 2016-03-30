using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Form1 : Form
    {
        private int spravne_odpovede = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prva otazka
            string pomocny = textBox1.Text.Replace(" ","").ToLower();
            if (pomocny.Equals("arpanet"))
            {
                spravne_odpovede++;
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
            //druha otazka
            if (radioButton1.Checked)
            {
                spravne_odpovede++;
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.ForeColor = Color.Red;
            }
            //tretia otazka
            if (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && !checkBox4.Checked)
            {
                spravne_odpovede++;
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.ForeColor = Color.Red;
            }
            //stvrta otazka
            if (radioButton5.Checked)
            {
                spravne_odpovede++;
                label4.ForeColor = Color.Green;
            }
            else
            {
                label4.ForeColor = Color.Red;
            }
            //piata otazka
            pomocny = comboBox1.Text;
            if (pomocny.Equals("hviezdicova"))
            {
                spravne_odpovede++;
                label5.ForeColor = Color.Green;
            }
            else
            {
                label5.ForeColor = Color.Red;
            }
            //siesta otazka
            pomocny = dateTimePicker1.Value.ToShortDateString();
            if (pomocny.Equals("1. 1. 1970"))
            {
                spravne_odpovede++;
                label7.ForeColor = Color.Green;
            }
            else
            {
                label7.ForeColor = Color.Red;
            }

            label6.Text = "Počet spávnych odpovedí: " + spravne_odpovede;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
