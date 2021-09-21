using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdel_Kader___Hausaufgabe_Nr._7
{
    public partial class Form1 : Form
    {

        int n = 0, sum = 0, counter = 0, adder = 0;


        private void btn_for_Click(object sender, EventArgs e)
        {

            for(int i = 0; i <= 5; i++)
            {
                adder++;
                sum = sum + adder;
            }

            lbl_summe.Text = "Summe: " + sum.ToString("0");

            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_do_Click(object sender, EventArgs e)
        {

            do
            {

                adder++;
                sum = sum + adder;
                counter++;

            }

            while (counter <= 5);

            lbl_summe.Text = "Summe: " + sum.ToString("0");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
