using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Input()
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(N.Text);
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(0,10);
            }
            return mas;
        }
        private void Print(int[] mas)
        {
            {
                for (int i = 0; i < mas.Length; ++i) V.Text += mas[i]+ "  ";
                V.Text += Environment.NewLine;
            }
        }
        private void Change(int[] mas)
        {
            int min = mas[0];
            int max = mas[0];
            int j = 0;
            int c = 0;
            int buf;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min) min = mas[i];
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == min) { j = i; break; }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max) max = mas[i];
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == max) c = i;
            }
            buf = mas[j];
            mas[j] = mas[c];
            mas[c] = buf;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                V.Text = "";
                int[] mas = Input();
                Print(mas);
                Change(mas);
                Print(mas);
            }
            catch
            {
                V.Text = "Неккоректные данные";
            }

        }
    }
}
