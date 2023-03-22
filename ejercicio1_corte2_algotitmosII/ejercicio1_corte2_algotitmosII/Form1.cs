using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1_corte2_algotitmosII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Cantidad = Convert.ToInt16(textBox1.Text);
            int C100, C50, C20, C10, C5, C1, D50, D10, D01;
            C100 = 0;
            C50 = 0;
            C20 = 0;
            C10 = 0;
            C5 = 0;
            C1 = 0;
            D50 = 0;
            D10 = 0;
            D01 = 0;

            if ((Cantidad >= 100))
            {
                C100 = ((int)Cantidad / 100);
                Cantidad = Cantidad - (C100 * 100);
            }
            if ((Cantidad >= 50))
            {
                C50 = ((int)Cantidad / 50);
                Cantidad = Cantidad - (C50 * 50);
            }
            if ((Cantidad >= 20))
            {
                C20 = ((int)Cantidad / 20);
                Cantidad = Cantidad - (C20 * 20);
            }
            if ((Cantidad >= 10))
            {
                C10 = ((int)Cantidad / 10);
                Cantidad = Cantidad - (C10 * 10);
            }
            if ((Cantidad >= 5))
            {
                C5 = ((int)Cantidad / 5);
                Cantidad = Cantidad - (C5 * 5);
            }
            if ((Cantidad >= 1))
            {
                C1 = ((int)Cantidad / 1);
                Cantidad = Cantidad - (C1 * 1);
            }
            if ((Cantidad >= 0.5))
            {
                D50 = (int)(Cantidad / 0.5);
                Cantidad = Cantidad - (float)(D50 * 0.5);
            }
            if ((Cantidad >= 0.1))
            {
                D10 = (int)(Cantidad / 0.1);
                Cantidad = Cantidad - (float)(D10 * 0.1);
            }
            if ((Cantidad >= 0.01))
            {
                D01 = (int)Math.Round(Cantidad / 0.01);
                Cantidad = Cantidad - (float)(D01 * 0.01);
            }

            listBox1.Items.Add("Billetes de 100: " + C100);
            listBox1.Items.Add("Billetes de 50: " + C50);
            listBox1.Items.Add("Billetes de 20: " + C20);
            listBox1.Items.Add("Billetes de 10: " + C10);
            listBox1.Items.Add("Billetes de 5: " + C5);
            listBox1.Items.Add("Monedas de 1: " + C1);
            listBox1.Items.Add("Monedas de 0.50: " + D50);
            listBox1.Items.Add("Monedas de 0.10: " + D10);
            listBox1.Items.Add("Monedas de 0.01: " + D01);
        }          
    }
}
