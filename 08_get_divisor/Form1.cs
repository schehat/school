using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdel_Kader___Hausaufgabe_6___7
{
    public partial class Start : Form
    {
        bool maxcheck = false;
        int num, rest, sum;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void PicStartCross_Click(object sender, EventArgs e)
        {
            // Programm beenden
            Application.Exit();
        }

        private void PicStartFull_Click(object sender, EventArgs e)
        {
            // Fenster maximieren
            if (maxcheck == false)
            {
                this.WindowState = FormWindowState.Maximized;
                maxcheck = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maxcheck = false;
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnStartDice_Click(object sender, EventArgs e)
        {

        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TxtSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnStartN_Click(object sender, EventArgs e)
        {
            listRes.Items.Clear();
            sum = 0;
            try
            {
                num = Convert.ToInt32(txtNum.Text);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie ganzzahlige Zahlen ein");
                return;
            }

            for (int i = 2; i <= num; i++)
            {
                rest = num % i;

                if(rest == 0)
                {
                    listRes.Items.Add(i + " passt " + num / i + " mal in die " + num +" rein");
                    sum++;
                    if (sum > 1)
                    {
                        txtSum.Text = "Insgesamt ist die Zahl " + sum + " mal teilbar";
                    }
                    else
                    {
                        txtSum.Text = "Die Zahl ist nur dich sich selbst teilbar (Primzahl)";
                    }
                }
            }

            txtSum.Visible = true;
            txtNum.Clear();
        }

        private void BtnStartZinsen_Click(object sender, EventArgs e)
        {

        }
    }
}
