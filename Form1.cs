using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            int d;
            int f;
            int l;
            int nod;
            int k;
            label5.Text = "Сформируем два первых числа последовательности : 131,77.\nДалее произведем деление с остатком этих чисел";
            c = b % a; 
            label6.Text = "Остаток от деления чисел "+ b+ " и " + a+" равен" + " " + Convert.ToString(c);
            d = a % c;  
            label7.Text = "Остаток от деления чисел " + a+" и " + c+" равен" + " " + Convert.ToString(d);
            f = c % d; 
            label8.Text = "Остаток от деления чисел " + c+" и " + d+" равен" + " " + Convert.ToString(f);
            l = d % f; 
            label9.Text = "Остаток от деления чисел " + d+" и " + f+" равен" + " " + Convert.ToString(l);
            nod = f % l;
            label10.Text = "Остаток от деления чисел " + f + " и " + l+ " равен" + " " + Convert.ToString(nod);
            k = l % nod;
            label11.Text = "Остаток от деления чисел " + l + " и " + nod + " равен" + " " + Convert.ToString(k);
            label12.Text = "Сформированна конечная последовательность" + ": " + Convert.ToString(c) + ", " + Convert.ToString(d) + ", " + Convert.ToString(f) + ", " + Convert.ToString(l) + ", " + Convert.ToString(nod) + ", " + Convert.ToString(k) + ", следовательно НОД равен" + Convert.ToString(nod);
            label4.Text = "Наибольший общий делитель равен" + " " + Convert.ToString(nod);
            label13.Dispose(); // при нажатии на кнопку данный метод удаляет label
        }

    }
}
