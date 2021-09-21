using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mein_erstes_Programm
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Wenn Button "GUT" geklickt wird

            label2.Text = ("keep going"); // Text von Label 2 festlegen

            button1.Visible = false;      // Sichtbarkeit der Buttons festlegen
            button2.Visible = false;      
            button3.Visible = true;       

            label1.Visible = false;       // Sichtbarkeits des 1. Labels festlegen "Wie geht es dir?"
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Der gleiche Prizip wie oben. In diesem Fall wenn Button 2 "SCHLECHT" geklickt wird
            label2.Text = ("never give up");

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;

            label1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Der gleiche Prinzip wie oben. In diesem Fall wenn Button 3 "NOCHMAL" geklickt wird
            label2.Text = ("");

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;

            label1.Visible = true;
        }
    }
}
