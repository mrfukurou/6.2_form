using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] Input()
        {
            int n = int.Parse(Nn.Text);
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {

                a[i] = rand.Next(-100, 100);
            }
            return a;
        }

        public void Print(int[] a)
        {
            string str = "";
            for (int i = 0; i < a.GetLength(0); ++i)
                str += a[i] + " ";
            mas.Text = Convert.ToString(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(Num.Text);
                int count = 0;
                int[] myArray = Input();
                Print(myArray);
                for (int i = 1; i < myArray.Length; i++)
                {
                    if ((myArray[i] - myArray[i - 1]) == num)
                    {
                        count++;

                    }
                }

                if (count > 0) rez.Text=Convert.ToString("Количество пар: " + count);
                else { rez.Text = Convert.ToString("Таких пар нет"); }
            }
            catch { rez.Text = Convert.ToString("Некорректный ввод!");
                mas.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nn.Clear();
            rez.Clear();
            Num.Clear();
            mas.Clear();
        }
    }
}
