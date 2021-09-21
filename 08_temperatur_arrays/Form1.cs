using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdel_Kader___Temperatur
{
    public partial class Form1 : Form
    {

        Random ran = new Random();
        int[] temp = new int[10];
        int max = 0, min = 41, ranZahl;

        private void btnTempMax_Click(object sender, EventArgs e)
        {
            max = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if(max<temp[i])
                {
                    max = temp[i];
                }

                lblTempMax.Text = "Höchsttemperatur: " + max.ToString("# °C");
            }

            lblTempMax.Visible = true;


        }

        private void btnTempMin_Click(object sender, EventArgs e)
        {
            min = 41;

            for (int i = 0; i < temp.Length; i++)
            {
                if (min > temp[i])
                {
                    min = temp[i];
                }

                lblTempMin.Text = "Tiefsttemperatur: " + min.ToString("# °C");
            }

            lblTempMin.Visible = true;
        }

        private void btnTempSort_Click(object sender, EventArgs e)
        {

            listTemp.Items.Clear();

            for (int i = 0; i < temp.Length; i++)
            {
                for (int b = 0; b < temp.Length; b++)
                {

                    if (temp[b] != temp[i] && temp[b] < temp[i])
                    {
                        listTemp.Items.Add(temp[i]);
                    }

                }
                {

            }
            }
     
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {

            listTemp.Items.Clear();

            for (int i = 0; i < temp.Length; i++)
            {

                ranZahl = ran.Next(0, 41);

                temp[i] = ranZahl;

                listTemp.Items.Add(temp[i].ToString("# °C"));
               
            }

        }
    }
}