using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Start : Form
    {

        bool maxcheck = false;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void picMinStart_Click(object sender, EventArgs e)
        {
            //minimieren
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMaxStart_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Programm beenden
            Application.Exit();
        }

        private void lblStartTitle_Click(object sender, EventArgs e)
        {

        }

        private void PanelStartTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegeln_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe spielt man auf einem 3x3 Felder großen Feld. Es spielen zwei Spieler gegen einander, wobei sie abwechselnd ein leeres Feld mit ihrem Zeichen markieren. Der eine Spieler benutzt Kreuze als Markierung und der andere Spieler benutzt Kreise. Der erste Spieler, der es schafft, drei seiner Symbole ohne Unterbrechung in einer Reihe zu haben, gewinnt das Spiel augenblicklich. Als Reihe gelten waagerechte, senkrechte oder diagonale Reihen.", "Tic Tac Toe Regeln", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // neue Form zeigen
            Form Spiel = new Spiel();
            Spiel.Show();
            this.Hide();
        }
    }
}